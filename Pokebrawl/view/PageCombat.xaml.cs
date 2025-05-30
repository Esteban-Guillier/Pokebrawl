using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Pokebrawl.model;

namespace Pokebrawl.view
{
    /// <summary>
    /// Logique d'interaction pour Combat.xaml
    /// </summary>
    public partial class PageCombat : Page
    {
        private Frame _mainFrame;
        private Pokemon playerPkmn;
        private Pokemon enemyPkmn;
        private GameSession _session;
        private bool _isPlayerTurn = true;

        public PageCombat(Frame mainFrame, GameSession session)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _session = session;
            PokemonEvents.OnDemandeRemplacementCapacite = (poke, newMove) =>
            {
                _mainFrame.Navigate(new PageRemplacementAttaque(_mainFrame, poke, newMove));
            };
            _session.NextCombat();
            RefreshUI();
        }

        private void RefreshUI()
        {
            var playerPkmn = _session.CurrentPlayerPokemon;
            var enemyPkmn = _session.CurrentEnemyPokemon;

            // Affichage Avatar joueur
            if (playerPkmn != null)
            {
                Uri avatarUri;
                if (Uri.IsWellFormedUriString(AppData.Joueur.Avatar, UriKind.Absolute))
                    avatarUri = new Uri(AppData.Joueur.Avatar, UriKind.Absolute);
                else
                    avatarUri = new Uri(AppData.Joueur.Avatar, UriKind.Relative);
                AvatarImg.Source = new BitmapImage(avatarUri);

                // Pokémon joueur (dos)
                string playerImgPath = playerPkmn.ImageDos ?? playerPkmn.ImageFace;
                Uri playerUri = Uri.IsWellFormedUriString(playerImgPath, UriKind.Absolute)
                    ? new Uri(playerImgPath, UriKind.Absolute)
                    : new Uri(playerImgPath, UriKind.Relative);
                PlayerPkmnImg.Source = new BitmapImage(playerUri);

                PlayerPkmnName.Text = playerPkmn.Nom;
                PlayerPVBar.Maximum = playerPkmn.PVMax;
                PlayerPVBar.Value = playerPkmn.PV;
                PlayerPkmnLvl.Text = $"Niveau : {playerPkmn.Niveau}";
            }

            // Affichage ennemi (face)
            if (enemyPkmn != null)
            {
                Uri enemyUri = Uri.IsWellFormedUriString(enemyPkmn.ImageFace, UriKind.Absolute)
                    ? new Uri(enemyPkmn.ImageFace, UriKind.Absolute)
                    : new Uri(enemyPkmn.ImageFace, UriKind.Relative);
                EnemyPkmnImg.Source = new BitmapImage(enemyUri);

                EnemyPkmnName.Text = enemyPkmn.Nom;
                EnemyPVBar.Maximum = enemyPkmn.PVMax;
                EnemyPVBar.Value = enemyPkmn.PV;
                EnemyPkmnLvl.Text = $"Niveau : {enemyPkmn.Niveau}";
            }

            // Générer dynamiquement les boutons d'attaque dans AttackPanel (vertical)
            AttackPanel.Children.Clear();
            foreach (var atk in playerPkmn.Attaques)
            {
                var btn = new Button
                {
                    Content = $"{atk.Nom} (PP {atk.PP}/{atk.PPMax})",
                    Margin = new Thickness(0, 5, 0, 0),
                    Width = 140
                };
                btn.Click += (s, e) => Attack_Click(atk);
                AttackPanel.Children.Add(btn);
            }

            // Afficher ou cacher le bouton "Utiliser une Ball"
            if (BtnBall != null)
                BtnBall.Visibility = !_session.IsBossFight ? Visibility.Visible : Visibility.Collapsed;

            // Afficher ou cacher le bouton "Changer de Pokémon" (si au moins 2 Pokémon vivants)
            int nbAlive = _session.Team.Count(p => p.PV > 0);
            if (BtnSwitch != null)
                BtnSwitch.Visibility = nbAlive > 1 ? Visibility.Visible : Visibility.Collapsed;
        }
        private void EnemyTurn()
        {
            // ... logique d'attaque adverse ...
            if (_session.CurrentPlayerPokemon.PV <= 0)
            {
                // Essaye de switcher de Pokémon
                if (_session.SwitchToNextAlivePlayerPokemon())
                {
                    MessageBox.Show("Votre Pokémon est KO ! Envoi du suivant.");
                    _isPlayerTurn = true;
                    RefreshUI();
                    return;
                }
                else
                {
                    Defeat();
                    return;
                }
            }
            _isPlayerTurn = true;
            RefreshUI();
        }
        private void Attack_Click(Attaque attaque)
        {
            if(!_isPlayerTurn) return;
            if (attaque.PP <= 0) { MessageBox.Show("Plus de PP !"); return; }
            attaque.PP--;
            _session.CurrentEnemyPokemon.PV -= attaque.Puissance; // Ajoute un champ Power à Attaque si besoin
            if (_session.CurrentEnemyPokemon.PV <= 0)
            {
                _session.CurrentEnemyPokemon.PV = 0;
                Victory();
            }
            else
            {
                _isPlayerTurn = false;
                RefreshUI();
                EnemyTurn();
            }
        }
        private void UseBall_Click(object sender, RoutedEventArgs e)
        {
            // Décrémente le nombre de balls du joueur, tente capture, utilise le tour
            // Si capture réussie : ajoute le Pokémon à l'équipe (si place)
            // Sinon : tour de l'adversaire
            MessageBox.Show("Tentative de capture (à implémenter)");
            _isPlayerTurn = false;
            EnemyTurn();
        }

        private void Victory()
        {
            MessageBox.Show("Victoire !");
            // Gagner de l'exp, de l'argent
            _session.Money += 50;
            _session.CurrentPlayerPokemon.GainExp(20);
            // Gestion du level up, apprentissage capacité, évolution...
            if (_session.IsBossFight)
            {
                // Aller à la page magasin
                _mainFrame.Navigate(new Magasin(_mainFrame, _session));
            }
            else
            {
                // Prochain combat
                _session.NextCombat();
                RefreshUI();
            }
        }

        private void Defeat()
        {
            MessageBox.Show("Défaite !");
            // Retour menu ou page Game Over
            _mainFrame.Navigate(new PageGameOver(_mainFrame));
        }
        private void SwitchPkmn_Click(object sender, RoutedEventArgs e)
        {
            
            if (_session.SwitchToNextAlivePlayerPokemon())
            {
                MessageBox.Show("Changement de Pokémon !");
                RefreshUI();
            }
            else
            {
                MessageBox.Show("Aucun autre Pokémon disponible !");
            }
        }
    }
}

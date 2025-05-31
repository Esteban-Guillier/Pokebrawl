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
                Uri avatarUri = Uri.IsWellFormedUriString(AppData.Joueur.Avatar, UriKind.Absolute)
                    ? new Uri(AppData.Joueur.Avatar, UriKind.Absolute)
                    : new Uri(AppData.Joueur.Avatar, UriKind.Relative);
                AvatarImg.Source = new BitmapImage(avatarUri);

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

            // Affichage ennemi
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

            // Affichage des attaques
            AttackPanel.Children.Clear();
            if (playerPkmn != null)
            {
                foreach (var atk in playerPkmn.Attaques)
                {
                    var btn = new Button
                    {
                        Content = $"{atk.Nom} (PP {atk.PP}/{atk.PPMax})",
                        Margin = new Thickness(5)
                    };
                    btn.Click += (s, e) => Attack_Click(atk);
                    AttackPanel.Children.Add(btn);
                }
            }

            // Ajoute le bouton "Utiliser une Ball" si ce n'est pas un boss
            if (!_session.IsBossFight)
            {
                var ballBtn = new Button { Content = "Utiliser une Ball", Margin = new Thickness(5) };
                ballBtn.Click += UseBall_Click;
                AttackPanel.Children.Add(ballBtn);
            }
            // Ajoute le bouton "Changer de Pokémon" si possible
            if (_session.Team.Count(p => p.PV > 0) > 1)
            {
                var switchBtn = new Button { Content = "Changer de Pokémon", Margin = new Thickness(5) };
                switchBtn.Click += SwitchPkmn_Click;
                AttackPanel.Children.Add(switchBtn);
            }
        }
        private void EnemyTurn()
        {
            var enemy = _session.CurrentEnemyPokemon;
            var player = _session.CurrentPlayerPokemon;

            // Choisit une attaque aléatoire de l'adversaire
            var atk = enemy.Attaques.Where(a => a.PP > 0).OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
            if (atk != null)
            {
                atk.PP--;
                player.PV -= atk.Puissance;
                if (player.PV < 0) player.PV = 0;
                MessageBox.Show($"{enemy.Nom} utilise {atk.Nom} !");
            }
            else
            {
                MessageBox.Show($"{enemy.Nom} n'a plus de PP !");
            }

            if (player.PV <= 0)
            {
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

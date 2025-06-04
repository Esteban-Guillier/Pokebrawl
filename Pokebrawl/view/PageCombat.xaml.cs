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
            try
            {
                _session.NextCombat();
                if (_session.CurrentPlayerPokemon == null || _session.CurrentPlayerPokemon.PV <= 0)
                {
                    MessageBox.Show("Aucun Pokémon valide pour combattre !");
                    _mainFrame.Navigate(new PageGameOver(_mainFrame, AppData.Joueur));
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Aucun Pokémon valide pour combattre !");
                _mainFrame.Navigate(new PageGameOver(_mainFrame, AppData.Joueur));
                return;
            }
            RefreshUI();
        }

        private void RefreshUI()
        {
            var playerPkmn = _session.CurrentPlayerPokemon;
            var enemyPkmn = _session.CurrentEnemyPokemon;

            if (playerPkmn == null || playerPkmn.PV <= 0)
            {
                MessageBox.Show("Aucun Pokémon valide pour combattre !");
                _mainFrame.Navigate(new PageGameOver(_mainFrame, AppData.Joueur));
                return;
            }

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

        private void SwitchPkmn_Click(object sender, RoutedEventArgs e)
        {
            var remplaçants = _session.Team.Where(p => p.PV > 0 && p != _session.CurrentPlayerPokemon).ToList();
            if (remplaçants.Count == 0)
            {
                MessageBox.Show("Aucun autre Pokémon disponible !");
                return;
            }
            var choixWindow = new ChoixPokemonWindow(remplaçants, "Choisissez un Pokémon à envoyer :", "Envoyer");
            if (choixWindow.ShowDialog() == true)
            {
                var choisi = choixWindow.PokemonSelectionne;
                if (choisi != null)
                {
                    _session.SwitchToPokemon(choisi);
                    MessageBox.Show($"Vous avez envoyé {choisi.Nom} !");
                    _isPlayerTurn = false;
                    RefreshUI();
                    EnemyTurn();
                }
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
            // Vérifie si le joueur possède une Ball dans l'inventaire
            if (!AppData.Joueur.Inventaire.Possede("Ball") && !AppData.Joueur.Inventaire.Possede("Poké Ball"))
            {
                MessageBox.Show("Vous n'avez plus de Ball !");
                return;
            }

            // Retire une Ball du bon type
            if (AppData.Joueur.Inventaire.Possede("Ball"))
                AppData.Joueur.Inventaire.Retirer("Ball");
            else if (AppData.Joueur.Inventaire.Possede("Poké Ball"))
                AppData.Joueur.Inventaire.Retirer("Poké Ball");

            // Calcul basique de la probabilité de capture
            double captureChance = 0.2 + (1.0 - (double)_session.CurrentEnemyPokemon.PV / _session.CurrentEnemyPokemon.PVMax) * 0.8;
            Random rand = new Random();
            bool captureSuccess = rand.NextDouble() < captureChance;

            if (captureSuccess)
            {
                if (AppData.Joueur.Equipe.Pokemons.Count >= Equipe.MaxPokemons)
                {
                    MessageBox.Show($"Capture réussie, mais votre équipe est pleine ");
                }
                else if (AppData.Joueur.Equipe.PointsUtilises + _session.CurrentEnemyPokemon.CoutEquipe > Equipe.MaxPoints)
                {
                    MessageBox.Show($"Capture réussie, mais vous n'avez pas assez de points pour ajouter ce Pokémon à votre équipe");
                }
                else
                {
                    // Ajouter une copie du Pokémon ennemi à l'équipe du joueur
                    var clone = _session.CurrentEnemyPokemon.Clone();
                    AppData.Joueur.Equipe.Pokemons.Add(clone);
                    MessageBox.Show($"{_session.CurrentEnemyPokemon.Nom} capturé avec succès ");
                }

                Victory();
            }
            else
            {
                MessageBox.Show($"{_session.CurrentEnemyPokemon.Nom} s'est libéré ");
                _isPlayerTurn = false;
                EnemyTurn();
            }
        }

        private void Victory()
        {
            MessageBox.Show("Victoire !");
            AppData.Joueur.Argent += 50;

            var playerPkmn = _session.CurrentPlayerPokemon;
            int niveauAvant = playerPkmn.Niveau;
            string nomAvant = playerPkmn.Nom;
            int attaquesAvant = playerPkmn.Attaques.Count;

            // L'apprentissage/évolution/ajout de capacité sera géré via l'événement dans GainExp
            playerPkmn.GainExp(_session.CurrentPlayerPokemon.ExpDonnee);

            // Gestion du level up
            if (playerPkmn.Niveau > niveauAvant)
            {
                MessageBox.Show($"{playerPkmn.Nom} monte au niveau {playerPkmn.Niveau} !");
            }

            // Gestion de l'évolution
            if (playerPkmn.Nom != nomAvant)
            {
                MessageBox.Show($"{nomAvant} évolue en {playerPkmn.Nom} !");
            }

            // Nouvelle attaque apprise (si moins de 4 attaques)
            if (playerPkmn.Attaques.Count > attaquesAvant)
            {
                var nouvelleAttaque = playerPkmn.Attaques.Last();
                MessageBox.Show($"{playerPkmn.Nom} apprend une nouvelle attaque : {nouvelleAttaque.Nom} !");
            }
            // Si il y a déjà 4 attaques, la navigation vers PageRemplacementAttaque sera déclenchée
            // automatiquement par l'événement PokemonEvents.OnDemandeRemplacementCapacite

            if (_session.IsBossFight)
            {
                _mainFrame.Navigate(new PageMagasin(_mainFrame, AppData.Joueur));
            }
            else
            {
                _session.NextCombat();
                RefreshUI();
            }
        }

        private void Defeat()
        {
            MessageBox.Show("Défaite !");
            // Retour menu ou page Game Over
            _mainFrame.Navigate(new PageGameOver(_mainFrame, AppData.Joueur));
        }
        }
    }

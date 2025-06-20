﻿using System;
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
            AppData.Joueur.Inventaire.Ajouter("Ball", 5);
            
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
            if (_session.CombatsTermines == 100)
            {
                enemyPkmn = Pokemon.BossEtage100.Clone();

                if (_session.IsBossFight)
                {
                    var bossClone = _session.CurrentEnemyPokemon.Clone();
                    bossClone.Niveau = 60;

                    if (!PageEquipe.starters.Any(p => p.Nom == bossClone.Nom))
                    {
                        PageEquipe.starters.Add(bossClone);
                        MessageBox.Show($"{bossClone.Nom} a été ajouté à vos starters !");
                    }
                }
            }
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
                        Margin = new Thickness(5),
                        Background = GetColorBrushFromType(atk.Type),
                        Foreground = Brushes.White,
                        FontWeight = FontWeights.Bold
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

        private Brush GetColorBrushFromType(TypePokemon type)
        {
            return type switch
            {
                TypePokemon.Feu => Brushes.OrangeRed,
                TypePokemon.Eau => Brushes.DodgerBlue,
                TypePokemon.Plante => Brushes.ForestGreen,
                TypePokemon.Electrik => Brushes.Gold,
                TypePokemon.Ténèbres => Brushes.DarkSlateGray,
                TypePokemon.Poison => Brushes.Purple,
                TypePokemon.Spectre => Brushes.Indigo,
                TypePokemon.Vol => Brushes.LightGray,
                TypePokemon.Insecte => Brushes.Green,
                TypePokemon.Combat => Brushes.SaddleBrown,
                TypePokemon.Roche => Brushes.Brown,
                TypePokemon.Acier => Brushes.LightSlateGray,
                TypePokemon.Sol => Brushes.SandyBrown,
                TypePokemon.Glace => Brushes.LightBlue,
                TypePokemon.Psy => Brushes.MediumPurple,
                TypePokemon.Fée => Brushes.HotPink,
                TypePokemon.Dragon => Brushes.MediumSlateBlue,
                TypePokemon.Normal => Brushes.Gray,
                _ => Brushes.Gray
            };
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
            if (atk == null)
            {
                MessageBox.Show($"{enemy.Nom} n'a plus de PP !");
            }

            atk.PP--;

            int attaqueStat = enemy.Attaque;
            int defenseStat = player.Defense;
            int puissance = atk.Puissance;

            // STAB
            double stab = enemy.Types.Contains(atk.Type) ? 1.5 : 1.0;

            // Coefficient de type
            double typeCoef = 1.0;
            foreach (var defType in player.Types)
            {
                typeCoef *= TypeChart.GetCoef(atk.Type, defType);
            }

            // Calcul des dégâts
            double facteur = ((2.0 * enemy.Niveau + 2) * puissance * (double)attaqueStat / defenseStat) / 40 ;
            int degats = (int)(facteur * stab * typeCoef);
            if (degats <= 0) degats = 1;

            player.PV -= degats;
            if (player.PV < 0) player.PV = 0;

            // Message d'efficacité
            string msg = $"{enemy.Nom} utilise {atk.Nom} !\n";
            if (typeCoef == 0)
                msg += "Cela n’a aucun effet !";
            else if (typeCoef < 1)
                msg += "Ce n’est pas très efficace...";
            else if (typeCoef > 1)
                msg += "C’est super efficace !";
            else
                msg += "C’est efficace.";

            MessageBox.Show(msg);

            if (player.PV <= 0)
            {
                if (_session.Team.Count > 0)
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
                player.PV = 0;
                Defeat();
            }
            else
            {
                _isPlayerTurn = true;
                RefreshUI();
            }
        }
        private void Attack_Click(Attaque attaque)
        {
            if (!_isPlayerTurn) return;

            if (attaque.PP <= 0)
            {
                MessageBox.Show("Plus de PP !");
                return;
            }

            attaque.PP--;

            var attaquant = _session.CurrentPlayerPokemon;
            var defenseur = _session.CurrentEnemyPokemon;

            int attaqueStat = attaquant.Attaque;
            int defenseStat = defenseur.Defense;
            int puissance = attaque.Puissance;

            // STAB : le Pokémon a-t-il le même type que l'attaque ?
            double stab = attaquant.Types.Contains(attaque.Type) ? 1.5 : 1.0;

            // Coefficients de type (attaque vs tous les types de défense)
            double typeCoef = 1.0;
            foreach (var defType in defenseur.Types)
            {
                typeCoef *= TypeChart.GetCoef(attaque.Type, defType);
            }

            // Calcul des dégâts
            double facteur = ((2.0 * attaquant.Niveau / 5 + 2) * puissance * (double)attaqueStat / defenseStat) / 50 + 2;
            int degats = (int)(facteur * stab * typeCoef);
            if (degats <= 0) degats = 1;

            defenseur.PV -= degats;
            if (defenseur.PV < 0) defenseur.PV = 0;

            // Message d'efficacité
            string msg = $"{attaquant.Nom} utilise {attaque.Nom} !\n";
            if (typeCoef == 0)
                msg += "Cela n’a aucun effet !";
            else if (typeCoef < 1)
                msg += "Ce n’est pas très efficace...";
            else if (typeCoef > 1)
                msg += "C’est super efficace !";
            else
                msg += "C’est efficace.";

            MessageBox.Show(msg);

            if (defenseur.PV <= 0)
            {
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
                    List<Pokemon> starter = PageEquipe.starters;
                    // Ajouter une copie du Pokémon ennemi à l'équipe du joueur
                    var clone = _session.CurrentEnemyPokemon.Clone();
                    AppData.Joueur.Equipe.Pokemons.Add(clone);
                    MessageBox.Show($"{_session.CurrentEnemyPokemon.Nom} capturé avec succès ");
                    GameSession.AjouterAuxStartersSiNouveau(clone, starter);
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

            int baseExp = _session.CurrentEnemyPokemon.ExpDonnee;
            int bonusCombat = _session.CombatsTermines * 2;
            int totalExp = baseExp + bonusCombat;

            playerPkmn.GainExp(totalExp);


            // Gestion du level up
            if (playerPkmn.Niveau > niveauAvant)
            {
                playerPkmn.PVMax += 2;
                playerPkmn.Attaque += 1;
                playerPkmn.Defense += 1;
                playerPkmn.AttaqueSpe += 1;
                playerPkmn.DefenseSpe += 1;
                playerPkmn.Vitesse += 1;

                MessageBox.Show($"{playerPkmn.Nom} a gagné en puissance !\n" +
                    $"PV: {playerPkmn.PVMax}, Atk: {playerPkmn.Attaque}, Def: {playerPkmn.Defense},\n" +
                    $"AtkSpe: {playerPkmn.AttaqueSpe}, DefSpe: {playerPkmn.DefenseSpe}, Vit: {playerPkmn.Vitesse}");
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
                _session.CombatsTermines++;
                _mainFrame.Navigate(new PageMagasin(_mainFrame, AppData.Joueur));
            }
            else
            {
                _session.CombatsTermines++;
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

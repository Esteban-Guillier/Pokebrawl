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

        public PageCombat(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;

            playerPkmn = AppData.Joueur.Equipe.Pokemons.Count > 0 ? AppData.Joueur.Equipe.Pokemons[0] : null;
            enemyPkmn = new Pokemon { Nom = "Rattata", Niveau = 2, PV = 10, PVMax = 10, ImageFace = "rattata_face.png" };

            RefreshUI();
        }

        private void RefreshUI()
        {
            if (playerPkmn != null)
            {
                AvatarImg.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(AppData.Joueur.Avatar, System.UriKind.Relative));
                PlayerPkmnImg.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(playerPkmn.ImageDos ?? playerPkmn.ImageFace, System.UriKind.Relative));
                PlayerPkmnName.Text = playerPkmn.Nom;
                PlayerPVBar.Maximum = playerPkmn.PVMax;
                PlayerPVBar.Value = playerPkmn.PV;
                PlayerPkmnLvl.Text = $"Niveau : {playerPkmn.Niveau}";
            }
            if (enemyPkmn != null)
            {
                EnemyPkmnImg.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(enemyPkmn.ImageFace, System.UriKind.Relative));
                EnemyPkmnName.Text = enemyPkmn.Nom;
                EnemyPVBar.Maximum = enemyPkmn.PVMax;
                EnemyPVBar.Value = enemyPkmn.PV;
                EnemyPkmnLvl.Text = $"Niveau : {enemyPkmn.Niveau}";
            }
            // Attaques
            AttackPanel.Children.Clear();
            if (playerPkmn?.Attaques != null)
            {
                foreach (var atk in playerPkmn.Attaques)
                {
                    var btn = new Button { Content = $"{atk.Nom} (PP {atk.PP}/{atk.PPMax})", Margin = new Thickness(5) };
                    btn.Click += (s, e) => Attack_Click(atk);
                    AttackPanel.Children.Add(btn);
                }
            }
        }

        private void Attack_Click(Attaque attaque)
        {
            // Logique de combat à compléter...
            MessageBox.Show($"{playerPkmn.Nom} utilise {attaque.Nom} !");
            // Mets à jour les PV, PP etc.
            RefreshUI();
        }
    }
}

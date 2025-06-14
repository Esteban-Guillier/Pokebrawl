﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Pokebrawl.model;

namespace Pokebrawl.view
{
    public partial class PageMagasin : Page
    {
        private Joueur _joueur;
        private Frame _mainFrame;
        private GameSession _session;
        public List<MagasinItem> Items = new()
        {
            new MagasinItem { Nom = "Potion", Image = "/view/image/icon/potionheal.png", Prix = 200, Type = ItemType.Potion },
            new MagasinItem { Nom = "Ball", Image = "/view/image/icon/Ball.png", Prix = 150, Type = ItemType.Ball }
        };

        public PageMagasin(Frame mainFrame, Joueur joueur)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _joueur = joueur;
            ShopItemsList.ItemsSource = Items;
            UpdateArgent();
        }

        private void UpdateArgent()
        {
            ArgentText.Text = $"Argent : {_joueur.Argent} ₽";
        }
        private void Acheter_Click(object sender, RoutedEventArgs e)
        {
            if (sender is not Button btn) return;
            if (btn.Tag is not MagasinItem item) return;

            if (_joueur.Argent < item.Prix)
            {
                MessageBox.Show("Pas assez d'argent !");
                return;
            }

            if (item.Type == ItemType.Potion)
            {
                var choixPokemonWindow = new ChoixPokemonWindow(_joueur.Equipe.Pokemons);
                if (choixPokemonWindow.ShowDialog() == true)
                {
                    var pokemon = choixPokemonWindow.PokemonSelectionne;
                    if (pokemon != null)
                    {
                        pokemon.PV = pokemon.PVMax;
                        _joueur.Argent -= item.Prix;
                        _joueur.Inventaire.Ajouter(item.Nom, 1);
 
                        MessageBox.Show($"{pokemon.Nom} est soigné !");
                        UpdateArgent();
                    }
                }
            }
            else if (item.Type == ItemType.Ball)
            {
                _joueur.Argent -= item.Prix;
                _joueur.Inventaire.Ajouter(item.Nom, 1);
                MessageBox.Show("Ball ajoutée à l'inventaire !");
                UpdateArgent();
            }
        }

        private void Continuer_Click(object sender, RoutedEventArgs e)
        {
            foreach (var pkmn in _joueur.Equipe.Pokemons)
            {
                foreach (var attaque in pkmn.Attaques)
                {
                    attaque.PP = attaque.PPMax;
                }
            }
            _mainFrame.Navigate(new PageCombat(_mainFrame, new GameSession(_joueur.Equipe.Pokemons)));
        }
    }
}


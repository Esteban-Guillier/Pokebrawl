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
    /// Logique d'interaction pour Magasin.xaml
    /// </summary>
    public partial class Magasin : Window
    {
        private Frame _mainFrame;
        private GameSession _session;
        public Magasin(Frame mainFrame, GameSession session)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _session = session;
        }
        public Magasin()
        {
            InitializeComponent();
        }
    }
}

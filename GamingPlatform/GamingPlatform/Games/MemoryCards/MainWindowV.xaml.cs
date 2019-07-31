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
using GamingPlatform.Games.MemoryCards.ViewModels;

namespace GamingPlatform.Games.MemoryCards
{
    /// <summary>
    /// Логика взаимодействия для MainWindowV.xaml
    /// </summary>
    public partial class MainWindowV : Window
    {
        public MainWindowV()
        {
            InitializeComponent();
            DataContext = new StartMenuVM(this);
        }
    }
}

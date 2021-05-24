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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool accountActivate;
        public MainWindow()
        {
            InitializeComponent();
            this.Resources.Add("fontSize", 19);
            this.Resources.Remove("fontSize");
            
            mainInfo.Content = new KatalogPage( ); 
        }

        
    }
}
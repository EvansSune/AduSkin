﻿using Prism.Regions;
using System.Windows;

namespace PrismRegionTest.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            RegionManager.SetRegionName(MyContent, "ContentRegion");
        }
    }
}

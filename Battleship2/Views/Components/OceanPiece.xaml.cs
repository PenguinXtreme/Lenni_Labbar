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

namespace Battleship2.Views.Components
{
    /// <summary>
    /// Interaction logic for OceanPiece.xaml
    /// </summary>
    public partial class OceanPiece : UserControl
    {


        public SolidColorBrush OceanColor
        {
            get { return (SolidColorBrush)GetValue(OceanColorProperty); }
            set { SetValue(OceanColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OceanColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OceanColorProperty =
            DependencyProperty.Register("OceanColor", typeof(SolidColorBrush), typeof(OceanPiece), new PropertyMetadata(Brushes.Pink));


        public OceanPiece()
        {
            InitializeComponent();
        }
    }
}

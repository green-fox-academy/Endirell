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
using GreenFox;

namespace Wanderer
{    
    public partial class MainWindow : Window
    {
        private FoxDraw FoxDraw;

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw = new FoxDraw(canvas);
            
            FoxDraw Floor = new FoxDraw(canvas);

            Map.Mapmaker(Floor, 10);
            
            FoxDraw.AddImage("Asset/boss.png", 0, 0);
        }


        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]) - 50;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]);
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }

            if (e.Key == Key.Right)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]) + 50;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]);
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }


            if (e.Key == Key.Down)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]);
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]) + 50;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }

            if (e.Key == Key.Up)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]);
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]) - 50;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }


        }
    }
}
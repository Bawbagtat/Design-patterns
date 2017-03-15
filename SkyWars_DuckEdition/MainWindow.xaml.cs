using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
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

namespace SkyWars_DuckEdition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player np = new Player();
        Enemy ep;
        
        public MainWindow()
        {
            InitializeComponent();
            gameGridPoplulate();
            np.movement();
            showPlayer();
        }

        private void gameGridPoplulate()
        {
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            ColumnDefinition gridCol3 = new ColumnDefinition();
            ColumnDefinition gridCol4 = new ColumnDefinition();
            gameGrid.ColumnDefinitions.Add(gridCol1);
            gameGrid.ColumnDefinitions.Add(gridCol2);
            gameGrid.ColumnDefinitions.Add(gridCol3);
            gameGrid.ColumnDefinitions.Add(gridCol4);

            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(90);
            RowDefinition gridRow2 = new RowDefinition();
            gridRow2.Height = new GridLength(90);
            RowDefinition gridRow3 = new RowDefinition();
            gridRow3.Height = new GridLength(90);
            RowDefinition gridRow4 = new RowDefinition();
            gridRow4.Height = new GridLength(90);
            gameGrid.RowDefinitions.Add(gridRow1);
            gameGrid.RowDefinitions.Add(gridRow2);
            gameGrid.RowDefinitions.Add(gridRow3);
            gameGrid.RowDefinitions.Add(gridRow4);

            TextBlock txtBlock1 = new TextBlock();
            txtBlock1.Text = "Sector Space";
            txtBlock1.FontSize = 14;
            txtBlock1.FontWeight = FontWeights.Bold;
            txtBlock1.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock1.Background = new SolidColorBrush(Colors.Black);
            txtBlock1.VerticalAlignment = VerticalAlignment.Center;
            txtBlock1.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock1, 0);
            Grid.SetColumn(txtBlock1, 0);

            TextBlock txtBlock2 = new TextBlock();
            txtBlock2.Text = "Sector Space";
            txtBlock2.FontSize = 14;
            txtBlock2.FontWeight = FontWeights.Bold;
            txtBlock2.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock2.VerticalAlignment = VerticalAlignment.Center;
            txtBlock2.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock2, 0);
            Grid.SetColumn(txtBlock2, 1);

            TextBlock txtBlock3 = new TextBlock();
            txtBlock3.Text = "Sector Space";
            txtBlock3.FontSize = 14;
            txtBlock3.FontWeight = FontWeights.Bold;
            txtBlock3.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock3.VerticalAlignment = VerticalAlignment.Center;
            txtBlock3.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock3, 0);
            Grid.SetColumn(txtBlock3, 2);

            TextBlock txtBlock4 = new TextBlock();
            txtBlock4.Text = "Sector Space";
            txtBlock4.FontSize = 14;
            txtBlock4.FontWeight = FontWeights.Bold;
            txtBlock4.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock4.VerticalAlignment = VerticalAlignment.Center;
            txtBlock4.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock4, 0);
            Grid.SetColumn(txtBlock4, 3);

            TextBlock txtBlock5 = new TextBlock();
            txtBlock5.Text = "Sector Space";
            txtBlock5.FontSize = 14;
            txtBlock5.FontWeight = FontWeights.Bold;
            txtBlock5.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock5.VerticalAlignment = VerticalAlignment.Center;
            txtBlock5.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock5, 1);
            Grid.SetColumn(txtBlock5, 0);

            TextBlock txtBlock6 = new TextBlock();
            txtBlock6.Text = "Sector Space";
            txtBlock6.FontSize = 14;
            txtBlock6.FontWeight = FontWeights.Bold;
            txtBlock6.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock6.VerticalAlignment = VerticalAlignment.Center;
            txtBlock6.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock6, 1);
            Grid.SetColumn(txtBlock6, 1);

            TextBlock txtBlock7 = new TextBlock();
            txtBlock7.Text = "Sector Space";
            txtBlock7.FontSize = 14;
            txtBlock7.FontWeight = FontWeights.Bold;
            txtBlock7.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock7.VerticalAlignment = VerticalAlignment.Center;
            txtBlock7.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock7, 1);
            Grid.SetColumn(txtBlock7, 2);

            TextBlock txtBlock8 = new TextBlock();
            txtBlock8.Text = "Sector Space";
            txtBlock8.FontSize = 14;
            txtBlock8.FontWeight = FontWeights.Bold;
            txtBlock8.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock8.VerticalAlignment = VerticalAlignment.Center;
            txtBlock8.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock8, 1);
            Grid.SetColumn(txtBlock8, 3);

            TextBlock txtBlock9 = new TextBlock();
            txtBlock9.Text = "Sector Space";
            txtBlock9.FontSize = 14;
            txtBlock9.FontWeight = FontWeights.Bold;
            txtBlock9.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock9.VerticalAlignment = VerticalAlignment.Center;
            txtBlock9.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock9, 2);
            Grid.SetColumn(txtBlock9, 0);

            TextBlock txtBlock10 = new TextBlock();
            txtBlock10.Text = "Sector Space";
            txtBlock10.FontSize = 14;
            txtBlock10.FontWeight = FontWeights.Bold;
            txtBlock10.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock10.VerticalAlignment = VerticalAlignment.Center;
            txtBlock10.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock10, 2);
            Grid.SetColumn(txtBlock10, 1);

            TextBlock txtBlock11 = new TextBlock();
            txtBlock11.Text = "Sector Space";
            txtBlock11.FontSize = 14;
            txtBlock11.FontWeight = FontWeights.Bold;
            txtBlock11.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock11.VerticalAlignment = VerticalAlignment.Center;
            txtBlock11.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock11, 2);
            Grid.SetColumn(txtBlock11, 2);

            TextBlock txtBlock12 = new TextBlock();
            txtBlock12.Text = "Sector Space";
            txtBlock12.FontSize = 14;
            txtBlock12.FontWeight = FontWeights.Bold;
            txtBlock12.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock12.VerticalAlignment = VerticalAlignment.Center;
            txtBlock12.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock12, 2);
            Grid.SetColumn(txtBlock12, 3);

            TextBlock txtBlock13 = new TextBlock();
            txtBlock13.Text = "Sector Space";
            txtBlock13.FontSize = 14;
            txtBlock13.FontWeight = FontWeights.Bold;
            txtBlock13.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock13.VerticalAlignment = VerticalAlignment.Center;
            txtBlock13.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock13, 3);
            Grid.SetColumn(txtBlock13, 0);

            TextBlock txtBlock14 = new TextBlock();
            txtBlock14.Text = "Sector Space";
            txtBlock14.FontSize = 14;
            txtBlock14.FontWeight = FontWeights.Bold;
            txtBlock14.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock14.VerticalAlignment = VerticalAlignment.Center;
            txtBlock14.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock14, 3);
            Grid.SetColumn(txtBlock14, 1);

            TextBlock txtBlock15 = new TextBlock();
            txtBlock15.Text = "Sector Space";
            txtBlock15.FontSize = 14;
            txtBlock15.FontWeight = FontWeights.Bold;
            txtBlock15.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock15.VerticalAlignment = VerticalAlignment.Center;
            txtBlock15.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock15, 3);
            Grid.SetColumn(txtBlock15, 2);

            TextBlock txtBlock16 = new TextBlock();
            txtBlock16.Text = "Sector Space";
            txtBlock16.FontSize = 14;
            txtBlock16.FontWeight = FontWeights.Bold;
            txtBlock16.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock16.VerticalAlignment = VerticalAlignment.Center;
            txtBlock16.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(txtBlock16, 3);
            Grid.SetColumn(txtBlock16, 3);

            gameGrid.Children.Add(txtBlock1);
            gameGrid.Children.Add(txtBlock2);
            gameGrid.Children.Add(txtBlock3);
            gameGrid.Children.Add(txtBlock4);
            gameGrid.Children.Add(txtBlock5);
            gameGrid.Children.Add(txtBlock6);
            gameGrid.Children.Add(txtBlock7);
            gameGrid.Children.Add(txtBlock8);
            gameGrid.Children.Add(txtBlock9);
            gameGrid.Children.Add(txtBlock10);
            gameGrid.Children.Add(txtBlock11);
            gameGrid.Children.Add(txtBlock12);
            gameGrid.Children.Add(txtBlock13);
            gameGrid.Children.Add(txtBlock14);
            gameGrid.Children.Add(txtBlock15);
            gameGrid.Children.Add(txtBlock16);

            
            
               
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Sound file paths may have to be changed in order to function
            var SongLocation = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resources\\Freedom_.wav";
            SoundPlayer sndPlayer = new SoundPlayer();
            np.setMode(1);
            sndPlayer.SoundLocation = SongLocation;
            sndPlayer.Play();
            Thread.Sleep(500);
            MessageBox.Show(np.shipMode + " Engaged");
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Sound file paths may have to be changed in order to function
            var SongLocation = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resources\\braveheartc.wav";
            SoundPlayer sndPlayer = new SoundPlayer();
            np.setMode(0);
            sndPlayer.SoundLocation = SongLocation;
            sndPlayer.Play();
            Thread.Sleep(500);
            MessageBox.Show(np.shipMode + " Engaged");
        }

        private void showPlayer()
        {
            string location = np.location;
            var values = location.Split(',');
            //Searched and found at http://stackoverflow.com/questions/1511722/how-to-programmatically-access-control-in-wpf-grid-by-row-and-column-index
            //Finds the textbox at the current x and y co-ordinate in order to change value
            TextBlock txt = (TextBlock)gameGrid.Children.Cast<UIElement>().First(e => Grid.GetRow(e) == Convert.ToInt32(values[0]) && Grid.GetColumn(e) == Convert.ToInt32(values[1]));

            txt.Text = "Player";
            Grid.SetRow(txt, Convert.ToInt32(values[0]));
            Grid.SetColumn(txt, Convert.ToInt32(values[1]));

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string location = np.location;
            var values = location.Split(',');
            TextBlock txt = (TextBlock)gameGrid.Children.Cast<UIElement>().First(i => Grid.GetRow(i) == Convert.ToInt32(values[0]) && Grid.GetColumn(i) == Convert.ToInt32(values[1]));

            txt.Text = "Sector Space";
            Grid.SetRow(txt, Convert.ToInt32(values[0]));
            Grid.SetColumn(txt, Convert.ToInt32(values[1]));

            //Check to ensure movement applies if enemy exists
            if (ep != null)
            {
                ep.movement();
                showEnemy();
            }
            //Thread used to allow for time to see movement of all cells
            Thread.Sleep(700);
            np.movement();
            showPlayer();

            

            Random rng = new Random();
            
            int num = rng.Next(0, 2);
            if(num == 0)
            {
                ep = new Enemy();
                ep.spawn();
                ep.setEnemy();
                playSound();
                showEnemy();
            
            }
        }

        private void showEnemy()
        {
            string location = ep.location;
            var values = location.Split(',');
            //Searched and found at http://stackoverflow.com/questions/1511722/how-to-programmatically-access-control-in-wpf-grid-by-row-and-column-index
            //Finds the textbox at the current x and y co-ordinate in order to change value
            TextBlock txt = (TextBlock)gameGrid.Children.Cast<UIElement>().First(e => Grid.GetRow(e) == Convert.ToInt32(values[0]) && Grid.GetColumn(e) == Convert.ToInt32(values[1]));
            if (txt.Text.Contains("Player"))
            {
                txt.Text = ep.enemyChoice + " " + "Player";
            }
            else
            {
                txt.Text = ep.enemyChoice;
            }
            Grid.SetRow(txt, Convert.ToInt32(values[0]));
            Grid.SetColumn(txt, Convert.ToInt32(values[1]));

        }

        public void playSound()
        {
            //Sound played when new enemy is spawned 
            var SongLocation = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\..\\..\\Resources\\Atari-SoundBible.com-1865789765.wav";
            SoundPlayer sndPlayer = new SoundPlayer();

            //File path must be adjusted depending on souce of file for now
            sndPlayer.SoundLocation = SongLocation;
            sndPlayer.Play();



        }

        private void clearLocationPlayer()
        {
            //After player has moved from cell resets cell value to Sector Space
            string location = np.location;
            var values = location.Split(',');
            TextBlock txt = (TextBlock)gameGrid.Children.Cast<UIElement>().First(i => Grid.GetRow(i) == Convert.ToInt32(values[0]) && Grid.GetColumn(i) == Convert.ToInt32(values[1]));

            txt.Text = "Sector Space";
            Grid.SetRow(txt, Convert.ToInt32(values[0]));
            Grid.SetColumn(txt, Convert.ToInt32(values[1]));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Undo move using command
            clearLocationPlayer();
            np.undoMove();
            Thread.Sleep(500);
            if (np.movetemp > 0)
            {
             showPlayer();
            }
        }
    }
}

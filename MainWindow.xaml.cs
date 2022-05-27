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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; }
        public int Counter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }
        public void NewGame() 
        {
            IsPlayer1Turn = false;
            Counter = 0;
            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsPlayer1Turn ^= true;
            if (Counter >= 9)
            {
                NewGame();
                return;
            }
            var button = sender as Button;
            if (button.Content == string.Empty)
            {
                button.Content = IsPlayer1Turn ? "O" : "X";
                Counter++;
            }

            if (CheckIfPlayerWon())
            {
                Counter = 9;
            }
        }
        private bool CheckIfPlayerWon() 
        {
            
            return false;
        }
    }
}

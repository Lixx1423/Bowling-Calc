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

namespace Bowling_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double game1 = 0;
        double game2 = 0;
        double game3 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Exit/X button
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            // Calculate the final score
            Double.TryParse(Game1.Text, out game1);
            Double.TryParse(Game2.Text, out game2);
            Double.TryParse(Game3.Text, out game3);
            double answer = game1 + game2 + game3;

            Final_Score.Text = answer.ToString();

            // Calculate the Average score
            Double.TryParse(Game1.Text, out game1);
            Double.TryParse(Game2.Text, out game2);
            Double.TryParse(Game3.Text, out game3);
            double answer2 = game1 + game2 + game3 / 3;

            Average_Score.Text = answer2.ToString();

            // Calculate the Handicap Score
            Double.TryParse(Game1.Text, out game1);
            Double.TryParse(Game2.Text, out game2);
            Double.TryParse(Game3.Text, out game3);
            double answer3 = game1 + game2 + game3 - 200 * .8;

            Handicap_Score.Text = answer3.ToString();

            // Displaying the High Score
            if (game1 > game2)
            {
                if (game1 > game3)
                {
                    double Score1 = game1;
                    High_Game.Text = Score1.ToString();
                }
            }
        
            if (game2 > game1)
            {
                if (game2 > game3)
                {
                    double Score2 = game2;
                    High_Game.Text = Score2.ToString();
                }
                
            }

            if (game3 > game1)
            {
                if (game3 > game2)
                {
                    double Score3 = game3;
                    High_Game.Text = Score3.ToString();
                }
            }

            if (game1 == game2)
            {
                High_Game.Text = "Tie";
            }

            if (game1 == game3)
            {
                High_Game.Text = "Tie";
            }

            if (game2 == game1)
            {
                High_Game.Text = "Tie";

            }

            if (game2 == game3)
            {
                High_Game.Text = "Tie";
            }

            if (game3 == game2)
            {
                High_Game.Text = "Tie";
            }

            if (game3 == game1)
            {
                High_Game.Text = "Tie";
            }
        }

        //Clear all of the scores and calcualtions
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Game1.Text = "0";
            Game2.Text = "0";
            Game3.Text = "0";
            Final_Score.Text = "0";
            Average_Score.Text = "0";
            Handicap_Score.Text = "0";
            High_Game.Text = "0";
          
        }
    }
}

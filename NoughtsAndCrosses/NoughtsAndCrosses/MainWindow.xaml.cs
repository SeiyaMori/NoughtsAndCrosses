using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace NoughtsAndCrosses
{
    public enum Player
    {
        Unselected,
        Player1,
        Player2
    }
    
    public class Tile
    {
        public int position;
        public Player player;
        public Tile(int tilePosition)
        {
            position = tilePosition;
            player = Player.Unselected;
        }
    }


    public partial class MainWindow : Window
    {
        private bool humanTurn;
        private SolidColorBrush defaultColor = Brushes.White;
        private ObservableCollection<Tile> tiles = [];
        private Player currentPlayer;
        private List<List<int>> winningCombos =
            [
                [1,2,3],
                [4,5,6],
                [7,8,9],
                [1,4,7],
                [2,5,8],
                [3,6,9],
                [1,5,9],
                [3,5,7]
            ];

        public MainWindow()
        {
            InitializeComponent();
            humanTurn = true;
            SetBackgroundAllButtons(defaultColor);
            currentPlayer = Player.Player1;

            tiles.Add(new Tile(1));
            tiles.Add(new Tile(2));
            tiles.Add(new Tile(3));
            tiles.Add(new Tile(4));
            tiles.Add(new Tile(5));
            tiles.Add(new Tile(6));
            tiles.Add(new Tile(7));
            tiles.Add(new Tile(8));
            tiles.Add(new Tile(9));
        }

        private bool CheckWon()
        {
            IEnumerable<Tile> playerTiles = tiles.Where(t => t.player == currentPlayer);
            List<int> tileNumbers = [];
            foreach (Tile tile in playerTiles)
            {
                tileNumbers.Add(tile.position);
            }
            var tileNumbersSet = new HashSet<int>(tileNumbers);

            // Check player's selected tiles against the winning combinations
            foreach (List<int> combo in winningCombos)
            {
                if (tileNumbersSet.SetEquals(combo))
                {
                    return true;
                }
            }
            return false;
        }

        private void ChangePlayer()
        {
            if (currentPlayer == Player.Player1)
            {
                currentPlayer = Player.Player2;
            } else
            {
                currentPlayer = Player.Player1;
            }
        }

        private SolidColorBrush GetColor()
        {
            SolidColorBrush color;
            if (humanTurn)
            {
                color = Brushes.Yellow;
            }
            else
            {
                color = Brushes.Orange;
            }
            humanTurn = !humanTurn;
            return color;
        }

        private void SetBackgroundAllButtons(SolidColorBrush color)
        {
            One.Fill = color;
            Two.Fill = color;
            Three.Fill = color;
            Four.Fill = color;
            Five.Fill = color;
            Six.Fill = color;
            Seven.Fill = color;
            Eight.Fill = color;
            Nine.Fill = color;
        }

        private void UpdatedDisplayText()
        {
            tbDisplay.Text = "Player 1: " + tiles.Where(t => t.player == Player.Player1).Count() +
                " | Player 2: " + tiles.Where(t => t.player == Player.Player2).Count();
        }

        private void WinDisplayText()
        {
            if (currentPlayer == Player.Player1)
            {
                tbDisplay.Text = "Player 1 wins!";
            }
            else
            {
                tbDisplay.Text = "Player 2 wins!";
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Tile tileOne = tiles.Where(t => t.position.Equals(1)).First();
            if (tileOne.player == Player.Unselected)
            {
                One.Fill = GetColor();
                tileOne.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                } else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }

                
            }
            
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Tile tileTwo = tiles.Where(t => t.position.Equals(2)).First();
            if (tileTwo.player == Player.Unselected)
            {
                Two.Fill = GetColor();
                tileTwo.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                }
                else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Tile tileThree = tiles.Where(t => t.position.Equals(3)).First();
            if (tileThree.player == Player.Unselected)
            {
                Three.Fill = GetColor();
                tileThree.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                }
                else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Tile tileFour = tiles.Where(t => t.position.Equals(4)).First();
            if (tileFour.player == Player.Unselected)
            {
                Four.Fill = GetColor();
                tileFour.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                }
                else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Tile tileFive = tiles.Where(t => t.position.Equals(5)).First();
            if (tileFive.player == Player.Unselected)
            {
                Five.Fill = GetColor();
                tileFive.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                }
                else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Tile tileSix = tiles.Where(t => t.position.Equals(6)).First();
            if (tileSix.player == Player.Unselected)
            {
                Six.Fill = GetColor();
                tileSix.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                }
                else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Tile tileSeven = tiles.Where(t => t.position.Equals(7)).First();
            if (tileSeven.player == Player.Unselected)
            {
                Seven.Fill = GetColor();
                tileSeven.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                }
                else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Tile tileEight = tiles.Where(t => t.position.Equals(8)).First();
            if (tileEight.player == Player.Unselected)
            {
                Eight.Fill = GetColor();
                tileEight.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                }
                else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Tile tileNine = tiles.Where(t => t.position.Equals(9)).First();
            if (tileNine.player == Player.Unselected)
            {
                Nine.Fill = GetColor();
                tileNine.player = currentPlayer;
                if (CheckWon())
                {
                    WinDisplayText();
                }
                else
                {
                    ChangePlayer();
                    UpdatedDisplayText();
                }
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            SetBackgroundAllButtons(defaultColor);
            foreach (Tile t in tiles)
            {
                t.player = Player.Unselected;
            }
            UpdatedDisplayText();
            currentPlayer = Player.Player1;
            humanTurn = true;
        }
    }

}
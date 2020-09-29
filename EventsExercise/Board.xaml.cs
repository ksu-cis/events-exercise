using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventsExercise
{
    /// <summary>
    /// Interaction logic for Board.xaml
    /// </summary>
    public partial class Board : UserControl
    {
        /// <summary>
        /// Constructs a new game board
        /// </summary>
        public Board()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Helper method that finds the winner (if any)
        /// </summary>
        private Mark CheckForWin() {
            // Get the marks for all squares in the board
            int i = 0;
            Mark[] squares = new Mark[9];
            foreach (var child in ticTacToeGrid.Children)
            {
                var square = child as Square;
                squares[i] = square.Mark;
                i++;
            }

            for (i = 0; i < 3; i++)
            {
                // check verticals
                if (squares[3 * i] != Mark.None &&
                    squares[3 * i] == squares[3 * i + 1] && 
                    squares[3 * i + 1] == squares[3 * i + 2])
                {
                    return squares[i];
                }
                // check horizontals 
                if (squares[i] != Mark.None &&
                    squares[i] == squares[i + 3] && 
                    squares[i + 3] == squares[i + 6])
                {
                    return squares[i];
                }
            }

            // check diagonals 
            if (squares[0] != Mark.None && 
                squares[0] == squares[4] && 
                squares[4] == squares[8])
            {
                return squares[0];
            }
            // check diagonals 
            if (squares[2] != Mark.None &&
                squares[2] == squares[4] && 
                squares[4] == squares[6])
            {
                return squares[2];
            }

            // no winner yet 
            return Mark.None;
        }

        /// <summary>
        /// Resets the board to a new game state
        /// </summary>
        private void ResetBoard()
        {
            // iterate through all squares, clearing any marks
            foreach (var child in ticTacToeGrid.Children)
            {
                var square = child as Square;
                square.Mark = Mark.None;
            }            
        }
    }
}

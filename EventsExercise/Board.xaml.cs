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
        /// Get the winner (if any)
        /// </summary>
        public char Winner {
            get
            {
                // Get the marks for all squares in the board
                int i = 0;
                char[] squares = new char[9];
                foreach (var child in ticTacToeGrid.Children)
                {
                    var square = child as Square;
                    squares[i] = square.Mark;
                    i++;
                }

                for (i = 0; i < 3; i++)
                {
                    // check verticals
                    if (squares[3 * i] == squares[3 * i + 1] && squares[3 * i + 1] == squares[3 * i + 2])
                    {
                        if (squares[3 * i] != ' ') return squares[i];
                    }
                    // check horizontals 
                    if (squares[i] == squares[i + 3] && squares[i + 3] == squares[i + 6])
                    {
                        if (squares[i] != ' ') return squares[i];
                    }
                }

                // check diagonals 
                if (squares[0] == squares[4] && squares[4] == squares[8])
                {
                    if (squares[0] != ' ') return squares[0];
                }
                // check diagonals 
                if (squares[2] == squares[4] && squares[4] == squares[6])
                {
                    if (squares[2] != ' ') return squares[2];
                }
                // no winner yet 
                return ' ';
            }
        }

        /// <summary>
        /// Constructs a new game board
        /// </summary>
        public Board()
        {
            InitializeComponent();
        }
    }
}

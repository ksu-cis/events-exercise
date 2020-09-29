using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace EventsExercise
{
    /// <summary>
    /// The player's mark, or space for unclaimed squares
    /// </summary>
    public enum Mark
    {
        /// <summary>
        /// Neither player, or an empty square
        /// </summary>
        None = ' ',

        /// <summary>
        /// The 'X' player's mark
        /// </summary>
        X = 'X',

        /// <summary>
        /// The 'O' player's mark
        /// </summary>
        O = 'O'
    }
}

using System;
using System.Collection.Generic;
using System.Linq;

namespace Chess {
    public class ChessBoard {
        private int[] Board { get; set; } = new int[8];

        public bool IsSafe() {
            return true;
        }

        public static bool PlaceQueens(ChessBoard board = null, int column = 0) {
            return true;
        }

        public static bool PlaceQueens(List<ChessBoard> solutions, ChessBoard board = null, int column = 0) {
            return true;
        }

        #region Constructors

        #endregion

        public override string ToString() => new String(this.Board.Select(n => (char)(n + 48)).ToArray());

        
    }
}
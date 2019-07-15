using Chess;
using System.Linq;
using xunit;
using System.Collections.Generic;

namespace EightQueens {
    public class Tests_Chess {
        [Fact]
        public void Test_010_EmptyBoardIsSafe()
        {
        //Given
        //When
            var board = new ChesssBoard("00000000");
        
        //Then
            Assert.True(board.IsSafe());
        }

        [Fact]
        public void Test_011_BoardIsSafe()
        {
        //Given
        //When
            var board = new ChessBoard("10000000");
        
        //Then
            Assert.True(board.IsSafe());
        }

    }
}
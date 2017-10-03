using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using spil;

namespace Test
{
    [TestClass]
    public class TicTacToeTest
    {
        [TestMethod]
        public void NeitherPlayerHasThreeInARow()
        {
            TicTacToe ticTacToe = new TicTacToe();
            const string expectet ="";
            string actual = ticTacToe.Validate();
            Assert.AreEqual(expectet, actual); 
        }
    }
}

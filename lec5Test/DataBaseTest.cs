using System;
using System.Linq;
using AutoFixture;
using lec5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lec5Test
{
    [TestClass]
    public class DataBaseTest
    {
        [TestMethod]
        public void DataBaseAddTest()
        {
            //var game = new GameStub();
            var game = new Fixture().Create<Game>();
            var gameModel = new GameModel();
            var tableSize = gameModel.Games.Count();

            var testRow = gameModel.Games.Add(new lec5.Entities.GameEntity
            {
                Date = DateTime.Now,
                Winner = game.CurrentTurn.ToString()
            }
                );
            gameModel.SaveChanges();
           
            var newTableSize = gameModel.Games.Count();

            Assert.IsTrue(newTableSize > tableSize);
            gameModel.Games.Remove(testRow);
            gameModel.SaveChanges();
        }

    }
}

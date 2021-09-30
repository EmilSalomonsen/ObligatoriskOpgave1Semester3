using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskStudieAktivitetsOpgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskStudieAktivitetsOpgave.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void IdTest()
        {
            FootballPlayer footballplayer = new FootballPlayer();
            footballplayer.Id = 1;
            Assert.AreEqual(1, footballplayer.Id);
        }
        [TestMethod()]
        public void NameTest()
        {
            //Method works
            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.Name = "Emil";
            Assert.AreEqual("Emil", footballPlayer.Name);

            Assert.ThrowsException<ArgumentException>(
                () => footballPlayer.Name = "Bo");

            //Method doesn't work
            //FootballPlayer footballPlayer1 = new FootballPlayer();
            //footballPlayer1.Name = "Bo";
            //Assert.AreEqual("Bo", footballPlayer1.Name);
        }

        [TestMethod()]
        public void PriceTest()
        {
            // Method works
            FootballPlayer footballplayer = new FootballPlayer();
            footballplayer.Price = 1;
            Assert.AreEqual(1, footballplayer.Price);
            Assert.ThrowsException<ArgumentException>(
            () => footballplayer.Price = 0);

            //Method doesn't work
            //FootballPlayer footballplayer1 = new FootballPlayer();
            //footballplayer1.Price = 0;
            //Assert.AreEqual(0, footballplayer1.Price);
        }

        [TestMethod()]
        public void ShirtNumberTest()
        {
            //Method Works
            FootballPlayer footballplayer = new FootballPlayer();
            footballplayer.ShirtNumber = 10;
            Assert.AreEqual(10, footballplayer.ShirtNumber);
            Assert.ThrowsException<ArgumentException>(
            () => footballplayer.ShirtNumber= -10);

            //Method doesn't work
            //FootballPlayer footballplayer1 = new FootballPlayer();
            //footballplayer1.ShirtNumber = 101;
            //Assert.AreEqual(101, footballplayer1.ShirtNumber);

            //Method doesn't work
            //FootballPlayer footballplayer2 = new FootballPlayer();
            //footballplayer2.ShirtNumber = 0;
            //Assert.AreEqual(0, footballplayer2.ShirtNumber);


        }


    }
}

namespace ObligatoriskStudieAktivitetsOpgaveTests
{
    class FootballPlayerTests
    {
    }
}

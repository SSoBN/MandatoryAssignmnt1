using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignmnt1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MandatoryAssignmnt1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        FootballPlayer noName = new FootballPlayer(0, null,11,77);
        FootballPlayer tooShortName = new FootballPlayer(1, "A", 5, 5);
        FootballPlayer tooLowAge = new FootballPlayer(2, "Peter", 0,11);
        FootballPlayer tooLowShirtNumber = new FootballPlayer(3,"James",11,0);
        FootballPlayer tooHighShirtNumber = new FootballPlayer(4,"Frank", 12,1100);
        FootballPlayer testPlayer = new FootballPlayer(5,"John", 18, 69);

        [TestMethod()]
        public void FootballPlayerTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.Id = 1;
            footballPlayer.Name = "Jack";
            footballPlayer.Age = 13;
            footballPlayer.ShirtNumber = 20;
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            testPlayer.ValidateName();
            Assert.ThrowsException<ArgumentNullException>(() => noName.ValidateName());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => tooShortName.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            testPlayer.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => tooLowAge.ValidateAge());
        }

        [TestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(40)]
        [DataRow(98)]
        [DataRow(99)]
        public void ValidateShirtNumberTest(int shirtNumber)
        {
            testPlayer.ShirtNumber = shirtNumber;
            testPlayer.ValidateShirtNumber();
        }

        [TestMethod()]
        public void ValidateShirtNumberExceptionTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => tooLowShirtNumber.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => tooHighShirtNumber.ValidateShirtNumber());
        }
    }
}
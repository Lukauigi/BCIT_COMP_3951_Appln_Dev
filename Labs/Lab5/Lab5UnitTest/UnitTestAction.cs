using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5;

/// <summary>
/// Lab 5, Unit testing functionality relevant to project.
/// Authors: Lukasz Bednarek
/// Date: March 2022
/// </summary>
namespace Lab5UnitTest
{
    /// <summary>
    /// Test Class methods of Actions which implement IAction (Attack & Defend).
    /// </summary>
    [TestClass]
    public class UnitTestAction
    {
        [TestMethod]
        public void TestAttackDescription()
        {
            //Arrange
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            String expectedDescription = "Slash ==> Attack value: 9, Duration: 18, Level: 1";

            //Act
            String slashDescription = slash.Description();

            //Assert
            Assert.AreEqual(expectedDescription, slashDescription);
        }

        [TestMethod]
        public void TestDefendDescription()
        {
            //Arrange
            Defend protect = new Defend("protect", 20, 32, 5, 2);
            String expectedDescription = "Protect ==> Defense value: 20, Duration: 32, Level: 1";

            //Act
            String protectDescription = protect.Description();

            //Assert
            Assert.AreEqual(expectedDescription, protectDescription);
        }

        [TestMethod]
        public void TestAttackLevelUp()
        {
            //Arrange
            Attack slash = new Attack("slash", 9, 18, 3, 3);

            int expectedAttackValue = 12; //9+3
            int expectedDuration = 15; //18-3
            int expectedLevel = 2;

            //Act
            slash.LevelUp();

            //Assert
            Assert.AreEqual(expectedLevel, slash.Level);
            Assert.AreEqual(expectedAttackValue, slash.Damage);
            Assert.AreEqual(expectedDuration, slash.Duration);
        }

        [TestMethod]
        public void TestAttackLevelUpMulipleTimes()
        {
            //Arrange
            Attack slash = new Attack("slash", 9, 18, 3, 3);

            int expectedAttackValue = 15; //9+3+3
            int expectedDuration = 12; //18-3-3
            int expectedLevel = 3;

            //Act
            slash.LevelUp();
            slash.LevelUp();

            //Assert
            Assert.AreEqual(expectedLevel, slash.Level);
            Assert.AreEqual(expectedAttackValue, slash.Damage);
            Assert.AreEqual(expectedDuration, slash.Duration);
        }

        [TestMethod]
        public void TestAttackLevelUpMaxLevel()
        {
            //Arrange
            Attack slash = new Attack("slash", 9, 18, 3, 3);

            int expectedAttackValue = 15; //9+3+3
            int expectedDuration = 12; //18-3-3
            int expectedLevel = 3;

            //Act
            slash.LevelUp();
            slash.LevelUp();
            slash.LevelUp(); //Level is maxed before this call

            //Assert
            Assert.AreEqual(expectedLevel, slash.Level);
            Assert.AreEqual(expectedAttackValue, slash.Damage);
            Assert.AreEqual(expectedDuration, slash.Duration);
        }

        [TestMethod]
        public void TestDefendLevelUp()
        {
            //Arrange
            Defend protect = new Defend("protect", 20, 32, 5, 2);

            int expectedAttackValue = 25; //20+5
            int expectedDuration = 30; //32-2
            int expectedLevel = 2;

            //Act
            protect.LevelUp();

            //Assert
            Assert.AreEqual(expectedLevel, protect.Level);
            Assert.AreEqual(expectedAttackValue, protect.Defense);
            Assert.AreEqual(expectedDuration, protect.Duration);
        }

        [TestMethod]
        public void TestDefendLevelUpMulipleTimes()
        {
            //Arrange
            Defend protect = new Defend("protect", 20, 32, 5, 2);

            int expectedAttackValue = 30; //20+5+5
            int expectedDuration = 28; //32-2-2
            int expectedLevel = 3;

            //Act
            protect.LevelUp();
            protect.LevelUp();

            //Assert
            Assert.AreEqual(expectedLevel, protect.Level);
            Assert.AreEqual(expectedAttackValue, protect.Defense);
            Assert.AreEqual(expectedDuration, protect.Duration);
        }

        [TestMethod]
        public void TestDefendLevelUpMaxLevel()
        {
            //Arrange
            Defend protect = new Defend("protect", 20, 32, 5, 2);

            int expectedAttackValue = 30; //20+5+5
            int expectedDuration = 28; //32-2-2
            int expectedLevel = 3;

            //Act
            protect.LevelUp();
            protect.LevelUp();
            protect.LevelUp(); //Level is maxed before this call

            //Assert
            Assert.AreEqual(expectedLevel, protect.Level);
            Assert.AreEqual(expectedAttackValue, protect.Defense);
            Assert.AreEqual(expectedDuration, protect.Duration);
        }
    }
}

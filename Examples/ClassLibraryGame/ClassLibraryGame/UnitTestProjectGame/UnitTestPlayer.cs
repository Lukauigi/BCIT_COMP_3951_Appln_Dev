using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryGame;

namespace UnitTestProjectGame
{
    [TestClass]
    public class UnitTestPlayer
    {
        ClassPlayer somePlayer = new ClassPlayer("Tom");

        // Test Name method

        [TestMethod]
        public void TestMethodChangeName()
        {
            //Assert
            Assert.AreEqual("Tom", somePlayer.Name);
            somePlayer.ChangeName("Ann");
            Assert.AreEqual("Ann", somePlayer.Name);
        }


        [TestMethod]
        public void TestInvalidNameChangeToWhitespace()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("John", 100, 1, -10);
            String invalidName = "           ";

            //Act
            player.ChangeName(invalidName);

            //Assert
            Assert.AreNotEqual(invalidName, player.Name);
            Assert.AreEqual("John", player.Name);
        }

        // Test Damage method
        
        [TestMethod]
        public void DamageTest()
        {
            //Arrange
            ClassPlayer player_2 = new ClassPlayer("John", 200, 1, 200);

            //Act
            player_2.Damage(1);
            player_2.Damage(2);
            player_2.Damage(3); 
            player_2.Damage(4);

            //Assert
            Assert.AreEqual(100, player_2.Health);

        }

        [TestMethod]
        public void TestLevelDecrementFromDamage()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 3, 20);

            //Act
            player.Damage(2);

            //Assert
            Assert.AreEqual(2, player.Level);
            Assert.AreEqual(250, player.Health);
        }

        [TestMethod]
        public void TestLoseStateFromDamage()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 10);

            //Act
            player.Damage(1);

            //Assert
            Assert.AreEqual(GameState.Lose, player.WinningState);
        }

        // test achievement method

        [TestMethod]
        public void TestAchievementCaseOne()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 100);

            //Act
            player.Achievement(1);

            //Assert
            Assert.AreEqual(110, player.Health);
            Assert.AreEqual(1, player.Level);
        }

        [TestMethod]
        public void TestAchievementCaseTwo()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 100);

            //Act
            player.Achievement(2);

            //Assert
            Assert.AreEqual(120, player.Health);
            Assert.AreEqual(1, player.Level);
        }

        [TestMethod]
        public void TestAchievementCaseThree()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 100);

            //Act
            player.Achievement(3);

            //Assert
            Assert.AreEqual(130, player.Health);
            Assert.AreEqual(1, player.Level);
        }

        [TestMethod]
        public void TestAchievementCaseFour()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 100);

            //Act
            player.Achievement(4);

            //Assert
            Assert.AreEqual(140, player.Health);
            Assert.AreEqual(1, player.Level);
        }

        [TestMethod]
        public void TestAchievementMultipleCases()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 3, 100);

            //Act
            player.Achievement(2);
            player.Achievement(4);
            player.Achievement(1);

            //Assert
            Assert.AreEqual(170, player.Health);
            Assert.AreEqual(3, player.Level);
        }

        [TestMethod]
        public void TestWinWinningState()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 4, 210);

            //Act
            player.Achievement(4);

            //Assert
            Assert.AreEqual(GameState.Win, player.WinningState);
        }

        [TestMethod]
        public void TestLevelUpFromAchievement()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 210);

            //Act
            player.Achievement(4);

            //Assert
            Assert.AreEqual(2, player.Level);
        }

        [TestMethod]
        public void TestActivePlayerStateFromAchievementLevelUp()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 100);

            //Act
            player.Achievement(4);

            //Assert
            Assert.AreEqual(GameState.Active, player.WinningState);
        }

        // test PoisonDamage method

        [TestMethod]
        public void TestPoisonDamage()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 120);
            player.status = PlayerStatus.Poisoned;

            //Act
            player.PoisonDamage();

            //Assert
            Assert.AreEqual(100, player.Health);
        }

        [TestMethod]
        public void TestLoseStateWithPoisonDamage()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 20);
            player.status = PlayerStatus.Poisoned;

            //Act
            player.PoisonDamage();

            //Assert
            Assert.AreEqual(GameState.Lose, player.WinningState);
        }

        [TestMethod]
        public void TestLevelDecrementWithPoisonDamage()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 4, 20);
            player.status = PlayerStatus.Poisoned;

            //Act
            player.PoisonDamage();

            //Assert
            Assert.AreEqual(3, player.Level);
        }

        // test BurnDamage method

        [TestMethod]
        public void TestBurnDamage()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 130);
            player.status = PlayerStatus.Burned;

            //Act
            player.BurnDamage();

            //Assert
            Assert.AreEqual(100, player.Health);
        }

        [TestMethod]
        public void TestLostStateWithBurnDamage()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 1, 20);
            player.status = PlayerStatus.Burned;

            //Act
            player.BurnDamage();

            //Assert
            Assert.AreEqual(GameState.Lose, player.WinningState);
        }

        [TestMethod]
        public void TestLevelDecrementWithBurnDamage()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Martha", 250, 3, 10);
            player.status = PlayerStatus.Burned;

            //Act
            player.BurnDamage();

            //Assert
            Assert.AreEqual(2, player.Level);
        }

        // test attack method

        [TestMethod]
        public void TestNormalAttack()
        {
            //Arrange
            ClassPlayer player = new ClassPlayer("Roy");
            int damageValue;

            //Act
            damageValue = player.Attack();

            //Assert
            Assert.AreEqual(40, damageValue);
        }

        [TestMethod]
        public void TestAttackWhenConfused()
        {
            //Arrange
            ClassPlayer roy = new ClassPlayer("Roy");
            roy.status = PlayerStatus.Confused;
            int damageValue;

            //Act
            damageValue = roy.Attack();

            //Assert
            Assert.AreEqual(0, damageValue);
            Assert.AreEqual(PlayerStatus.Normal, roy.status);
            Assert.AreEqual(180, roy.Health);
        }

        [TestMethod]
        public void TestAttackWhenParalyzed()
        {
            //Arrange
            ClassPlayer roy = new ClassPlayer("Roy");
            roy.status = PlayerStatus.Paralyzed;
            int damageValue;

            //Act
            damageValue = roy.Attack();

            //Assert
            Assert.AreEqual(0, damageValue);
            Assert.AreEqual(PlayerStatus.Paralyzed, roy.status);
        }

        [TestMethod]
        public void TestAttackWhenBurned()
        {
            //Arrange
            ClassPlayer roy = new ClassPlayer("Roy");
            roy.status = PlayerStatus.Burned;
            int damageValue;

            //Act
            damageValue = roy.Attack();

            //Assert
            Assert.AreEqual(20, damageValue);
            Assert.AreEqual(PlayerStatus.Burned, roy.status);
        }
    }
}

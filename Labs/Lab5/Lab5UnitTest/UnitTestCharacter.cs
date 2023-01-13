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
    /// Test Character Class methods (Player & Enemy).
    /// </summary>
    [TestClass]
    public class UnitTestCharacter
    {

        [TestMethod]
        public void TestAddAttackToEmptyAttacksList()
        {
            //Arrange
            //arrange action(s)            
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            //arrange player
            Player player = new Player("Roy", 30, 4, 2, "sword");

            //Act
            player.AddAttackAction(bunt);

            //Assert
            Assert.IsTrue(player.Attacks.Contains(bunt));
            Assert.AreEqual(1, player.Attacks.Count);
        }

        [TestMethod]
        public void TestAddAttackToAttacksListWithAttacks()
        {
            //Arrange
            //arrange action(s)            
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack doubleEdge = new Attack("double edge", 20, 35, 5, 4);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);

            Attack swiftCut = new Attack("swift cut", 5, 10, 2, 2);

            List<Attack> attacks = new List<Attack>() { bunt, slash, doubleEdge, flamingSword };
            List<Defend> defends = new List<Defend>();

            //arrange player
            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");

            //Act
            player.AddAttackAction(swiftCut);

            //Assert
            Assert.IsTrue(player.Attacks.Contains(swiftCut));
            Assert.AreEqual(5, player.Attacks.Count);
        }

        [TestMethod]
        public void TestCannotAddDuplicateAttackToAttacksList()
        {
            //Arrange
            //arrange action(s)            
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack doubleEdge = new Attack("double edge", 20, 35, 5, 4);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);

            List<Attack> attacks = new List<Attack>() { bunt, slash, doubleEdge, flamingSword };
            List<Defend> defends = new List<Defend>();

            //arrange player
            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");

            //Act
            player.AddAttackAction(slash); //try to add slash again

            //Assert
            int count = 0;
            foreach (Attack attack in player.Attacks)
            {
                if (attack.Equals(slash)) //check instances for attack slash
                {
                    ++count;
                }
            }

            Assert.AreEqual(4, player.Attacks.Count);
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void TestAddDefendToEmptyDefendsList()
        {
            //Arrange
            //arrange action(s)            
            Defend brace = new Defend("brace", 4, 14, 2, 2);

            //arrange player
            Player player = new Player("Roy", 30, 4, 2, "sword");

            //Act
            player.AddDefendAction(brace);

            //Assert
            Assert.IsTrue(player.Defends.Contains(brace));
            Assert.AreEqual(1, player.Defends.Count);
        }

        [TestMethod]
        public void TestAddDefendToDefendsListWithDefends()
        {
            //Arrange
            //arrange action(s)            
            Defend brace = new Defend("brace", 5, 16, 3, 2);
            Defend protect = new Defend("protect", 20, 32, 5, 2);
            
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> attacks = new List<Attack>();
            List<Defend> defends = new List<Defend>() { brace, protect };

            //arrange player
            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");

            //Act
            player.AddDefendAction(quickGuard);

            //Assert
            Assert.IsTrue(player.Defends.Contains(quickGuard));
            Assert.AreEqual(3, player.Defends.Count);
        }

        [TestMethod]
        public void TestCannotAddDuplicateDefendToDefendsList()
        {
            //Arrange
            //arrange action(s)            
            Defend brace = new Defend("brace", 5, 16, 3, 2);
            Defend protect = new Defend("protect", 20, 32, 5, 2);

            List<Attack> attacks = new List<Attack>();
            List<Defend> defends = new List<Defend>() { brace, protect };

            //arrange player
            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");

            //Act
            player.AddDefendAction(protect); //try to add defend again

            //Assert
            int count = 0;
            foreach (Defend defendAction in player.Defends)
            {
                if (defendAction.Equals(protect)) //check instances for protect defend
                {
                    ++count;
                }
            }

            Assert.AreEqual(2, player.Defends.Count);
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void TestPlayerReceiveDamage()
        {
            //Arrange
            Player player = new Player("Roy", 30, 4, 2, "sword");
            int healthAfter = 22; // = 30 - (10 - 2)

            //Act
            player.ReceiveDamage(10);

            //Assert
            Assert.AreEqual(healthAfter, player.Health);
        }

        [TestMethod]
        public void TestPlayerReceiveNoDamage()
        {
            //Arrange
            Player player = new Player("Roy", 30, 4, 2, "sword");
            int healthAfter = 30; // 0 damage = 2 (_baseDefence) - 2 (atk)

            //Act
            player.ReceiveDamage(2); 

            //Assert
            Assert.AreEqual(healthAfter, player.Health);
        }

        [TestMethod]
        public void TestPlayerReceiveDamageGreaterThanHealth()
        {
            //Arrange
            Player player = new Player("Roy", 30, 4, 2, "sword");
            int healthAfter = 0;

            //Act
            player.ReceiveDamage(100);

            //Assert
            Assert.AreEqual(healthAfter, player.Health);
        }

        [TestMethod]
        public void TestPlayerReceiveDamageWithDefendAction()
        {
            //Arrange
            Defend brace = new Defend("brace", 5, 16, 3, 2);

            List<Attack> attacks = new List<Attack>();
            List<Defend> defends = new List<Defend>() { brace };

            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");
            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1);

            int healthAfter = 27; // = 30 - (10 - (5 + 2))

            //Act
            player.PerformAction(enemy, brace);
            player.ReceiveDamage(10);

            //Assert
            Assert.AreEqual(healthAfter, player.Health);
        }

        [TestMethod]
        public void TestPlayerReceiveNoDamageWithDefendAction()
        {
            //Arrange
            Defend brace = new Defend("brace", 5, 16, 3, 2);

            List<Attack> attacks = new List<Attack>();
            List<Defend> defends = new List<Defend>() { brace };

            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");
            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1);

            int healthAfter = 30; // 4atk - 2 defence + 5 guard = -3; tests if guard for negative value after calculating defenses on attack

            //Act
            player.PerformAction(enemy, brace);
            player.ReceiveDamage(4);

            //Assert
            Assert.AreEqual(healthAfter, player.Health);
        }

        [TestMethod]
        public void TestPlayerReceiveDamageGreaterThanHealthWithDefendAction()
        {
            //Arrange
            Defend brace = new Defend("brace", 5, 16, 3, 2);

            List<Attack> attacks = new List<Attack>();
            List<Defend> defends = new List<Defend>() { brace };

            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");
            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1);

            int healthAfter = 0; 

            //Act
            player.PerformAction(enemy, brace);
            player.ReceiveDamage(100);

            //Assert
            Assert.AreEqual(healthAfter, player.Health);
        }

        [TestMethod]
        public void TestPlayerPerformActionAttack()
        {
            //Arrange
            //arrange player action(s)            
            Attack slash = new Attack("slash", 9, 18, 3, 3);

            List<Attack> attacks = new List<Attack>() { slash };
            List<Defend> defends= new List<Defend>();

            //arrange characters
            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");
            Character enemy = new Enemy("Bokoblin", 15, 3, 1);

            int enemyExpectedHP = 3; // = 15 - (1 - (9 + 4))

            //Act
            player.PerformAction(enemy, slash);

            //Assert
            Assert.AreEqual(enemyExpectedHP, enemy.Health);
        }

        [TestMethod]
        public void TestPlayerPerformActionDefend()
        {
            //Arrange
            //arrange player action(s)            
            Defend brace = new Defend("brace", 5, 16, 3, 2);

            List<Attack> attacks = new List<Attack>();
            List<Defend> defends = new List<Defend>() { brace };

            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");
            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1);

            //Act
            player.PerformAction(enemy, brace);

            //Assert
            Assert.AreEqual(brace.Defense, player.Guard);
        }

        [TestMethod]
        public void TestPlayerPerformActionAttackNotInAttacksList()
        {
            //Arrange
            //arrange player action(s)            
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack doubleEdge = new Attack("double edge", 20, 35, 5, 4);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);

            List<Attack> attacks = new List<Attack>() { bunt, slash, doubleEdge, flamingSword };
            List<Defend> defends = new List<Defend>();

            Attack finalGambit = new Attack("final gambit", 45, 60, 15, 0); //not assigned to player's attacks

            //arrange characters
            Player player = new Player("Roy", 30, 4, 2, attacks, defends, "sword");
            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1);

            int enemyExpectedHP = enemy.Health; // 15 Health

            //Act
            player.PerformAction(enemy, finalGambit);

            //Assert
            Assert.AreEqual(enemyExpectedHP, enemy.Health);
        }

        [TestMethod]
        public void TestPlayerPerformActionDefendNotInDefendsList()
        {
            //Arrange
            //arrange player action(s)
            Defend brace = new Defend("brace", 5, 16, 3, 2);
            Defend protect = new Defend("protect", 20, 32, 5, 2);

            List<Attack> playerAttacks = new List<Attack>();
            List<Defend> playerDefends = new List<Defend>() { brace, protect };

            Defend ultimateShield = new Defend("ultimate shield", 45, 60, 15, 0); //defend action not in 

            //arrange characters
            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");
            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1);

            //Act
            int guardBeforeAction = player.Guard; // 0
            player.PerformAction(enemy, ultimateShield);

            //Assert
            Assert.AreEqual(guardBeforeAction, player.Guard);
        }
    }
}

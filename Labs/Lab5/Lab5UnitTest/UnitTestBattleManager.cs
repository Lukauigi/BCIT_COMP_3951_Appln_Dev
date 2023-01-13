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
    /// Test Battle Manager Class methods.
    /// </summary>
    [TestClass]
    public class UnitTestBattleManager
    {
        [TestMethod]
        public void TestPlayerAddActionToTimeline()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 5, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 1, 10, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);

            int startTime = 5;
            bool isPlayerAction = true;
            IAction sameAttack = flamingSword; //same action but as IAction to create ActionEvent
            ActionEvent actionEvent = new ActionEvent(ref sameAttack, startTime, isPlayerAction);

            //Act
            battleManager.AddActionToTimeline(startTime, flamingSword, isPlayerAction);

            //Assert
            Assert.IsTrue(battleManager.Timeline.Actions.Contains(actionEvent));
        }

        [TestMethod]
        public void TestEnemyAddActionToTimeline()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 5, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 1, 10, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);

            int startTime = 5;
            bool isPlayerAction = false;
            IAction sameAction = recklessPunch; //to pass in to create ActionEvent
            ActionEvent actionEvent = new ActionEvent(ref sameAction, startTime, isPlayerAction);

            //Act
            battleManager.AddActionToTimeline(startTime, recklessPunch, isPlayerAction);

            //Assert
            Assert.IsTrue(battleManager.Timeline.Actions.Contains(actionEvent));
        }

        [TestMethod]
        public void TestAddActionsOfPlayerAndEnemyToTimeline()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 5, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 1, 10, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);

            //action events for comparing
            IAction enemySameAction = recklessPunch; //to pass in to create ActionEvent
            ActionEvent enemyActionEvent = new ActionEvent(ref enemySameAction, 30, false);

            IAction playerSameAction = flamingSword; //to pass in to create ActionEvent
            ActionEvent playerActionEvent = new ActionEvent(ref playerSameAction, 0, true);

            //Act
            battleManager.AddActionToTimeline(0, flamingSword, true);
            battleManager.AddActionToTimeline(30, recklessPunch, false);

            //Assert
            Assert.AreEqual(playerActionEvent, battleManager.Timeline.Actions[0]);
            Assert.AreEqual(enemyActionEvent, battleManager.Timeline.Actions[1]);
        }

        [TestMethod]
        public void TestExecuteEmptyTurn()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 5, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 1, 10, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);

            //Act
            battleManager.ExecuteTurn();

            //Assert
            Assert.AreEqual(player, battleManager.Player);
            Assert.AreEqual(enemy, battleManager.Enemy);
        }

        [TestMethod]
        public void TestExecuteTurn()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 5, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 2, 5, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);
            battleManager.AddActionToTimeline(0, slash, true); //enemy.health = 2
            battleManager.AddActionToTimeline(19, quickGuard, true); //player.guard = 3
            battleManager.AddActionToTimeline(30, crossArm, false); //enemy.guard = 2
            battleManager.AddActionToTimeline(36, bunt, true); //enemy.health = 1
            battleManager.AddActionToTimeline(44, recklessPunch, false); //player.health = 27

            //Act
            battleManager.ExecuteTurn();

            //Assert
            Assert.AreEqual(27, battleManager.Player.Health);
            Assert.AreEqual(1, battleManager.Enemy.Health);
        }

        [TestMethod]
        public void TestExecuteTurnEnemyFaints()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 5, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 2, 5, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);
            battleManager.AddActionToTimeline(0, slash, true);
            battleManager.AddActionToTimeline(20, slash, true);
            battleManager.AddActionToTimeline(40, slash, true);

            //Act
            battleManager.ExecuteTurn();

            //Assert
            Assert.AreEqual(0, battleManager.Enemy.Health);
        }

        [TestMethod]
        public void TestExecuteTurnPlayerFaints()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 25, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 2, 5, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);
            battleManager.AddActionToTimeline(0, recklessPunch, false);
            battleManager.AddActionToTimeline(20, recklessPunch, false);
            battleManager.AddActionToTimeline(40, recklessPunch, false);

            //Act
            battleManager.ExecuteTurn();

            //Assert
            Assert.AreEqual(0, battleManager.Player.Health);
        }

        [TestMethod]
        public void TestCombatTimelineAfterExecuteTurn()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 5, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 2, 5, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);
            battleManager.AddActionToTimeline(0, slash, true); //enemy.health = 2
            battleManager.AddActionToTimeline(19, quickGuard, true); //player.guard = 3
            battleManager.AddActionToTimeline(30, crossArm, false); //enemy.guard = 2
            battleManager.AddActionToTimeline(36, bunt, true); //enemy.health = 1
            battleManager.AddActionToTimeline(44, recklessPunch, false); //player.health = 27

            //Act
            battleManager.ExecuteTurn();

            //Assert
            Assert.AreEqual(0, battleManager.Timeline.Actions.Count);
        }

        [TestMethod]
        public void TestCombatTimelineAfterExecuteTurnWhenCharacterFaints()
        {
            //Arrange

            //arrange player actions
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Attack flamingSword = new Attack("flaming sword", 13, 24, 4, 2);
            Defend quickGuard = new Defend("quick guard", 3, 10, 1, 4);

            List<Attack> playerAttacks = new List<Attack>() { bunt, slash, flamingSword };
            List<Defend> playerDefends = new List<Defend>() { quickGuard };

            Player player = new Player("Roy", 30, 4, 2, playerAttacks, playerDefends, "sword");

            //arrange enemy actions
            Attack recklessPunch = new Attack("reckless punch", 5, 15, 5, 2);
            Defend crossArm = new Defend("arm cross", 2, 5, 2, 1);

            List<Attack> enemyAttacks = new List<Attack>() { recklessPunch };
            List<Defend> enemyDefends = new List<Defend>() { crossArm };

            Enemy enemy = new Enemy("Bokoblin", 15, 3, 1, enemyAttacks, enemyDefends);

            //arrange manager
            BattleManager battleManager = new BattleManager(player, enemy);
            battleManager.AddActionToTimeline(0, slash, true);
            battleManager.AddActionToTimeline(20, slash, true);
            battleManager.AddActionToTimeline(40, slash, true);

            //Act
            battleManager.ExecuteTurn();

            //Assert
            Assert.AreEqual(0, battleManager.Timeline.Actions.Count);
        }
    }
}

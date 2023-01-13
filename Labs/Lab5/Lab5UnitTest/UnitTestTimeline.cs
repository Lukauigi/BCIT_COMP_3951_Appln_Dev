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
    /// Test Timeline Class methods.
    /// </summary>
    [TestClass]
    public class UnitTestTimeline
    {
        [TestMethod]
        public void TestAddActionToEmptyTimeline()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            int startTime = 0;
            bool isPlayerAction = false;
            Predicate<Attack> predicate = attack => attack.Equals(attack);

            //Act
            timeline.AddAction(startTime, bunt, isPlayerAction);

            //Assert
            Assert.AreEqual(startTime, timeline.Actions[0].StartTime);
            Assert.AreEqual(isPlayerAction, timeline.Actions[0].IsPlayerAction);
            Assert.AreEqual(bunt, timeline.Actions[0].Action);
        }

        [TestMethod]
        public void TestAddActionToPopulatedTimelineAtBeginning()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Defend brace = new Defend("brace", 5, 16, 3, 2);

            int startTime = 1;
            bool isPlayerAction = true;

            //add prior existing actions events in timeline
            timeline.AddAction(10, brace, true);
            timeline.AddAction(30, slash, false);
            timeline.AddAction(52, bunt, true);

            //Act
            timeline.AddAction(startTime, bunt, isPlayerAction);

            //Assert
            Assert.AreEqual(startTime, timeline.Actions[0].StartTime);
            Assert.AreEqual(isPlayerAction, timeline.Actions[0].IsPlayerAction);
            Assert.AreEqual(bunt, timeline.Actions[0].Action);
        }

        [TestMethod]
        public void TestAddActionToPopulatedTimelineAtEnd()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Defend brace = new Defend("brace", 5, 16, 3, 2);

            int startTime = 53;
            bool isPlayerAction = true;

            //add prior existing actions events in timeline
            timeline.AddAction(0, brace, true);
            timeline.AddAction(19, slash, false);
            timeline.AddAction(40, bunt, true);

            //Act
            timeline.AddAction(startTime, bunt, isPlayerAction);

            //Assert
            Assert.AreEqual(startTime, timeline.Actions[3].StartTime);
            Assert.AreEqual(isPlayerAction, timeline.Actions[3].IsPlayerAction);
            Assert.AreEqual(bunt, timeline.Actions[3].Action);
        }

        [TestMethod]
        public void TestAddActionToPopulatedTimelineInMiddle()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Defend brace = new Defend("brace", 5, 16, 3, 2);

            int startTime = 39;
            bool isPlayerAction = true;

            //add prior existing actions events in timeline
            timeline.AddAction(0, brace, true);
            timeline.AddAction(20, slash, false);
            timeline.AddAction(53, bunt, true);

            //Act
            timeline.AddAction(startTime, bunt, isPlayerAction);

            //Assert
            Assert.AreEqual(startTime, timeline.Actions[2].StartTime);
            Assert.AreEqual(isPlayerAction, timeline.Actions[2].IsPlayerAction);
            Assert.AreEqual(bunt, timeline.Actions[2].Action);
        }

        [TestMethod]
        public void TestAddActionWhichIntersectsWithEventInTimeline()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);
            Attack slash = new Attack("slash", 9, 18, 3, 3);
            Defend brace = new Defend("brace", 5, 16, 3, 2);

            IAction protect = new Defend("protect", 20, 32, 5, 2);
            ActionEvent protectEvent = new ActionEvent(ref protect, 40, false);

            //add prior existing actions events in timeline
            timeline.AddAction(0, brace, true);
            timeline.AddAction(20, slash, false);
            timeline.AddAction(33, bunt, true);
            timeline.AddAction(53, bunt, true);

            //Act
            timeline.AddAction(40, protect, false);

            //Assert
            Assert.IsFalse(timeline.Actions.Contains(protectEvent));
        }

        [TestMethod]
        public void TestAddActionWhichPartiallyIntersectsWithEventStartTime()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            IAction protect = new Defend("protect", 20, 32, 5, 2);
            ActionEvent protectEvent = new ActionEvent(ref protect, 40, false);

            //add prior existing actions events in timeline
            timeline.AddAction(33, bunt, true);

            //Act
            timeline.AddAction(1, protect, false);

            //Assert
            Assert.IsFalse(timeline.Actions.Contains(protectEvent));
        }

        [TestMethod]
        public void TestAddActionWhichPartiallyIntersectsWithEventEndTime()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            IAction protect = new Defend("protect", 20, 32, 5, 2);
            ActionEvent protectEvent = new ActionEvent(ref protect, 40, false);

            //add prior existing actions events in timeline
            timeline.AddAction(33, bunt, true);

            //Act
            timeline.AddAction(40, protect, false);

            //Assert
            Assert.IsFalse(timeline.Actions.Contains(protectEvent));
        }

        [TestMethod]
        public void TestAddActionWhichAlmostIntersectsWithEventStartTime()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            IAction protect = new Defend("protect", 20, 32, 5, 2);
            ActionEvent protectEvent = new ActionEvent(ref protect, 0, false);

            //add prior existing actions events in timeline
            timeline.AddAction(33, bunt, true);

            //Act
            timeline.AddAction(0, protect, false);

            //Assert
            Assert.IsTrue(timeline.Actions.Contains(protectEvent));
        }

        [TestMethod]
        public void TestAddActionWhichAlmostIntersectsWithEventEndTime()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            IAction brace = new Defend("brace", 5, 16, 3, 2);
            ActionEvent protectEvent = new ActionEvent(ref brace, 41, false);

            //add prior existing actions events in timeline
            timeline.AddAction(33, bunt, true);

            //Act
            timeline.AddAction(41, brace, false);

            //Assert
            Assert.IsTrue(timeline.Actions.Contains(protectEvent));
        }

        [TestMethod]
        public void TestAddActionWhichStartsBeforeTimeline()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            IAction brace = new Defend("brace", 5, 16, 3, 2);
            ActionEvent protectEvent = new ActionEvent(ref brace, -10, false);

            //add prior existing actions events in timeline
            timeline.AddAction(33, bunt, true);

            //Act
            timeline.AddAction(-10, brace, false);

            //Assert
            Assert.IsFalse(timeline.Actions.Contains(protectEvent));
        }

        [TestMethod]
        public void TestAddActionWhichStartsAfterTimeline()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            IAction brace = new Defend("brace", 5, 16, 3, 2);
            ActionEvent protectEvent = new ActionEvent(ref brace, 61, false);

            //add prior existing actions events in timeline
            timeline.AddAction(33, bunt, true);

            //Act
            timeline.AddAction(61, brace, false);

            //Assert
            Assert.IsFalse(timeline.Actions.Contains(protectEvent));
        }

        [TestMethod]
        public void TestAddActionWhichEndsAfterTimelineEnd()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            IAction brace = new Defend("brace", 5, 16, 3, 2);
            ActionEvent protectEvent = new ActionEvent(ref brace, 51, false);

            //add prior existing actions events in timeline
            timeline.AddAction(33, bunt, true);

            //Act
            timeline.AddAction(51, brace, false);

            //Assert
            Assert.IsFalse(timeline.Actions.Contains(protectEvent));
        }

        [TestMethod]
        public void TestAddActionWhichEndsBeforeTimelineStarts()
        {
            //Arrange
            Timeline timeline = new Timeline();
            Attack bunt = new Attack("bunt", 1, 7, 1, 1);

            IAction brace = new Defend("brace", 5, 16, 3, 2);
            ActionEvent protectEvent = new ActionEvent(ref brace, -30, false);

            //add prior existing actions events in timeline
            timeline.AddAction(33, bunt, true);

            //Act
            timeline.AddAction(-30, brace, false);

            //Assert
            Assert.IsFalse(timeline.Actions.Contains(protectEvent));
        }
    }
}

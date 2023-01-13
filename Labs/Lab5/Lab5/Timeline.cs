using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lab 5, implement functionality relevant to project.
/// Authors: Lukasz Bednarek
/// Date: March 2022
/// </summary>
namespace Lab5
{
    /// <summary>
    /// A range of time of a turn of combat.
    /// </summary>
    public class Timeline
    {

        public const int TIMELINE_DURATION_PER_TURN = 60;

        private List<ActionEvent> _actions; // all actions should have a start-time and an end-time which does not intersect with another action present

        public List<ActionEvent> Actions { get { return _actions; } }

        /// <summary>
        /// Constructs a timeline instance. 
        /// </summary>
        public Timeline()
        {
            _actions = new List<ActionEvent>();
        }

        /// <summary>
        /// Adds an action to the timeline of actions of a turn.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="action"></param>
        /// <param name="isPlayerAction"></param>
        public void AddAction(int startTime, IAction action, bool isPlayerAction)
        {
            int endTime = startTime + action.Duration;
            // if the time of action is within the timeline
            if (startTime >= 0 && endTime <= TIMELINE_DURATION_PER_TURN)
            {
                bool intersectOtherAction = false;
                int chronologicalCount = 0; // index for where to insert passed action in timeline

                // if the start-time of the passed action starts within another in list of actions, then cannot insert into timeline
                foreach (ActionEvent actionEvent in _actions)
                {
                    if (startTime >= actionEvent.StartTime && startTime <= actionEvent.EndTime)
                    {
                        intersectOtherAction = true;
                        break;
                    }

                    // if start-time of action happens after another action
                    if (startTime >= actionEvent.EndTime)
                        ++chronologicalCount;
                }

                // if action timeline does not intersect with any other action in whole timeline then insert into timeline
                if (intersectOtherAction is false)
                {
                    _actions.Insert(chronologicalCount, new ActionEvent(ref action, startTime, isPlayerAction));
                    _actions.Sort(delegate(ActionEvent firstEvent, ActionEvent secondEvent) //anonymous function to sort list by start-time
                    {
                        if (firstEvent.StartTime > secondEvent.StartTime) return 1; //firstEvent moves infront of secondEvent
                        else return -1; //firstEvent moves behind secondEvent
                    });
                }
            }
        }
    }

    /// <summary>
    /// Info of an action in a timeline.
    /// </summary>
    public readonly struct ActionEvent
    {
        /// <summary>
        /// Constructs an instance.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="startTime"></param>
        /// <param name="isPlayerAction"></param>
        public ActionEvent(ref IAction action, int startTime, bool isPlayerAction)
        {
            Action = action;
            //Name = action.Name;
            StartTime = startTime;
            Duration = action.Duration;
            EndTime = startTime + action.Duration;
            IsPlayerAction = isPlayerAction;
        }

        //public String Name { get; }
        public int StartTime { get; }
        public int Duration { get; }
        public int EndTime { get; }
        public bool IsPlayerAction { get; }
        public IAction Action { get; }
    }
}

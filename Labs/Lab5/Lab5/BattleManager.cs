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
    public class BattleManager
    {
        private Player _player;
        private Enemy _enemy;
        private Timeline _timeline;

        public Player Player { get { return _player; } }
        public Enemy Enemy { get { return _enemy; } }
        public Timeline Timeline { get { return _timeline; } }

        public BattleManager(Player player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
            _timeline = new Timeline();
        }

        public void AddActionToTimeline(int startTime, IAction action, bool isPlayerAction)
        {
            _timeline.AddAction(startTime, action, isPlayerAction);
        }

        public void ExecuteTurn()
        {
            int actions = _timeline.Actions.Count;

            while (actions != 0)
            {
                ActionEvent actionEvent = _timeline.Actions.First();
                if (actionEvent.IsPlayerAction)
                {
                    _player.PerformAction(_enemy, actionEvent.Action);
                }
                else
                {
                    _enemy.PerformAction(_player, actionEvent.Action);
                }

                if (_player.Health <= 0 || _enemy.Health <= 0)
                    break;

                _timeline.Actions.RemoveAt(0);
                --actions;
            }

            _timeline.Actions.Clear();
        }
    }
}

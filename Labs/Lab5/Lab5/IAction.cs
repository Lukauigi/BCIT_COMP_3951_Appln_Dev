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
    /// Actions must (Attacks & Defends) implement certain things.
    /// </summary>
    public interface IAction
    {

        String Name { get; }
        int Duration { get; }
        int Level { get; }
        int DurationBonus { get; }

        /// <summary>
        /// Returns the description of the action.
        /// </summary>
        /// <returns></returns>
        String Description();

        /// <summary>
        /// Increases the level of the action and stats of the action.
        /// </summary>
        void LevelUp();

    }

    /// <summary>
    /// An attack action.
    /// </summary>
    public class Attack : IAction
    {
        public const int MIN_DURATION = 1;
        public const int MAX_LEVEL = 3;
        public const int START_LEVEL = 1;

        private String _name;
        private int _damage;
        private int _duration;
        private int _level;
        private int _damageBonus; // value which damage increases by in level up
        private int _durationBonus; // value which duration decreases by in level up (decrease is good!, less time for an attack)

        public String Name { get { return _name; } }
        public int Damage { get { return _damage; } }
        public int Duration { get { return _duration; } }
        public int Level { get { return _level; } }
        public int DamageBonus { get { return _damageBonus; } }
        public int DurationBonus { get { return _durationBonus; } }

        /// <summary>
        /// Constructs an attack.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="damageValue"></param>
        /// <param name="duration"></param>
        /// <param name="damageLevelUpBonus"></param>
        /// <param name="durationLevelUpBonus"></param>
        public Attack(String name, int damageValue, int duration, int damageLevelUpBonus, int durationLevelUpBonus)
        {
            _name = char.ToUpper(name[0]) + name.Substring(1).ToLower(); // capitalize name
            _damage = damageValue;
            _duration = duration;
            _level = START_LEVEL;
            _damageBonus = damageLevelUpBonus;
            _durationBonus = durationLevelUpBonus;
        }

        /// <summary>
        /// Increases the level of the attack, which then increases damage output and decreases its duration to perform.
        /// </summary>
        public void LevelUp()
        {
            if (_level < MAX_LEVEL)
            {
                _level++;
                _damage += _damageBonus;
                _duration -= _durationBonus;

                if (_duration < MIN_DURATION) //duration of action cannot be under 1
                    _duration = MIN_DURATION; //assign minimum
            }
            else
                Console.WriteLine("Cannot level up max level action.");
        }

        /// <summary>
        /// Returns a description of the attack.
        /// </summary>
        /// <returns> String description of this attack </returns>
        public String Description()
        {
            return $"{_name} ==> Attack value: {_damage}, Duration: {_duration}, Level: {_level}";
        }

    }

    /// <summary>
    /// A Defend Action.
    /// </summary>
    public class Defend : IAction
    {
        public const int MIN_DURATION = 1;
        public const int MAX_LEVEL = 3;
        public const int START_LEVEL = 1;

        private String _name;
        private int _defense;
        private int _duration;
        private int _level;
        private int _defenseBonus; // value which defense increases by in level up
        private int _durationBonus; // value which duration decreases by in level up (decrease is good!, less time for a defend action!)

        public String Name { get { return _name; } }
        public int Defense { get { return _defense; } }
        public int Duration { get { return _duration; } }
        public int Level { get { return _level; } }
        public int DamageBonus { get { return DamageBonus; } }
        public int DurationBonus { get { return DurationBonus; } }

        /// <summary>
        /// Constructs a defend action.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defenseValue"></param>
        /// <param name="duration"></param>
        /// <param name="damageLevelUpBonus"></param>
        /// <param name="durationLevelUpBonus"></param>
        public Defend(String name, int defenseValue, int duration, int damageLevelUpBonus, int durationLevelUpBonus)
        {
            _name = char.ToUpper(name[0]) + name.Substring(1).ToLower(); // capitalize name
            _defense = defenseValue;
            _duration = duration;
            _level = START_LEVEL;
            _defenseBonus = damageLevelUpBonus;
            _durationBonus = durationLevelUpBonus;
        }

        /// <summary>
        /// Increases the level of the attack, which then increases defensive potential and decreases its duration to perform.
        /// </summary>
        public void LevelUp()
        {
            if (_level < MAX_LEVEL)
            {
                _level++;
                _defense += _defenseBonus;
                _duration -= _durationBonus;

                if (_duration < MIN_DURATION) //duration of action cannot be under 1
                    _duration = MIN_DURATION; //assign minimum
            }
            else
                Console.WriteLine("Cannot level up max level action.");
        }

        /// <summary>
        /// Returns a description of the defend action.
        /// </summary>
        /// <returns> String description of this attack </returns>
        public String Description()
        {
            return $"{_name} ==> Defense value: {_defense}, Duration: {_duration}, Level: {_level}";
        }
    }
}

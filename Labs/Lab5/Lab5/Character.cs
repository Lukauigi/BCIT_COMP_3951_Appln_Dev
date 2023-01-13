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
    public abstract class Character
    {

        protected String _name;
        protected int _health;
        protected int _baseDamage;
        protected int _baseDefense;
        protected int _guard;
        protected List<Attack> _attacks;
        protected List<Defend> _defends; // defensive actions

        public String Name { get { return _name; } set { _name = value; } }
        public int Health { get { return _health; } }
        public int BaseDamage { get { return _baseDamage; } }
        public int BaseDefense { get { return _baseDefense; } }
        public int Guard { get { return _guard; } }
        public List<Attack> Attacks { get { return _attacks; } }
        public List<Defend> Defends { get { return _defends; } }

        /// <summary>
        /// Constructs a character.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        /// <param name="defense"></param>
        /// <param name="attacks"></param>
        /// <param name="defends"></param>
        protected Character(String name, int health, int damage, int defense, List<Attack> attacks, List<Defend> defends)
        {
            _name = char.ToUpper(name[0]) + name.Substring(1).ToLower(); // capitalize name
            _health = health;
            _baseDamage = damage;
            _baseDefense = defense;
            _guard = 0;
            _attacks = attacks;
            _defends = defends;
        }

        /// <summary>
        /// Constructs a character.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        /// <param name="defense"></param>
        protected Character(String name, int health, int damage, int defense)
        {
            _name = char.ToUpper(name[0]) + name.Substring(1).ToLower(); // capitalize name
            _health = health;
            _baseDamage = damage;
            _baseDefense = defense;
            _guard = 0;
            _attacks = new List<Attack>();
            _defends = new List<Defend>();
        }

        /// <summary>
        /// Performs a given action on an opponent depending if action is known by character.
        /// </summary>
        /// <param name="opponent"></param>
        /// <param name="actionMove"></param>
        public virtual void PerformAction(Character opponent, IAction actionMove)
        {
            if (_attacks.Contains(actionMove))
            {
                Attack attack = (Attack)actionMove;
                int damage = _baseDamage + attack.Damage; //total damage from player _baseDamage & attack's damage
                opponent.ReceiveDamage(damage);
            }
            else if (_defends.Contains(actionMove))
            {
                Defend defend = (Defend)actionMove;
                _guard += defend.Defense; // _guard subtracts incoming damage before damage deducts health when attacked
            }
        }

        /// <summary>
        /// Applies damage to self.
        /// </summary>
        /// <param name="incomingDamage"></param>
        public virtual void ReceiveDamage(int incomingDamage)
        {
            if (_baseDefense + _guard <= incomingDamage)
                _health -= incomingDamage - (_baseDefense + _guard);
                
                if (_health < 0)
                    _health = 0;
            else
                Console.WriteLine($"{_name} took no damage.");
        }
    }

    /// <summary>
    /// The main character (the user).
    /// </summary>
    public class Player : Character
    {

        private String _weapon;

        public String Weapon { get; }

        /// <summary>
        /// Constructs a Player.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        /// <param name="defense"></param>
        /// <param name="attacks"></param>
        /// <param name="defends"></param>
        /// <param name="weapon"></param>
        public Player(String name, int health, int damage, int defense, List<Attack> attacks, List<Defend> defends, String weapon) : base(name, health, damage, defense, attacks, defends)
        {
            weapon.TrimStart().TrimEnd();
            _weapon = char.ToUpper(weapon[0]) + weapon.Substring(1).ToLower(); // capitalize name;
        }

        /// <summary>
        /// Constructs a Player.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        /// <param name="defense"></param>
        /// <param name="attacks"></param>
        /// <param name="defends"></param>
        /// <param name="weapon"></param>
        public Player(String name, int health, int damage, int defense, String weapon) : base(name, health, damage, defense)
        {
            _weapon = weapon;
        }

        /// <summary>
        /// Adds an attack action to the player's attacks
        /// </summary>
        /// <param name="newAttack"></param>
        public void AddAttackAction(Attack newAttack)
        {
            if (!_attacks.Contains(newAttack))
                _attacks.Add(newAttack);
        }

        /// <summary>
        /// Adds a defensive action to the player's defends
        /// </summary>
        /// <param name="newDefend"></param>
        public void AddDefendAction(Defend newDefend)
        {
            if (!_defends.Contains(newDefend))
                _defends.Add(newDefend);
        }
    }

    /// <summary>
    /// An opposing character to the player.
    /// </summary>
    public class Enemy : Character
    {
        /// <summary>
        /// Constructs an Enemy.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        /// <param name="defense"></param>
        /// <param name="attacks"></param>
        /// <param name="defends"></param>
        public Enemy(String name, int health, int damage, int defense, List<Attack> attacks, List<Defend> defends) : base(name, health, damage, defense, attacks, defends)
        {

        }

        /// <summary>
        /// Constructs an Enemy.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        /// <param name="defense"></param>
        public Enemy(String name, int health, int damage, int defense) : base(name, health, damage, defense)
        {

        }
    }
}

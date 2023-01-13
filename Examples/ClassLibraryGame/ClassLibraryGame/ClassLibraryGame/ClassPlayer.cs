using System;

namespace ClassLibraryGame
{

    public enum GameState
    {
        Active,
        Win,
        Lose
    }

    public enum PlayerStatus
    {
        Normal,
        Poisoned,
        Burned,
        Paralyzed, 
        Confused
    }

    /// <summary>
    /// Player class
    /// </summary>
    public class ClassPlayer
    {
        private const int MAX_HEALTH = 200;
        private const int MAX_LEVEL = 5;
        private const int DEFAULT_LEVEL = 1;
        private const int MAX_HIT_POINTS = 300;
        private const int DAMAGE_OUTPUT = 40;

        public String Name { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public GameState WinningState { get; set; } // makes more sense as an enum
        /* added properties */
        public PlayerStatus status { get; set; }

        private void Intialize()
        {
            MaximumHitPoints = MAX_HIT_POINTS;
            Level = DEFAULT_LEVEL;
            Health = MAX_HEALTH;
            WinningState = GameState.Active;
            status = PlayerStatus.Normal;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="preferredName"></param>
        public ClassPlayer(String preferredName)
        {
            Name = preferredName;
            Intialize();
        }
               
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="preferredName"></param>
        /// <param name="maxHitPoints"></param>
        /// <param name="level"></param>
        /// <param name="health"></param>
         public ClassPlayer(String preferredName, int maxHitPoints, int level, int health)
        {
            Name = preferredName;
            MaximumHitPoints = maxHitPoints;
            Level = level;
            Health = health;
            WinningState = GameState.Active;
            status = PlayerStatus.Normal;
        }

        /// <summary>
        /// Assigns a new name to the player.
        /// </summary>
        /// <param name="newName">a string</param>
        public void ChangeName(String newName)
        {
            if (newName.TrimStart().TrimEnd().Length > 0)
            {
                Name = newName;
            } 
            else
            {
                Console.WriteLine("Enter a valid name.");
            }
            
            
        }

        /// <summary>
        /// Damages the player given the action.
        /// </summary>
        /// <param name="action">an int</param>
        public void Damage(int action)
        {
            switch (action)
            {
                case 1:
                    Health -= 10;
                    break;
                case 2:
                    Health -= 20;
                    break;
                case 3:
                    Health -= 30;
                    break;
                case 4:
                    Health -= 40;
                    break;
            }

            if (Health <= 0)
            {
                if (Level > 1)
                {
                    Level--;
                    Health = MaximumHitPoints;
                } 
                else
                {
                    WinningState = GameState.Lose;
                }

            }
        }

        /// <summary>
        /// Increases player's health (and potentially level/ win the game) given an action.
        /// </summary>
        /// <param name="action">an int</param>
        public void Achievement(int action)
        {
            switch (action)
            {
                case 1:
                    Health += 10;
                    break;
                case 2:
                    Health += 20;
                    break;
                case 3:
                    Health += 30;
                    break;
                case 4:
                    Health += 40;
                    break;
            }

            if (Health >= MAX_HEALTH)
            {
                ++Level;
                if (Level == MAX_LEVEL)
                    WinningState = GameState.Win; 

            }
        }

        /* Added functionality */ 

        /// <summary>
        /// Damages the player if they are poisoned.
        /// </summary>
        public void PoisonDamage()
        {
            if (this.status == PlayerStatus.Poisoned)
            {
                Damage(2);
            }
        }

        /// <summary>
        /// Damages the player if they are burned.
        /// </summary>
        public void BurnDamage()
        {
            if (this.status == PlayerStatus.Burned)
            {
                Damage(3);
            }
        }

        /// <summary>
        /// Returns the attack damage output of the player.
        /// </summary>
        /// <returns></returns>
        public int Attack()
        {
            int attack = 0;

            switch (status)
            {

                case PlayerStatus.Confused:
                    Damage(2);
                    status = PlayerStatus.Normal; // player snaps out of confusion after hitting themself
                    Console.WriteLine("The player hit themself in confusion and snapped out if it.");
                    break;

                case PlayerStatus.Paralyzed:
                    Console.WriteLine("The player is immobolized by paralysis.");
                    break;

                case PlayerStatus.Burned:
                    attack = DAMAGE_OUTPUT / 2;
                    Console.WriteLine("The player attacks but their attack is weakened.");
                    break;

                default:
                    attack = DAMAGE_OUTPUT;
                    Console.WriteLine("The player attacks.");
                    break;
            }

            return attack;
        }


    }

}

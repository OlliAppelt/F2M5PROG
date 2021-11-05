using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Enemy
    {
        public int Health = 100;
        public int currentHealth;
        public bool attackPlayer;
        public bool enemyAttacked;

        void takeDamage()
        {
            if (enemyAttacked == true)
            {
                Health =- 10;
            }
        }
    }
}

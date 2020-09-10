using System;
using System.Collections.Generic;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Football matchBall = new Football();
            matchBall.x = 30;
            matchBall.y = 45;
            matchBall.z = 0; 
            matchBall.speed = 15; 

            List<Player> greenTeam = new List<Player>();

            greenTeam.Add(new Player());


            List<Player> blackTeam = new List<Player>();

            blackTeam.Add(new Player());
        }

        public class Football
        {
            public int x;
            public int y;
            public int z;
            public int speed;
             
        }

        public class Player 
        {
           public int x;
           public int y;
           public int z; 

           public string team;
           public string name; 
        }
    }
}

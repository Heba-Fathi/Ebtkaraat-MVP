using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ebtkarat.Tournament
{
    public enum Position
    {
        Forward, Guard, Center,
        GoalKeeper, FieldKeeper
    }
    class Program
    {

      
        static void Main(string[] args)
        {

            List <Player> players= new List<Player>();
            Player p1 = new Player(new BasketBall(10, 5, 1));
            p1.Name = "heba";
            p1.NickName = "heba";
            p1.Number = 1;
            p1.Position = Position.Forward;
            double sc1= p1.Score;
            p1.TotalScore += sc1;

            Player p2 = new Player(new BasketBall(5, 10, 5));
            p2.Name = "fathi";
            p2.NickName = "fathi";
            p2.Number = 2;
            p2.Position = Position.Center;
            double sc2= p2.Score;
            p2.TotalScore += sc2;


            TeamA t1 = new TeamA();
            t1.AddPlayer(p1);
            t1.AddPlayer(p2);

            double teamAScore= t1.GetScore();

            Player p3 = new Player(new BasketBall(10, 25, 10));
            p3.Name = "john";
            p3.NickName = "john";
            p3.Number = 1;
            p3.Position = Position.Forward;
            double sc3 = p3.Score;
            p3.TotalScore += sc3;




            Player p4 = new Player(new BasketBall(10, 25, 10));
            p4.Name = "sam";
            p4.NickName = "sam";
            p4.Number = 2;
            p4.Position = Position.Center;
            double sc4 = p4.Score;
            p4.TotalScore += sc4;


            TeamA t2 = new TeamA();
            t2.AddPlayer(p3);
            t2.AddPlayer(p4);

            var winner = Program.Match(t1, t2);

            players.Add(p1);
            players.Add(p2);
            players.Add(p3);
            players.Add(p4);
            Console.WriteLine($"MVP IS {Program.MVP(players)}");
            Console.ReadLine();


        }

        static string MVP(List<Player> players)
        {
            
           
             var maxscore=  players.Max(p=>p.TotalScore);

            var player = players.FirstOrDefault(p => p.TotalScore == maxscore);
            return player.Name;

        }

       static public Team Match(Team a, Team b)
        {
            if (a.GetScore() > b.GetScore())
            {
                a.IsWinner = true;
                  return a;

            }
            else
            {
                b.IsWinner = true;
                return b;

            }

            
        }
    }
}

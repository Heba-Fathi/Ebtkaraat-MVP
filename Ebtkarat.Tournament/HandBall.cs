using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebtkarat.Tournament
{

    public class HandBall : Sport
    {
        double _points;
        double _goalMade;
        double _goalReceieved;

        public HandBall(double goalMade, double goalReceieved)
        {

            _goalMade = goalMade;
            _goalReceieved = goalReceieved;

        }
       // public enum Position { GoalKeeper, FieldKeeper };

        public string GetName()
        {
            return "HandBall";
        }

        public double Calculate(Position pos)
        {
            double score;
            switch (pos)
            {

                case Position.GoalKeeper:
                    _points = 50;
                    score = _points + _goalMade * 5 - _goalReceieved * 2;
                    break;
                case Position.FieldKeeper:
                    _points = 20;
                    score = _points + _goalMade - _goalReceieved;
                    break;


                default:
                    score = 0;
                    break;
            }
            return score;

        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebtkarat.Tournament
{

    public class BasketBall : Sport
    {
        double _points;
        double _rebounds;
        double _assists;
       // public enum Position { Forward, Guard, Center };


        public BasketBall(double points, double rebounds, double assists)
        {
            _points = points;
            _rebounds = rebounds;
            _assists = assists;

        }
        public string GetName()
        {
            return "BasketBall";
        }
       
        public double Calculate(Position pos)
        {
            double score;

            switch (pos)
            {

                case Position.Forward:
                    score = _points * 2 + _rebounds * 2 + _assists * 2;
                    break;
                case Position.Guard:
                    score = _points * 2 + _rebounds * 3 + _assists * 1;
                    break;

                case Position.Center:
                    score = _points * 2 + _rebounds * 1 + _assists * 3;
                    break;

                default:
                    score = 0;
                    break;
            }
            return score;

        }



    }

}

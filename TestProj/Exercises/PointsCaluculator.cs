using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj.Exercises
{
    public class PointsCaluculator
    {
        private const int SpeedLimit = 65;
        public int CalculateDemeritPoints(int Speed)
        {
            if(Speed <0)
                throw new ArgumentOutOfRangeException();

            if (Speed <= SpeedLimit) return 0;

            const int KmPerDemertiPoint = 5;
            var derPoints = (Speed -SpeedLimit) / KmPerDemertiPoint;
            return derPoints;
        }
    }
}

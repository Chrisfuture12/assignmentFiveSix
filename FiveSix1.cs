using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFiveSix
{
    class FiveSix1
    {
        public double calcWin(double w, double b)
        {   
            w += b;
            return w;
        }
        public double calcLose(double w, double b){
            w -= b;
            return w;
        }
    }
}
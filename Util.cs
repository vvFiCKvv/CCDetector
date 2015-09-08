using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCDetector
{
    public static class Util
    {
        public static double[] subTable(double[] data , int min,int size)
        {
            if (size > data.Count())
            {
                size = data.Count();
            }
            double[] res = new double[size];
            for (int i = min; i < size; i++)
            {
                res[i - min] = data[i];
            }
            return res;
        }
 

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovNS.Sprint3.TaskReview.V12.Lib
{
    public class DataService : ISprint3Task7V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((3 * x + 0.5) == 0)
                {
                    vallueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) + (2.0 / (3 * x + 0.5)) - 2.0 * Math.Cos(x) * 2.0 * x), 2);
                    vallueArray[count] = y;
                    count++;
                }
            }
            return vallueArray;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AramaAG.Sprint4.Task0.V7.Lib
{
    public class DataService : ISprint4Task0V7
    {
        public int GetMultOddArrEl(int[] array)
        {
            int mult = 1;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    mult *= array[i];
                }
            }
            return mult;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_CA
{
    public class Point
    {
        public int X { get; set;}
        public int Y { get; set;}

        //Конструктор
        public Point(int x = 0,int y = 0)
        {
            X = x;
            Y = y;
        }
    }
}

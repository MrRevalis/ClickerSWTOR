﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker.Methods
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Position(Position x)
        {
            this.X = x.X;
            this.Y = x.Y;
        }
        public override string ToString()
        {
            return $"x=> {X}, y=> {Y}";
        }
    }
}

﻿using System;

namespace FallingRocks
{
    class Rock
    {
        public int _rockX;
        public int _rockY;
        public char _rock;
        public ConsoleColor _color;

        public Rock(int rockX, int rockY, char rock, ConsoleColor color)
        {
            this._rockX = rockX;
            this._rockY = rockY;
            this._rock = rock;
            this._color = color;
        }
    }
}

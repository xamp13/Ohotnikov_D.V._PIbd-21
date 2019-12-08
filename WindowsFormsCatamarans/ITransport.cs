﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveBoat(Direction direction);

        void DrawCatamaran(Graphics g);

        void SetMainColor(Color color);
    }
}
﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    public class CarCat : Vecatamaran
    {

        protected const int catamaranWidth = 90;
        protected const int catamaranHeight = 50;

        public CarCat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public CarCat(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveBoat(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - catamaranWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - catamaranHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawCatamaran(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush mainBrush = new SolidBrush(MainColor);
            Brush brGray = new SolidBrush(Color.Gray);

            g.FillRectangle(mainBrush, _startPosX, _startPosY, 90, 10);
            g.FillRectangle(mainBrush, _startPosX, _startPosY + 35, 90, 10);
            g.FillRectangle(brGray, _startPosX, _startPosY + 5, 90, 35);
            g.FillRectangle(mainBrush, _startPosX + 35, _startPosY, 10, 45);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
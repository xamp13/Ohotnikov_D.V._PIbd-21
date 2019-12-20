using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    public class CatamaranGrade : CarCat, IComparable<CatamaranGrade>, IEquatable<CatamaranGrade>
    {

        public Color DopColor { private set; get; }

        public bool Sail { private set; get; }

        public bool Motor { private set; get; }

        public CatamaranGrade(int maxSpeed, float weight, Color mainColor, Color dopColor, bool sail, bool motor) :
            base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Sail = sail;
            Motor = motor;

            Random rnd = new Random();
        }

        public CatamaranGrade(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Sail = Convert.ToBoolean(strs[4]);
                Motor = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawCatamaran(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            base.DrawCatamaran(g);

            if (Sail)
            {
                g.FillRectangle(dopBrush, _startPosX + 20, _startPosY + 17, 65, 5);
                g.FillRectangle(dopBrush, _startPosX + 20, _startPosY + 22, 65, 5);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 10, 3, 7);
                g.FillRectangle(dopBrush, _startPosX + 60, _startPosY + 10, 3, 7);
                g.FillRectangle(dopBrush, _startPosX + 60, _startPosY + 27, 3, 8);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 27, 3, 8);
            }

            if (Motor)
            {
                g.FillRectangle(dopBrush, _startPosX, _startPosY - 5, 90, 5);
                g.FillRectangle(dopBrush, _startPosX, _startPosY + 43, 90, 7);
                g.FillRectangle(dopBrush, _startPosX + 15, _startPosY - 5, 3, 45);
                g.FillRectangle(dopBrush, _startPosX - 5, _startPosY + 15, 20, 15);

            }

            Brush brBlue = new SolidBrush(MainColor);
            g.FillRectangle(brBlue, _startPosX, _startPosY, 90, 10);
            g.FillRectangle(brBlue, _startPosX, _startPosY + 35, 90, 10);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY, 10, 35);

        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Sail + ";" + Motor;
        }

        public int CompareTo(CatamaranGrade other)
        {
            var res = (this is CarCat).CompareTo(other is CarCat);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Sail != other.Sail)
            {
                return Sail.CompareTo(other.Sail);
            }
            if (Motor != other.Motor)
            {
                return Motor.CompareTo(other.Motor);
            }

            return 0;
        }

        public bool Equals(CatamaranGrade other)
        {
            var res = (this as CarCat).Equals(other as CarCat);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Sail != other.Sail)
            {
                return false;
            }
            if (Motor != other.Motor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null) { return false; }

            if (!(obj is CatamaranGrade boatObj))
            {
                return false;
            }
            else
            {
                return Equals(boatObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
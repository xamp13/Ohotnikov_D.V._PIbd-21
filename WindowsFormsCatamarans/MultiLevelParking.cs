﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsCatamarans
{
    class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;

        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(File.OpenWrite(filename)))
            {
                fs.WriteLine($"CountLevels:{parkingStages.Count}");
                foreach (var level in parkingStages)
                {
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var cat = level[i];
                        if (cat != null)
                        {
                            if (cat.GetType().Name == "CarCat")
                            {
                                fs.WriteLine($"{i}:CarCat:" + cat);
                            }
                            if (cat.GetType().Name == "CatamaranGrade")
                            {
                                fs.WriteLine($"{i}:CatamaranGrade:" + cat);
                            }
                        }
                    }
                }
            }
            return true;
        }
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string buff = "";
            using (StreamReader fs = new StreamReader(File.OpenRead(filename)))
            {
                buff = fs.ReadLine();
                if (buff.Split(':')[0] == "CountLevels")
                {
                    int countLevel = Convert.ToInt32(buff.Split(':')[1]);
                    if (parkingStages != null)
                        parkingStages.Clear();
                    parkingStages = new List<Parking<ITransport>>(countLevel);
                }
                else
                    return false;
                int count = -1;
                while (!fs.EndOfStream)
                {
                    buff = fs.ReadLine();
                    ITransport cat = null;
                    if (buff == "Level")
                    {
                        count++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (buff.Split(':')[1] == "CarCat")
                    {
                        cat = new CarCat(buff.Split(':')[2]);
                        parkingStages[count][Convert.ToInt32(buff.Split(':')[0])] = cat;
                    }
                    if (buff.Split(':')[1] == "CatamaranGrade")
                    {
                        cat = new CatamaranGrade(buff.Split(':')[2]);
                        parkingStages[count][Convert.ToInt32(buff.Split(':')[0])] = cat;
                    }
                }
            }
            return true;
        }

        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
    }
}

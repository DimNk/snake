﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;
        public HorizontalLine(int xLeft,int xRight,int y,char sym)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {               
                Point p = new Point(x, y, char.Parse(x.ToString()));
                //Thread.Sleep(1000);
                pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}

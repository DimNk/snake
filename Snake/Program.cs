﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {        
        static void Main(string[] args)
        {            
            HorizontalLine line = new HorizontalLine(0,9,5,'#');
            line.Draw();

            Console.ReadKey();
        }
    }
}

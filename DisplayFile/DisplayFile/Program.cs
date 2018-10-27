﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFile {
    class Program {
        static void Main(string[] args) {
            if (args.Length < 1)
                return;
            string[] lines = File.ReadAllLines(args[0]);
            foreach (string item in lines) {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

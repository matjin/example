// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Examples
{
    
    public class Program
    {
        // Instantiate a StreamWriter instance.
        StreamWriter SWGlobal = new StreamWriter("everwhat.txt");
        

        public void NullDerefOK1()
        {
            int x = 4;
            while(x == 4)
            {
                Console.WriteLine("NEEL IS THE BOSS!!");
            }
            object c = null;
            c.GetHashCode();

        }

        public void NullDerefOK2()
        {
            var x = new object();
            if (x == null)
            {
                object c = null;
                c.GetHashCode();
            }
        }

        public void NullDerefBad1()
        {
            Program x = null;
            var y = x?.SWGlobal;
            y.GetHashCode();
        }


        public void NullDerefBad2()
        {
            ImReturningNull().GetHashCode();
            object ImReturningNull() => null;
        }
    }

    public class MainClass {
        public static void Main(string[] args)
        {
        }
    }
}

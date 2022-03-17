﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200089
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Nama anda : ");
            String n = Console.ReadLine();
            
            HaloGeneric.SapaUser<String>(n);

            Console.Write("NIM anda : ");
            String nim = Console.ReadLine();

            DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);
            dataGeneric.PrintData();


        }
    }


    class HaloGeneric
    {
        public static void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }

    class DataGeneric<T>
        {
            private T data;
            public DataGeneric(T Data)
            {
                this.data = Data;
            }

            public void PrintData()
            {
                Console.WriteLine("NIM yang diinput adalah " + data);

            }
        }
}


using System;
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

        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }
}
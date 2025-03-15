using System;

namespace CobaHaloGeneric
{
    public class HaloGeneric
    {
        public static void SapaUser<R>(R nama)
        {
            Console.WriteLine("Selamat pagi, " + nama + "!");
        }
    }
}
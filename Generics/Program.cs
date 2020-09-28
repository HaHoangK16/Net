using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> myGeneric = new Generic<int>();
            myGeneric.SoSanh<int>(2,2);
            myGeneric.SoSanh<string>("nam","nam");
        }
    }
}

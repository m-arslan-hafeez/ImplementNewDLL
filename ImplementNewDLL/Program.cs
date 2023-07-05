using System;
using System.Runtime.InteropServices;
namespace ImplementNewDLL
{
    class Program
    {
        [DllImport("attemptDll.dll")]
        public static extern IntPtr Create(int x);
        [DllImport("attemptDll.dll")]
        public static extern int AttemptAdd(IntPtr a, int y);
        static void Main(string[] args)
        {
            IntPtr a = Create(5);
            Console.WriteLine(AttemptAdd(a, 10));
            Console.WriteLine("Hello World!");
        }
    }
}

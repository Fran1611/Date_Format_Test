using System;
using Library;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            string TodayDate = "0011223344";
            DateFormat Format = new DateFormat();
            Console.WriteLine(Format.Format(TodayDate));
        }
    }
}

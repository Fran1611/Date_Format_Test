using System;
using Library;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            string TodayDate = "19/04/2020";
            DateFormat Format = new DateFormat();
            Console.WriteLine(Format.Format(TodayDate));
        }
    }
}

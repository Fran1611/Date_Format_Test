using System;

namespace Library
{
    public class DateFormat
    {


        public string Result {get;set;}

        /*  Método para dar formato a una fecha
            Formato fecha parámetro DD/MM/AAAA
            Formato fecha retornada AAAA-MM-DD
        */
        public string Format(string date)
        {
            string dateToFormat = date;
            string result = $"{dateToFormat.Substring(6,4)}-{dateToFormat.Substring(3,2)}-{dateToFormat.Substring(0,2)}";
            return $"la fecha {dateToFormat} ahora es {result}";
        }

    }
}

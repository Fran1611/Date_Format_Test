using System;

namespace Library
{
    public class DateFormat
    {


        public string Result {get;set;}

        // Metodo que formatea fecha DD/MM/AAAA a AAAA-MM-DD.
        public string Format(string date)
        {
            string dateToFormat = date;
            string result = $"{dateToFormat.Substring(6,4)}-{dateToFormat.Substring(3,2)}-{dateToFormat.Substring(0,2)}";
            return $"la fecha {dateToFormat} ahora es {result}";
        }

        // Metodo que formatea fecha DD/MM/AAAA a DD-MM-AAAA.
        public string OtherFormat(string date)
        {   
            string messageError = "Error, Fecha invalida";
            string dateToFormat = date;
            
            if (dateToFormat == "" || (dateToFormat[2].ToString() != "/" && dateToFormat[5].ToString() != "/"))
            {
                return messageError;
            }

            else
            {
                string result = $"{dateToFormat.Substring(0,2)}-{dateToFormat.Substring(3,2)}-{dateToFormat.Substring(6,4)}";
                return $"la fecha {dateToFormat} ahora es {result}";
            }
        }
    }
}

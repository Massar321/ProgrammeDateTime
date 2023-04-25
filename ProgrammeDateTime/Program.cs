using System;
using System.Globalization;

namespace ProgrammeDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            //Console.WriteLine(date.Month);

            CultureInfo cultureFrancais = CultureInfo.GetCultureInfo("fr-FR");

            Console.WriteLine(date.ToString("dddd dd MMMM yyyy HH:mm:ss", cultureFrancais));

            DateTime dateDemain = date.AddDays(1);

            Console.WriteLine("Demain : " + dateDemain.ToString("dddd dd MMMM yyyy HH:mm:ss", cultureFrancais));

            var diff = dateDemain - date;
            Console.WriteLine("Différence heures : " + diff.TotalHours);
        }
    }
}

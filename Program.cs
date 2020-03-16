using System;

namespace TesteGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            var testcase = "joao silva";

            var firstName = "";
            var lastName = "";
            lastName = lastName.ToUpper();
            var split = testcase.Split(new char[] { ' ' }, 2);
            if (split.Length == 1)
            {
                firstName = "";
                lastName = split[0];
            }
            else
            {
                firstName = split[0];
                lastName = split[1];
            }
            System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            Console.WriteLine(lastName.ToUpper() + ',' + cultureinfo.TextInfo.ToTitleCase(firstName));
        }
    }
}

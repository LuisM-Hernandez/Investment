using System;

namespace Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            double percent = 0.08;

            Console.WriteLine("How much would you like to invest");
            double invInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many years for that investment");
            int yearInput = Convert.ToInt32(Console.ReadLine());

            if (yearInput>=1 && yearInput<=30)
            {

            double gain = invInput;
            for(int yearly=1; yearly<=yearInput; yearly++)
            {
                gain+=gain*percent;
                 Console.WriteLine("Year "+ yearly + " investment = $ " + (Math.Round(gain, 2)));
            }

            }
        }
    }
}

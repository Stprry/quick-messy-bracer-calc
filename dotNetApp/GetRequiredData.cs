using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dotNetApp
{
   public class GetRequiredData
    {
        public static void Communicate()
        {
            Console.WriteLine("Enter Price of Shrouded Cloth used");
            var cloth = Console.ReadLine();
            Console.WriteLine("Enter the Price of Lightless Silk");
            var silk = Console.ReadLine();

            if (Regex.IsMatch(cloth, @"-?\d+(?:\.\d+)?") == true && Regex.IsMatch(silk, @"-?\d+(?:\.\d+)?") == true)
            {
                // continue code
                double shroudedCloth = Convert.ToDouble(cloth);
                shroudedCloth = shroudedCloth * 10;
                double lightlessSilk = Convert.ToDouble(silk);
                lightlessSilk = lightlessSilk * 2;
                const double penumbraThread = 7.90;

                double total = shroudedCloth + lightlessSilk + (penumbraThread * 3);
                double sacredShard = 149.50 * 1.5;
                double soulDust = 14.84 * 2.5;
                double profitTotalPreAh = sacredShard + soulDust;
                profitTotalPreAh = profitTotalPreAh - total;
                double ahCut = ((double)profitTotalPreAh / 100) * 5;
                double final = profitTotalPreAh - ahCut;





                Console.WriteLine($"Total cost is {total} , estimated profit is {final}");
                Console.ReadKey();
              
            }
            else
            {
                // re call Communicate or exit 
                Console.WriteLine("please only enter numbers, if you wish to continue push Y if not push N");
                string choice = Console.ReadLine();
                choice.ToLower();
                if (choice == "y")
                {
                    Communicate();
                }
                else
                    Environment.Exit(0);
            }
        }
    }
}




	/*--------------------------------------------------------------
*      HTBLA-Leonding / Class 3ACIFT
*--------------------------------------------------------------
*      Mathias Anderl
*--------------------------------------------------------------
* Description:
* The user enters amount in Euro, the program calculates 
* exchange rates in US dollars and Swiss francs using the 
* current daily exchange rate from the Internet.
*
* EUR - USD = 1:1,0514 
* EUR - CHF = 1:0,9549
* --> Date: 14.10.2023 (11:00 a.m.) 
*--------------------------------------------------------------
*/



using System;

// to use '€' in Terminal

namespace Waehrungsrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double input, outputUSD, outputCHF;
            string formattedOutputUSD, formattedOutputCHF;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Output (Header)
            Console.WriteLine("Waehrungsrechner");
            Console.WriteLine("~~~~~~~~~~~~~~~~ \n");
            Console.WriteLine("Waehrungsrechner von Euro in Dollar (USD)\nund Schweizer Franken: \n");


            // Input in €
            Console.Write("Eingabe des Betrags in Euro: ");

            input = Convert.ToDouble(Console.ReadLine());


            // Data processing (Verarbeitung)
            outputUSD = Convert.ToDouble(input) * 1.0514;
            outputCHF = Convert.ToDouble(input) * 0.9549;

            formattedOutputUSD = outputUSD.ToString("0.00");
            formattedOutputCHF = outputCHF.ToString("0.00");


            // Output (Output USD and CHF)
            Console.WriteLine($"Dollar (USD): {formattedOutputUSD}");
            Console.WriteLine($"Franken (CHF): {formattedOutputCHF} \n");
           

            Console.WriteLine("Zum Beenden bitte eine beliebige EIngabetaste drücken...");
        }
    }
}
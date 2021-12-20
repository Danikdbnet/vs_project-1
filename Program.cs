//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Pupa-i-Lupa-i-Pupa">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Test
{
    using System;

    /// <summary>
    /// Fulfills all requirements for a triangle project
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Determines whether a triangle exists
        /// </summary>
        public static bool Existing(double ab, double ac, double bc)
        {
            bool isExist = false;
            if (ab + ac >= bc && ac + bc >= ab && bc + ab >= ac)
            {
                IsExist = true;
            }

            return isExist;
        }

        /// <summary>
        /// Determines whether the triangle is rectangular
        /// </summary>
        public static bool Rectangular(double ab, double ac, double bc)
        {
            bool isRectangular = false;

            // Vypočítá délku nejdelší strany
            double hypotinuse = Math.Max(ab, Math.Max(ac, bc));

            // Výpočet plochy trojúhelníku
            double square;
            double s = (ab + ac + bc) / 2;
            square = Math.Sqrt(s * (s - ab) * (s - ac) * (s - bc));
            square = Math.Round(square, 2);

            // Určuje pravoúhlý trojúhelník nebo ne
            double katet1 = 0;
            double katet2 = 0;
            if (ab != hypotinuse)
            {
                katet1 = ab;
            }

            if (ac != hypotinuse)
            {
                if (katet1 == 0)
                {
                    katet1 = ac;
                }
                else
                {
                    katet2 = ac;
                }
            }

            if (bc != hypotinuse)
            {
                katet2 = bc;
            }

            if ((katet1 * katet2) / 2 == square)
            {
                isRectangular = true;
            }
            else
            {
                isRectangular = false;                


            return isRectangular;
        }

        /// <summary>
        /// Uses the above methods. Requires the user to specify the coordinates of the points. Outputs the response.
        /// </summary>
        public static void Main()
        {
            // Testing Marks
            double number;

            // Program žádá uživatele o zadání souřadnic bodu a testuje jestli jich napsal spravne
            double x1 = 0, x2 = 0, x3 = 0, y1 = 0, y2 = 0, y3 = 0;

            Console.Write($"Enter x for point of triangle A: ");
            string temp1 = Console.ReadLine();
            bool isParsable = double.TryParse(temp1, out number);
            if (isParsable)
            {
                x1 = double.Parse(temp1);
            }
            else
            {
                Console.WriteLine("Please enter the correct number");
                Main();
            }

            Console.Write($"Enter y for point of triangle A: ");
            string temp2 = Console.ReadLine();
            isParsable = double.TryParse(temp2, out number);
            if (isParsable)
            {
                y1 = double.Parse(temp2);
            }
            else
            {
                Console.WriteLine("Please enter the correct number");
                Main();
            }

            Console.Write($"Enter x for point of triangle B: ");
            string temp3 = Console.ReadLine();
            isParsable = double.TryParse(temp3, out number);
            if (isParsable)
            {
                x2 = double.Parse(temp3);
            }
            else
            {
                Console.WriteLine("Please enter the correct number");
                Main();
            }

            Console.Write($"Enter y for point of triangle B: ");
            string temp4 = Console.ReadLine();
            isParsable = double.TryParse(temp4, out number);
            if (isParsable)
            {
                y2 = double.Parse(temp4);
            }
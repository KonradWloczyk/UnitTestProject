using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LeapYear
    {

        [TestMethod]
        public void Leap_Year_Test_2018()
        {
            string result = IsLeapYear(2018);
            StringAssert.Equals(result, "No");
        }

        [TestMethod]
        public void Leap_Year_Test_2020()
        {
            string result = IsLeapYear(2020);
            StringAssert.Equals(result, "Yes");
        }
        public string IsLeapYear(int givenYear)
        {

            int nYear, nFhun, nHun, nFour, nEven;
            string sFhun, sHun, sFour;
            nYear = givenYear;

            nFhun = nYear % 400;
            if (nFhun == 0)
            {
                sFhun = "Divisible by 400: Yes";
            }
            else
            {
                sFhun = "Divisible by 400: No";
            }
            nHun = nYear % 100;
            if (nHun == 0)
            {
                sHun = "Divisible by 100: Yes";
            }
            else
            {
                sHun = "Divisible by 100: No";
            }
            nFour = nYear % 4;
            if (nFour == 0)
            {
                sFour = "Divisible by 100: Yes";
            }
            else
            {
                sFour = "Divisible by 100: No";
            }

            nEven = nYear % 2;
            Console.WriteLine("Year: " + nYear);
            Console.WriteLine(sFour);
            Console.WriteLine(sHun);
            Console.WriteLine(sFhun);

            if ((nEven == 0) && (nFour == 0) && (nHun == 0) && (nFhun == 0))
            {
                Console.WriteLine("Leap Year: Yes");
                return "Yes";
            }
            else if ((nEven == 0) && (nFour == 0) && (nHun != 0) && (nFhun != 0))
            {
                Console.WriteLine("Leap Year: Yes");
                return "Yes";
            }

            else if ((nEven == 0) && (nFour == 0) && (nHun == 0) && (nFhun != 0))
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }

            else if ((nEven == 0) && (nFour == 0) && (nHun != 0) && (nFhun == 0))
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }
            return "No";
        }
    }
}

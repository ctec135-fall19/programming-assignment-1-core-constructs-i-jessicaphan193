/*
Author: <your name>
Date:   <date>
CTEC 135: Microsoft Software Development with C#

<Solution Name>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations
            double myDouble = 0.0;
            double myDoubleDouble = new double();
            System.Double myDoubleDouble = 0;
            #endregion

            #region variable initialization
            bool BoolOne = true;
            byte ByteOne = 1000;
            short ShortOne = 5_974;
            int IntOne = 78_351_877;
            long LongOne = 664_185_635_415;
            char CharOne = '5';
            float FloatOne = 96.95;
            double DoubleOne = 0.0;
            decimal DecimalOne = 22.7m;
            string StringOne = "chicken";
            Object ObjectOne = "143";


            Console.WriteLine("This is bool: {0}", BoolOne);
            Console.WriteLine("This is byte: {0:c}", ByteOne);
            Console.WriteLine("This is short: {0:E}", ShortOne);
            Console.WriteLine("This is int: {0:x}", IntOne);
            Console.WriteLine("This is long: {0:e}", LongOne);
            Console.WriteLine("This is char: {0}", CharOne);
            Console.WriteLine("This is float: {0:f3}", FloatOne);
            Console.WriteLine("This is double: {0:c}", DoubleOne);
            Console.WriteLine("This is decimal: {0:n}", DecimalOne);
            Console.WriteLine("This is string: {0}", StringOne);









            #endregion

            #region Max/Min values
            Console.WriteLine("The minimum value of Double is: {0}", Double.MinValue);
            Console.WriteLine("The maximum value of Double is: {0}", Double.MaxValue);
            #endregion
        }
    }
}

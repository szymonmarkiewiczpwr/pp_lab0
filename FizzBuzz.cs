using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_lab0
{
    /// <summary>
    /// This class is used as a logic wrapper for FizzBuzz program
    /// </summary>
    public class FizzBuzz
    {
        private readonly int _fizzBuzzLength;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="fizzBuzzLength">This number sets how long will the printing go for</param>
        public FizzBuzz(int fizzBuzzLength)
        {
            _fizzBuzzLength = fizzBuzzLength;
        }

        /// <summary>
        /// Prints out the fizz buzz program to standard output
        /// </summary>
        /// <returns>Instance of this class</returns>
        public FizzBuzz PrintFizzBuzz()
        {
            for (int i = 0; i < _fizzBuzzLength; i++)
            {
                string line = "";

                if (i % 3 == 0)
                {
                    line += "Fizz";
                }

                if (i % 5 == 0)
                {
                    line += "Buzz";
                }

                if (string.IsNullOrEmpty(line))
                {
                    line = i.ToString();
                }

                Console.WriteLine(line);
            }

            return this;
        }
    }
}

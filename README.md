# pp_lab0

### Co zostało wykonane

- Został stworzony projekt .NET
- Zaimplementowany został program "FizzBuzz"
- Repozytorium zostało wrzucone na platformę GitHub

### Program

```C#

namespace pp_lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int fizzBuzzLength = 100;
            
            for (int i = 0; i < fizzBuzzLength; i++)
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
        }
    }
}


```
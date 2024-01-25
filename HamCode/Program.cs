using System;

namespace HamCode
{
    class Program
    {
        public static string line = "000010001011";
        static void Main(string[] args)
        {
            findError();
            Console.WriteLine("Hello World!");
        }
        static void findError() {
            int res = 0;
            for (int i = 0; Math.Pow(2, i) < line.Length; i++) {
                int ind = (int)Math.Pow(2, i) - 1, sum = 0;
                
                while (ind < line.Length)
                {
                    for (int k = ind; k < ind + (int)Math.Pow(2, i) && k < line.Length; k++) {
                        if(line[k] == '1')
                        {
                            sum++;
                        }
                    }
                    ind += 2 * (int)Math.Pow(2, i);
                }
                if(sum % 2 == 1)
                {
                    res += (int)Math.Pow(2, i);
                }
            }

            Console.WriteLine("Ошибка в " + res + " бите");
        }
    }
}

//using System;
//using System.CodeDom.Compiler;
//using System.Collections.Specialized;
//using System.Net.WebSockets;
//using System.Runtime.CompilerServices;

//namespace Ex0208Petle
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Zadanie 1");

//            for (int prime = 0; prime < 100; prime++)
//            {
//                int n = 2;

//                while (n <= prime && n > 1)
//                {
//                    if ((prime % n != 0) && (prime - 1 == n) || (prime == 2))
//                    {
//                        Console.WriteLine($"{prime} jest liczbą pierwszą");
//                        n++;
//                    }
//                    else if (prime % n == 0)
//                    {
//                        n = prime + 1;
//                    }
//                    else
//                    {
//                        n++;
//                    }
//                }
//            }

//            Console.WriteLine("");
//            Console.WriteLine("Zadanie 2");

//            int a = 0;

//            do
//            {
//                decimal result = a % 2;
//                switch (result)
//                {
//                    case 0:
//                        Console.WriteLine($"Liczba{a} jest parzysta");
//                        break;
//                }
//                a++;
//            }
//            while (a < 1001);

//            Console.WriteLine("");
//            Console.WriteLine("Zadanie 3");

//            int b = 0;
//            int c = 1;

//            for (int f = 0; f < 20; f++) //liczba iteracji
//            {
//                int d = b + c;
//                Console.WriteLine(b);
//                b = c;
//                c = d;
//            }

//            Console.WriteLine("");
//            Console.WriteLine("Zadanie 4");
//            Console.WriteLine("Podaj liczbę całkowitą, dodatnią:");

//            string pyramide = Console.ReadLine();
//            int l = 0;
//            Int32.TryParse(pyramide, out l);

//            int k = 1;

//            for (int i = 1; k <= l; i++)
//            {
//                string s = "";

//                for (int j = 1; (j <= i) & (k <= l); j++)
//                {
//                    s += k.ToString();
//                    k++;
//                }
//                Console.WriteLine(s);

//            }

//            Console.WriteLine("");
//            Console.WriteLine("Zadanie 5");


//            for (int cube = 1; cube <= 20; cube++)
//            {
//                Console.WriteLine($"{cube * cube * cube}");

//            }

//            Console.WriteLine("");
//            Console.WriteLine("Zadanie 6");

//            decimal fractionSum = 0;

//            for (decimal fraction = 1; fraction <= 20; fraction++)//swiadomie zaczynam od 1, a nie od 0 jak w poleceniu 
//            {
//                fractionSum = fractionSum + 1 / fraction;
//            }
//            Console.WriteLine($"{fractionSum}");

//            Console.WriteLine("");
Console.WriteLine("Zadanie 7");
Console.WriteLine("Podaj liczbę, będzie to krótsza przekątna diamentu:");

string diamond = Console.ReadLine();

int p = 9;

int.TryParse(diamond, out p);

int t = 0;

string empty = " ";
string asterisk = "*";
if (p%2==1)
{ 
for (int r = 1; r <= (p - t); r++)
{
    string verse = "";

    for (int u = 1; u <= ((p - (2 * t + 1)) / 2); u++)
    {
        verse += empty;
    }
    for (int w = 1; w <= (2 * t + 1); w++)
    {
        verse += asterisk;
    }

    Console.WriteLine(verse);
    t++;

}

t = 1;

for (int r = 1; r <= (p - t - 1); r++)
{
    string verse = "";

    for (int u = 1; u <= t; u++)
    {
        verse += empty;
    }
    for (int w = 1; w <= (p - 2 * t); w++)
    {
        verse += asterisk;
    }

    Console.WriteLine(verse);
    t++;
}
}
else
{
    for (int r = 1; r <= (p); r++)
    {
        string verse = "";

        for (int u = 1; u <= (p -t-1); u++)
        {
            verse += empty;
        }
        for (int w = 1; w <= (t + 1); w++)
        {
            verse += asterisk;
            verse+= empty;
        }

        Console.WriteLine(verse);
        t++;

    }

    t = 1;

    for (int r = 1; r <= (p - 1); r++)
    {
        string verse = "";

        for (int u = 1; u <= t; u++)
        {
            verse += empty;
        }
        for (int w = 1; w <= (p - t); w++)
        {
            verse += asterisk;
            verse += empty;
        }

        Console.WriteLine(verse);
        t++;
    }
}

//            Console.WriteLine("");
//            Console.WriteLine("Zadanie 8");
//            Console.WriteLine("Wpisz dowolny tekst:");

//            string wordOne = Console.ReadLine();

//            string wordEno = "";

//            for (int z = wordOne.Length - 1; z >= 0; z--)
//            {
//                wordEno += wordOne[z];
//            }
//            Console.WriteLine(wordEno);

//            Console.WriteLine("");
//            Console.WriteLine("Zadanie 9");
//            Console.WriteLine("Podaj liczbe, zamienimy ją z systemu dziesietnego na binarny:");

//            string decimalChoice = Console.ReadLine();

//            int decimalNumber = 0;

//            Int32.TryParse(decimalChoice, out decimalNumber);

//            string binaryNumber = "";

//            for (int iterations = 1; decimalNumber > 0; iterations++)
//            {
//                if (decimalNumber % 2 == 0)
//                {
//                    binaryNumber += "0";
//                }
//                else
//                {
//                    binaryNumber += "1";
//                }

//                decimalNumber /= 2;
//            }

//            string realBinary = "";

//            for (int realIteration = binaryNumber.Length - 1; realIteration >= 0; realIteration--)
//            {
//                realBinary += binaryNumber[realIteration];
//            }
//            Console.WriteLine(realBinary);

//            Console.WriteLine("");
//            Console.WriteLine("Zadanie 10");
//            Console.WriteLine("Szukamy najmniejszej wspólnej wielokrotnosci dwoch liczb.");
//            Console.WriteLine("Podaj pierwsza liczbe:");
//            string exOneChoice = Console.ReadLine();

//            Console.WriteLine("Podaj druga liczbe:");
//            string exTwoChoice = Console.ReadLine();

//            int exOne = 0;
//            int exTwo = 0;

//            Int32.TryParse(exOneChoice, out exOne);
//            Int32.TryParse(exTwoChoice, out exTwo);

//            int multiply = exOne * exTwo;

//            if (exOne > 0 & exTwo > 0)
//            {

//                while (exOne != exTwo)
//                {
//                    if (exOne > exTwo)
//                    {
//                        exOne -= exTwo;
//                    }
//                    else if (exOne < exTwo)
//                    {
//                        exTwo -= exOne;
//                    }

//                }

//                int lowestMultiple = multiply / exOne;
//                Console.WriteLine($"Najmniejsza wspolna wielokrotnosc podanych liczb to: {lowestMultiple}");

//            }

//            else
//            {
//                Console.WriteLine("Blad, liczby powinny byc wieksze od 0");
//            }

//        }
//    }

//}
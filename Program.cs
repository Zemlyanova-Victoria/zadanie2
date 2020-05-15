using System;
using static System.Convert;
using static System.Console;
using static System.String;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1 - Zadanie 1; \n2 - Zadanie 2; \n3 - Zadanie 3. ");
            int m = ToInt32(ReadLine());
            if (m == 1)
            {
                string b = ReadLine();
                int count = 0;
                int a = b.IndexOf("f");
                for (int n = a + 1; n < b.Length; n++)
                {
                    string g = (b[n] + "");
                    if (String.Compare("f", g) == 0)
                    {
                        WriteLine(n);
                        count++;
                        break;
                    }

                }
                if (a < 0) WriteLine(-2);
                else if (count == 0) WriteLine(-1);
            }
            else if (m == 2)
            {
                string d = ReadLine();

                string r = "";
                string[] rus = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
                string[] eng = { "A", "B", "V", "G", "D", "E", "E", "ZH", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "KH", "TS", "CH", "SH", "SHCH", "", "Y", "", "E", "YU", "YA" };


                for (int t = 0; t < d.Length; t++)
                {
                    int i = 0;
                    while (i < rus.Length)
                    {
                        string a = d[t] + "";
                        if (String.Compare(a, rus[i]) == 0)
                        {
                            r = r + eng[i];
                            i++;
                        }
                        else i++;
                    }
                }
                WriteLine(r);
            }
            else if (m == 3)
            {
                string y = ReadLine();
                int e = y.IndexOf("h");
                int o = y.LastIndexOf("h");
                string p = "";
                for (int i = 0; i < y.Length; i++)
                {
                    string k = (y[i] + "");
                    if (String.Compare("h", k) == 0 && i != e && i != o)
                    {
                        p = p + "H";
                    }
                    else p = p + y[i];
                }
                WriteLine(p);
            }
        }
    }

    }


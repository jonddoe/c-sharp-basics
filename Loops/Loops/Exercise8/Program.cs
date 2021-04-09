using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AsciiFigure());
            Console.ReadLine();





        }


        static string AsciiFigure()
        {
            int num = 5;
            var figure = "";
            for (int i = 1; i <= (num - 1); i++)
            {
                if (i==1)
                {
                    for (int j = 1; j <= ((num) * (num))-1; j++)
                    {
                        figure += "/";

                    }
                    for (int l = 1; l <= ((num) * (num)) -1; l++)
                    {
                        figure += "\\";

                    }
                    figure += "\n";
                }

                for (int j = 1; j <= ((num) * (num )) - ((i * (num)) )-1; j++)
                {
                    figure += "/";

                }

                for (int k = 1; k < (((num ) * i) * 2); k++)
                {
                    figure += "*";
                }
                for (int l = 1; l <= (((num) * (num)) - (i * num)); l++)
                {
                    figure += "\\" ;

                }

                figure += "\n";
            }

            return figure;
        }
    }

}

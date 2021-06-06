using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace count_date
{
    static class cal_date
    {
        public static string date_in;
        public static string date_out;
        public static int y;
        public static int z;
        public static int real;

        static public int DayOfYear(string month, string day, string year)
        {

            int d = Convert.ToInt32(day);
            int m = Convert.ToInt32(month);
            int y = Convert.ToInt32(year);

            int sum = 0;
            int[] M = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };



            if (m < 1 || m > 12)
            {
                Console.WriteLine("Month 1 to 12");
            }
            else
            {
                if (y % 4 == 0 && m >= 2)
                {
                    M[1] = 29;
                }
                if (m > 12)
                {
                    Console.WriteLine("Wrong data, Please input again");
                }
                else if (d > M[m - 1])
                {
                    Console.WriteLine("Wrong data, Please inpun again");
                }
                else
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        sum += M[j];

                    }
                    sum += d;
                    Console.WriteLine("The day is : " + sum);

                    Console.WriteLine(" {0} {1} {2}", d, m, y);
                }

            }
            return sum;
        }

        static public int count_start(string date_in)
        {
            //Session[start_date]
            // date_in = "2018-03-01";
            string[] date_start = date_in.Split('-');

            y = cal_date.DayOfYear(date_start[1], date_start[2], date_start[0]);

            date_out = DateTime.Now.ToString("yyyy/MM/dd");
            string[] date1 = date_out.Split('/');

            int z = cal_date.DayOfYear(date1[1], date1[2], date1[0]);

            return cal(y, z);
        }


        static public int cal(int y, int z)
        {
            real = 365 - y + 365 + 366 + z;
            return real;
        }

    }


    /*class Program
    {
        static void Main(string[] args)
        {

            string date = DateTime.Now.ToString("yyyy/MM/dd");
            string[] date1 = date.Split('/');

            string x = "2018-03-01";

            string[] date_start = x.Split('-');
            int y = cal_date.DayOfYear(date_start[1], date_start[2], date_start[0]);

            int z = cal_date.DayOfYear(date1[1], date1[2], date1[0]);

            int real = 365 - y + 365 + 366 + z;
            
        }
    }*/
}
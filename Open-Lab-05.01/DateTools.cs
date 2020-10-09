using System;
using System.Linq;
using System.Collections.Generic;
namespace Open_Lab_05._01
{
    public class DateTools
    {
        
        public string Century(int year)
        {
            
            int num = year / 100 + (year% 100 != 0 ? 1 : 0);
            string temp = num.ToString();
            char last = temp[temp.Length - 1];
            if (num < 10 || num > 20)
            {
                switch (last)
                {
                    case '1':
                        temp += "st";
                        break;
                    case '2':
                        temp += "nd";
                        break;
                    case '3':
                        temp += "rd";
                        break;

                    default:
                        temp += "th";
                        break;
                }
            }
            else
                temp += "th";
            return $"{temp} century";
        }


    }
}

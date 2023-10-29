using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RachevES.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int res = 0;
            int count = 0;

            foreach (char chr in value)
            {
                if (chr == item)
                {
                    count++;
                }
                else
                {
                    res = Math.Max(res, count);
                    count = 0;
                }
            }
            res = Math.Max(res, count);
            return res;

        }
    }
}

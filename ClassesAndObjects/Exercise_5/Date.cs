using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Date
    {
        private int _month;
        private int _day;
        private int _year;

        public void SetDate(int d, int m, int y)
        {
            _month = m;
            _day = d;
            _year = y;
        }

        public string DisplayDate()
        {
            return $"{_day}/{_month}/{_year}";
        }
    }
}

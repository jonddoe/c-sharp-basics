namespace Date
{
    public class Date
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
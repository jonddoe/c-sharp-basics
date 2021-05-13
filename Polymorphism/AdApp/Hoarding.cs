namespace AdApp
{
    public class Hoarding : Advert
    {
        private readonly int _rate;
        private readonly int _numDays;
        private readonly int _fee;

        public Hoarding(int fee, int rate, int numDays, bool isPrimeLocation) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
            _fee = fee;
            if (isPrimeLocation)
            {
                _rate += _rate / 2;
            }

            base.SetFee(Cost());
        }

        public new int Cost()
        {
            return _fee + (_rate * _numDays);
        }

        public override string ToString()
        {
            return "\nHoarding: Fee = " + Cost();
        }
    }
}
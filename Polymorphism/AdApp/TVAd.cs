namespace AdApp
{
    public class TvAd : Advert
    {
        private readonly int _rate;
        private readonly int _seconds;
        private readonly int _fee;

        public TvAd(int fee, int rate, int seconds, bool isPrimeTime) : base(fee)
        {
            _rate = rate;
            _seconds = seconds;
            _fee = fee;
            if (isPrimeTime)
            {
                _rate *= 2;
            }

            base.SetFee(Cost());
        }

        public new int Cost()
        {
            return _fee + _rate * _seconds;
        }

        public override string ToString()
        {
            return "\nTV Ad. Fee = " + Cost();
        }
    }
}
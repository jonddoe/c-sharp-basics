namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private readonly int _column;
        private readonly int _rate;
        private readonly int _fee;

        public NewspaperAd(int fee, int rate, int column) : base(fee)
        {
            _rate = rate;
            _column = column;
            _fee = fee;
            base.SetFee(Cost());
        }

        private new int Cost()
        {
            return _fee + _rate * _column;
        }

        public override string ToString()
        {
            return "\nNewspaper Ad: Fee = " + Cost();
        }
    }
}
namespace AdApp
{
    public class Poster : Advert
    {
        private readonly int _copies;
        private readonly int _costPerCopy;
        private readonly int _fee;

        public Poster(int fee, string dimension, int copies, int costPerCopy) : base(fee)
        {
            _copies = copies;
            _costPerCopy = costPerCopy;
            _fee = fee;
            base.SetFee(Cost());
        }

        public new int Cost()
        {
            return (_fee + _copies * _costPerCopy);
        }

        public override string ToString()
        {
            return "\nPoster. Fee = " + Cost();
        }
    }
}
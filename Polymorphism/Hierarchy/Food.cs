namespace Hierarchy
{
    public abstract class Food
    {
        public int Quantity;
        public string TypeOfFood;

        protected Food(string typeOfFood,int quantity)
        {
            Quantity = quantity;
            TypeOfFood=typeOfFood;
        }

    }
}
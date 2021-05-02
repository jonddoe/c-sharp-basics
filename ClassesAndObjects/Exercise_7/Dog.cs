namespace Exercise_7
{
    class Dog
    {
        private string _name;
        private string _sex;
        public string mother { get; set; }
        public string father { get; set; }

        public Dog(string n, string s)
        {
            _name = n;
            _sex = s;
        }

        public string FathersName()
        {
            return father ?? "Unknown";
        }

        public string MothersName()
        {
            return mother ?? "Unknown";
        }

        public string DogsName()
        {
            return _name;
        }

        public bool HasSameMotherAs(Dog dog1)
        {
            return mother == dog1.mother;
        }
    }
}
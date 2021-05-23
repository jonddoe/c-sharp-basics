using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private readonly SortedDictionary<int, PhoneEntry> _data;
        private int _dataCount;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<int, PhoneEntry>();
            _dataCount = 0;
        }

        public int Find(string name)
        {
            var position = -1;
            foreach (var c in _data.Where(c => c.Value.Name == name))
            {
                position = c.Key;
            }

            return position;
        }

        public string GetNumber(string name)
        {
            var position = Find(name);
            return position == -1 ? null : _data[position].Number;
        }

        public void PutNumber(string name, string number)
        {
            var contact = new PhoneEntry {Name = name, Number = number};
            _data.Add(_dataCount, contact);
            _dataCount++;
        }
    }
}
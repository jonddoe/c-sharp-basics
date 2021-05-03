using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<int, PhoneEntry> data;
        private int _dataCount;

        public PhoneDirectory()
        {
            data = new SortedDictionary<int, PhoneEntry>();
            _dataCount = 0;
        }

        private int Find(string name)
        {
            foreach (var c in data)
            {
                if (data.ContainsValue(c.Value))
                {
                    return c.Key;
                }
            }

            return -1;
        }

        public string GetNumber(string name)
        {
            var position = Find(name);
            return position == -1 ? null : data[position].number;
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            var contact = new PhoneEntry {name = name, number = number};
            data.Add(_dataCount, contact);
            _dataCount++;
        }
    }
}
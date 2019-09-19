using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace TestDrivenDevelopment
{
    public class MagicalIntBagOfMagicalEntetiesOfMagic: IMagicalIntBagOfMagicalEntetiesOfMagic
    {
        public List<int> numbersInBag = new List<int>();
        

        public int CountNumbersInBag()
        {
            return numbersInBag.Count;
        }
        
        public void add(int number)
        {
            numbersInBag.Add(number);
        }

        public void remove()
        {
            CheckLowestNumber();
            numbersInBag.RemoveAt(0);
        }

        public int CheckLowestNumber()
        {
            var lowestNumber = numbersInBag.Min();
            return lowestNumber;
        }
    }
}
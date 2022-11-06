using System;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Security.Cryptography;

namespace Lab16_3
{
    public class MenuElem:IComparable
    {
        public string name;
        public int subElems;

        public MenuElem(string name, int subElems)
        {
            this.name = name;
            this.subElems = subElems;
        }
        
        public int CompareTo(object obj)
        {
            var sho = (MenuElem) obj;
            if (this.name != sho.name)
                return this.name.CompareTo(sho.name);
            return this.subElems.CompareTo(sho.subElems); 
        }

        public override bool Equals(object obj)
        {
            var sho = (MenuElem) obj;
            return sho.name == this.name && sho.subElems == this.subElems;
        }

        public override string ToString()
        {
            return $"{this.name}, {this.subElems}";
        }
    }
}
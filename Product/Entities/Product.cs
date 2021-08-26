using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Entities
{
    class Product
    {
        public String Name { get; set; }
        public Double Value { get; set; }

        public Product(string name, double value)
        {
            Name = name;
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
                return false;
            Product other = obj as Product;
            return Name.Equals(other.Name) && Value.Equals(other.Value);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Value.GetHashCode();
        }
    }
}

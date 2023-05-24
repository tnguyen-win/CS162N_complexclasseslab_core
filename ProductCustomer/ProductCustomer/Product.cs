using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductClasses
{
    public class Product
    {
        private int id;
        private string code;
        private string description;
        private decimal unitPrice;
        private int quantity;

        public Product() { }

        public Product(int productId, string productCode, string desc, decimal price, int qty)
        {
            id = productId;
            code = productCode;
            description = desc;
            unitPrice = price;
            quantity = qty;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        public int QuantityOnHand
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Id: {0} Code: {1} Description: {2} UnitPrice: {3:C} Quantity: {4}", id, code, description, unitPrice, quantity);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
                return false;
            else
            {
                Product other = (Product)obj;
                return other.Id == Id &&
                    other.Code == Code &&
                    other.Description == Description &&
                    other.UnitPrice == UnitPrice &&
                    other.QuantityOnHand == QuantityOnHand;
            }
        }
        
        public override int GetHashCode()
        {
            return 13 + 7 * id.GetHashCode() +
                7 *code.GetHashCode() +
                7 * description.GetHashCode() +
                7 * unitPrice.GetHashCode() + 
                7 * quantity.GetHashCode();
        }
        
        
        public static bool operator ==(Product p1, Product p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return !p1.Equals(p2);
        }

    }
}

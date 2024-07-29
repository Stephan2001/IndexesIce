using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IndexedClasses_Ice1
{
    public class Menu
    {
        private string foodItem;
        private double price;

        public Menu(string foodItem, double price)
        {
            if (foodItem == null)
            {
                this.foodItem = "Not applicable";
            }
            else if (price < 0)
            {
                this.price = 0.0;
            }
            else
            {
                this.foodItem = foodItem;
                this.price = price;
            }
        }

        public object this[int index]
        {
            get {
                switch (index) { 
                    case 0: return this.foodItem;
                    case 1: return this.price;
                    default: return "Not found";
                } 
            }

            set
            {
                switch (index)
                {
                    case 0:
                        foodItem = (string)value;
                        break;
                    case 1:
                        price = (double)value;
                        break;
                }
            }
        }

        public object this[string attrName]
        {
            get
            {
                switch (attrName)
                {
                    case "foodItem": return this.foodItem;
                    case "price": return this.price;
                    default: return "Not found";
                }
            }

            set
            {
                switch (attrName)
                {
                    case "foodItem":
                        foodItem = (string)value;
                        break;
                    case "price":
                        price = (double)value;
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTEST
{
    class Item
    {
        private string itemcode;
        private string description;
        private int quantityavailable;

        public Item(string aItemcode,string aDescription,int aQuantityavailable)
        {
            itemcode = aItemcode;
            description = aDescription;
            quantityavailable = aQuantityavailable;
        }

        public string Itemcode
        {
            get { return itemcode; } 
        }
        public string Description
        {
            get { return description; }
        }
        public int Quantityavailable
        {
            get { return quantityavailable; }
        }
        public void PutIn(int addquantity)
        {
            quantityavailable += addquantity;
        }
        public void TakeOut(int subquantity)
        {
            if (quantityavailable > 0 && quantityavailable >= subquantity)
            {
                quantityavailable -= subquantity;
            }
        }

    }
}

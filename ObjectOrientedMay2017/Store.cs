using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOTEST
{
    class Store
    {
        private string name;
        private ArrayList itemlist;

        public Store(string aName)
        {
            name = aName;
            itemlist = new ArrayList();
        }

        public string Name
        {
            get { return name; }
        }
        public ArrayList Itemlist
        {
            get { return itemlist; }
        }
        public void AddItem(Item aItem)
        {
            itemlist.Add(aItem);
        }
        public Item FindItem(string aCode)
        {
            int count;
            count = itemlist.Count;
            Item aitem=new Item("N/a","N/a",0);
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                Item item = (Item)itemlist[i];
                if(aCode==item.Itemcode)
                {
                    found = true;
                    aitem = item;
                }              
            }
            if (found)
            {
                return aitem;
            }
            else { return null; }
        }
        public ArrayList GetUnavailableItems()
        {
            ArrayList items = new ArrayList();
            int acount=itemlist.Count;
            for (int i = 0; i < acount; i++)
            {
               Item aitem = (Item)itemlist[i];
                if (aitem.Quantityavailable == 0)
                {
                    items.Add(aitem);
                }
            }
            return items;
          
        }
    }
}

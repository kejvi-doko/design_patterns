using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Part : Item
    {
        public Part(string description, int cost):base(description, cost)
        {

        }
        public override Item[] Items => new Item[0];

        public override void AddItem(Item item)
        {
            
        }

        public override void RemoveItem(Item item)
        {
            
        }
    }
}

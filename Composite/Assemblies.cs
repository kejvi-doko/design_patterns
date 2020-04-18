using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Assemblies:Item
    {
        private List<Item> items;

        public Assemblies(string description) : base(description, 0)
        {
            items=new List<Item>();
        }

        public override void AddItem(Item item)
        {
            items.Add(item);
        }

        public override void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public override int Cost => Items.Sum(x => x.Cost);
        
        public override Item[] Items => items.ToArray();
    }
}

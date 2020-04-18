using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Item
    {
        private string description;
        private int cost;

        protected Item(string description, int cost)
        {
            this.description = description;
            this.cost = cost;
        }

        public virtual string Description => description;
        public virtual int Cost => cost;

        public abstract void AddItem(Item item);
        public abstract void RemoveItem(Item item);
        public abstract Item[] Items { get; }

        public override string ToString()
        {
            return description + " (cost " + Cost + ")";
        }
    }
}

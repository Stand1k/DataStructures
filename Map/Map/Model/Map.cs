using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Model
{
    public class Map<TKey, TValue>
    {
        private int size = 100;
        private Item<TKey, TValue>[] Items;

        public Map() 
        {
            Items = new Item<TKey, TValue>[size]; 
        }

        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);

            if(Items[hash] == null)
            {
                Items[hash] = item;
            }
            else
            {
                var placed = false;
                for(var i = hash; i < size; i++)
                {
                    if(Items[i].Key.Equals(item.Key))
                    {
                        return; 
                    }

                    if(Items[i] == null)
                    {
                        Items[i] = item;
                        placed = true;
                        break;
                    }
                }

                if(!placed)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Items[i].Key.Equals(item.Key))
                        {
                            return;
                        }

                        if (Items[i] == null)
                        {
                            Items[i] = item;
                            break;
                        }
                    }
                }
            }
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample.Models
{
    public class Item<T>
    {
        private T data = default;

        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                {
                    data = value;
                }
                else
                {
                    throw new ArgumentException(nameof(value));
                }
            }
        }

        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }
    }

}

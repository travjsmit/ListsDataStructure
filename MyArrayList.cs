using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDataStructure
{
    public class MyArrayList
    {
        public int[] list;
        int size = 0;

        public MyArrayList()
        {
            list = new int[10];
        }

         public MyArrayList(int size)
        {
            list = new int[size];
        }

        /// <summary>
        /// Will add the incoming value to the end of the list.
        /// </summary>
        public void Append(int value)
        {
            IncreaseCapacity();
            list[size++] = value;
        }

        private void IncreaseCapacity()
        {
            if (size == list.Length) // We need to expand
            {
                int[] newArray = new int[size + 10];
            }
        }
    }
}

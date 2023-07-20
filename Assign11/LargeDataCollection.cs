/*using System;
using System.Collections.Generic;

namespace CustomCollection
{
    public class LargeDataCollection : IDisposable
    {
        private int[] data;
        private int currentIndex;

       
        public LargeDataCollection(int[] initialData)
        {
            
            //data = new int[initialData.Length];
              data = initialData;
            //initialData.CopyTo(data, 0);
             currentIndex = 0;
            //currentIndex = initialData.Length;
        }

        public void Add(int element)
        {
            if (currentIndex == data.Length)
            {
                // If the array is full, resize it to double the capacity.
                Array.Resize(ref data, data.Length * 2);
            }

            data[currentIndex] = element;
            currentIndex++;
        }
        *//* public void Add(int element)
         {
             if (currentIndex < data.Length)
             {
                data[currentIndex] = element;
                 currentIndex++;
             }
             else
             {
             Console.WriteLine("The collection is full. Cannot add more elements.");
             //Console.WriteLine($"data {element} added successfully");
             }
         }*//*

        public void Remove(int element)
        {
            int index = Array.IndexOf(data, element);
            if (index >= 0)
            {
                for (int i = index; i < currentIndex - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                currentIndex--;
            }
            else
            {
                Console.WriteLine("Element not found in the collection.");
            }
        }

        public void DisplayCollection()
        {
            Console.WriteLine("Current Collection:");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }

        public void Dispose()
        {
            data = null;
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Assignment
{
    public class LargeDataCollection : IDisposable
    {
        private List<int> data;

        public LargeDataCollection(IEnumerable<int> initialData)
        {
            data = new List<int>(initialData);
        }

        public void Add(int item)
        {
            data.Add(item);
        }

        public bool Remove(int item)
        {
            return data.Remove(item);
        }

        public int this[int index]
        {
            get { return data[index]; }
        }

        public int Count => data.Count;

        public void DisplayAllElements()
        {
            Console.WriteLine("All elements in the collection:");
            foreach (int item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                data.Clear();
                data = null;
            }
        }
    }
}

using System;

namespace ConsoleApp.DynamicArray
{
    public class MyDynamicArray
    {
        private object[] myArray;
        private int count;
        private int capacity;
        public int Count
        {
            get { return this.count; }
        }
        public int Capacity
        {
            get { return this.capacity; }
        }

        public MyDynamicArray()
        {
            this.capacity = 2;
            myArray = new object[this.Capacity];
            this.count = 0;
        }

        public object this[int index]
        {
            get { return this.myArray[CheckOutOfRange(index)]; }
            set { this.myArray[CheckOutOfRange(index)] = value; }
        }

        public void Add(object data)
        {
            if (this.count == this.Capacity)
            {
                CreateNewArray();
            }
            this.myArray[this.count] = data;
            this.count++;
        }

        private void CreateNewArray()
        {
            this.capacity *= 2;
            object[] temp = myArray;
            myArray = new object[this.capacity];

            Array.Copy(temp, myArray, temp.Length);
        }

        private int CheckOutOfRange(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException();
            }

            return index;
        }
    }
}

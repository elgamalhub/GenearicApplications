using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class StackType<T>
    {
        T[] arr;
        int top = -1;
        public void Push(T item)
        {
            top++;
            if(arr is null)
            {
                arr = new T[] {item};
            } else
            {
                var newArray = new T[arr.Length+1];
                Array.Copy(arr, newArray, arr.Length);
                newArray[top] = item;
                arr = newArray;
            }
        }
        public T Pop() 
        {
            if(arr is null || arr.Length == 0)
            {
                Console.WriteLine("Stack is empty");
                return default;
            }
            var removedItem = arr[top];
            top--;
            var newArray = new T[arr.Length-1];
            Array.Copy(arr, newArray, arr.Length - 1);
            arr = newArray;
            return removedItem;
        }

        public T Peek()
        {
            if (arr is null || arr.Length == 0)
            {
                Console.WriteLine("Stack is empty! No elements to peek.");
                return default;
            }
            return arr[top];
        }
        public void Print()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    }

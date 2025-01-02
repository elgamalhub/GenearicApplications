namespace Stack
{
    internal class ListType<T>
    {
        private T[] arr;
        public void Add(T item)
        {
            if (arr == null)
                arr = new T[] { item };
            else
            {
                var newArray = new T[arr.Length + 1];
                Array.Copy(arr, newArray, arr.Length);
                newArray[arr.Length] = item;
                arr = newArray;
            }
        }
        public void Remove() {
            if (arr is null || arr.Length ==0)
                Console.WriteLine("it's empty");
            else
            {
                var newArray = new T[arr.Length - 1];
                Array.Copy(arr, newArray, arr.Length-1);
                arr = newArray;
            }
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

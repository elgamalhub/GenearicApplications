namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region listType
            //ListType<int> listType = new ListType<int>();
            //listType.Remove();
            //listType.Add(1);
            //listType.Add(2);
            //listType.Add(3);
            //listType.Print();
            //listType.Remove();
            //listType.Remove();
            //listType.Remove();
            //listType.Remove();
            //listType.Print();
            #endregion

            StackType<int> stack = new StackType<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var x = stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Push(22);
            stack.Push(23);
            stack.Pop();
            Console.WriteLine(x);
            stack.Print();

        }
    }
}

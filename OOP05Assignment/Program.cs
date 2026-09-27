namespace OOP05Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            // part 01
            #region Question01
            // Question A:
            // assuming it's a reference type, both variables point to the same object
            
            // Question B:
            // No, because it only copies the refernce of the existing object (shallow copy)
            // and doesn't make a new copy of the object by default
            
            // Question C:
            // copying an object creates a new copy of the object with the same data of the existing object
            // and therefore changing one object doesn't change its copies
            // copying a reference copies only the reference of the object and doesn't create a new object
            // and therefore any changes made to any of the references affects all the others
            #endregion

        }
    }
}

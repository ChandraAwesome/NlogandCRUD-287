using static NlogandCRUD.CRUD;

namespace NlogandCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            attendance obj = new attendance();
            obj.check();

            // CRUD using ArrayList and Dictionary

            CRUD.Data();
            Console.WriteLine();
            Dictionaryoperations.Data2();
        }
    }
}
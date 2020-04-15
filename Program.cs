using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortWithDelegates
{
    class BackEnd
    {
        MyDataBase db = new MyDataBase();
        public List<TShirt> GetAll()
        {
            return db.Alltshirts.ToList();
        }

        public void PrintAll(List<TShirt> AllTshirts)
        {
            foreach (TShirt t in AllTshirts)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}", t.Color, t.Size, t.Fabric);
            }
        }

        //Color in ascending bubble Sort
        public void PrintByColorAscending(List<TShirt> AllTshirts)
        {
            TShirt temp;
            for (int j = 0; j <= AllTshirts.Count - 2; j++)
            {
                for (int i = 0; i <= AllTshirts.Count - 2; i++)
                {
                    if (AllTshirts.ElementAt(i).Color > AllTshirts.ElementAt(i + 1).Color)
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted by Color ascending :");
            foreach (TShirt t in AllTshirts)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}", t.Color, t.Size, t.Fabric);
            }
            Console.Write("\n");
        }

        //Color in descending  bubble Sort
        public void PrintByColorDescending(List<TShirt> AllTshirts)
        {
            TShirt temp;
            for (int j = 0; j <= AllTshirts.Count - 2; j++)
            {
                for (int i = 0; i <= AllTshirts.Count - 2; i++)
                {
                    if (AllTshirts.ElementAt(i).Color < AllTshirts.ElementAt(i + 1).Color)
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted by Color descending  :");
            foreach (TShirt t in AllTshirts)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}", t.Color, t.Size, t.Fabric);
            }
            Console.Write("\n");
        }

        //Size and Color and Fabric in ascending
        public void PrintByColorSizeFabric(List<TShirt> AllTshirts)
        {
            TShirt temp;
            for (int j = 0; j <= AllTshirts.Count - 2; j++)
            {
                for (int i = 0; i <= AllTshirts.Count - 2; i++)
                {
                    if (AllTshirts.ElementAt(i).Fabric > AllTshirts.ElementAt(i + 1).Fabric)
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                    if (AllTshirts.ElementAt(i).Size > AllTshirts.ElementAt(i + 1).Size)
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                    if (AllTshirts.ElementAt(i).Color > AllTshirts.ElementAt(i + 1).Color)
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted by Color and Size and Fabric in ascending  :");
            foreach (TShirt t in AllTshirts)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}", t.Color, t.Size, t.Fabric);
            }
            Console.Write("\n");
        }
    }
    class FrontEnd
    {
        BackEnd b = new BackEnd();
        public void Print()
        {
            var tshirts = b.GetAll();
            b.PrintAll(tshirts);
            b.PrintByColorAscending(tshirts);
            b.PrintByColorDescending(tshirts);
            b.PrintByColorSizeFabric(tshirts);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            FrontEnd f = new FrontEnd();
            f.Print();

            Console.ReadKey();
        }
    }
}

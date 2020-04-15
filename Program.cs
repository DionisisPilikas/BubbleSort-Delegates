using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortWithDelegates
{
    //declare a bool typed delegate who can point to only bool typed methods with parameters List<TShirt> list and an integer 
    delegate bool MyDelegate1(List<TShirt> list, int a);

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
        public void PrintByColorAscending(List<TShirt> AllTshirts, MyDelegate1 check)//<-- callback
        {
            TShirt temp;
            for (int j = 0; j <= AllTshirts.Count - 2; j++)
            {
                for (int i = 0; i <= AllTshirts.Count - 2; i++)
                {
                    if (check(AllTshirts,i))
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                }
            }
            
            foreach (TShirt t in AllTshirts)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}", t.Color, t.Size, t.Fabric);
            }
            Console.Write("\n");
        }

        //Color in descending  bubble Sort
        public void PrintByColorDescending(List<TShirt> AllTshirts, MyDelegate1 check) //<-- callback
        {
            TShirt temp;
            for (int j = 0; j <= AllTshirts.Count - 2; j++)
            {
                for (int i = 0; i <= AllTshirts.Count - 2; i++)
                {
                    if (check(AllTshirts,i)) //MyDelegate1 ColorAscChech = ColorAscCondition; 
                    {                                                               
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                }
            }

            foreach (TShirt t in AllTshirts)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}", t.Color, t.Size, t.Fabric);
            }
            Console.Write("\n");
        }

        //Size and Color and Fabric in ascending
        public void PrintByColorSizeFabric(List<TShirt> AllTshirts, MyDelegate1 check1, MyDelegate1 check2, MyDelegate1 check3)
        {                                                                   //-- callback 3 delegates
            TShirt temp;
            for (int j = 0; j <= AllTshirts.Count - 2; j++)
            {
                for (int i = 0; i <= AllTshirts.Count - 2; i++)
                {
                    if (check3(AllTshirts,i))  //Fabric check -> check3
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                    if (check2(AllTshirts,i))  //Size check -> check2
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                    if (check1(AllTshirts,i)) //Color check -> ckeck1
                    {
                        temp = AllTshirts[i + 1];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i + 1] = AllTshirts[i];
                        AllTshirts[i] = temp;
                    }
                }
            }
            
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

        //create a method that check the condition about color in ascending
        static bool ColorAscCondition(List<TShirt> list, int a)
        {
            return list.ElementAt(a).Color > list.ElementAt(a + 1).Color ? true : false;

            //if (list.ElementAt(a).Color > list.ElementAt(a + 1).Color)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }
        MyDelegate1 ColorAscChech = new MyDelegate1(ColorAscCondition);
        //MyDelegate1 ColorAscChech = ColorAscCondition;


        static bool ColorDescCondition(List<TShirt> list , int a)
        {
            return list.ElementAt(a).Color < list.ElementAt(a + 1).Color ? true : false;
        }
        MyDelegate1 ColorDescCheck = new MyDelegate1(ColorDescCondition);



        static bool SizeAscCondition(List<TShirt> list, int a)
        {
            return list.ElementAt(a).Size > list.ElementAt(a + 1).Size ? true : false;
        }
        MyDelegate1 SizeAscChech = new MyDelegate1(SizeAscCondition);



        static bool FabricAscCondition(List<TShirt> list, int a)
        {
            return list.ElementAt(a).Fabric > list.ElementAt(a + 1).Fabric ? true : false;
        }
        MyDelegate1 FabricAscChech = new MyDelegate1(FabricAscCondition);


        public void Print()
        {
            var tshirts = b.GetAll();
            b.PrintAll(tshirts);
            Console.WriteLine("\n" + "Sorted by Color ascending :");
            b.PrintByColorAscending(tshirts,ColorAscChech);
            Console.WriteLine("\n" + "Sorted by Color descending  :");
            b.PrintByColorDescending(tshirts,ColorDescCheck);
            Console.WriteLine("\n" + "Sorted by Color and Size and Fabric in ascending  :");
            b.PrintByColorSizeFabric(tshirts,ColorAscChech,SizeAscChech,FabricAscChech);
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

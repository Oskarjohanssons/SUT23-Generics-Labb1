namespace SUT23_Generics_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxList = new BoxCollection();

            boxList.Add(new Box(10, 10, 15));
            boxList.Add(new Box(25, 100, 71));
            boxList.Add(new Box(17, 750, 90));
            boxList.Add(new Box(65, 20, 55));
            boxList.Add(new Box(2, 2, 4));

            Console.WriteLine("----------------------------------------------------------------------");
            Display(boxList);
            Console.WriteLine("----------------------------------------------------------------------");
            boxList.Remove(new Box(10, 10, 15));
            Console.WriteLine("----------------------------------------------------------------------");


            Display(boxList);

            Box boxToCheck = new Box(25, 100, 71);
            Console.WriteLine("----------------------------------------------------------------------");


            if (boxList.Contains(boxToCheck))
            {
                Console.WriteLine("Box do exist and contains Height:{0} Length:{1} Width:{2} Volume:{3}",
                boxToCheck.Height.ToString(), boxToCheck.Length.ToString(), boxToCheck.Width.ToString(), boxToCheck.Volume.ToString());
            }
            else
            {
           
            }
            Console.WriteLine("----------------------------------------------------------------------");


            Console.ReadKey();
        }

        public static void Display(BoxCollection boxes)
        {
            Console.WriteLine("\tHeight \tLength \tWidth \tVolume");
            foreach (Box box in boxes)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                box.Height.ToString(), box.Length.ToString(), box.Width.ToString(), box.Volume.ToString());
            }
        }
    }
}
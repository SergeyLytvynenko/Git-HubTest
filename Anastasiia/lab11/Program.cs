using System;


namespace lab11

{
    class SmartRef 
    {
        

        public SmartRef(string Model, int Frostlevel, int Capacity, string Color, int Weight, int Height)         
        {

        }
        public SmartRef()
        {

        }
        public void RefOn()
        {
            Console.WriteLine("\nRefrigerator was turned ON\n");
        }

        public void RefOff()
        {
            Console.WriteLine("\nRefrigerator was turned OFF\n");
        }

        public string Model
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        public int Width
        {
            get;
            set;
        }
        public string Height
        {
            get;
            set;
        }
        public int Capacity
        {
            get;
            set;
        }
        public int frostlevel
        {
            get;
            set;
        }
        public object Products { get; internal set; }


        public void ProductCheck()
        {
            if (Capacity == 0) { Console.WriteLine("\n---->There is no food\n"); }
            if (0 <= Capacity && Capacity < 5) { Console.WriteLine("\n---->There is some food\n"); }
            if (5 <= Capacity && Capacity < 10) { Console.WriteLine("\n---->There is enough food\n"); }
            if (Capacity >= 10) { Console.WriteLine("\n---->There is a lot of food\n"); }
        }
    }

    class Products 
    {
        public Products(string ProductName, int RoductWidth)
        {

        }
        public Products()
        {

        }
        public string ProductName
        {
            get; set;
        }
        public int ProductWidth
        {
            get; set;
        }
        public int ProductDate
        {
            get; set;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\tStyrta Anastasiia, IPZ-13\n");
            Console.WriteLine("\n------------------------------------------------------------------------\n");
            SmartRef fridge = new SmartRef();

            fridge.RefOn();

            int Off_On = 1;

            do
            {
                Console.WriteLine("\n\t\t\t SMART REFRIGERATORS");
                Console.WriteLine("\n------------------------------------------------------------------------\n");
                Console.WriteLine("---> Model refrigerators:");
                fridge.Model = Console.ReadLine();

                Console.WriteLine("---> Frost level refrigerators: ");
                fridge.frostlevel = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---> Capacity of refrigerators: ");
                fridge.Capacity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---> Color of refrigerators:");
                fridge.Color = Console.ReadLine();

                Console.WriteLine("---> Refrigerators weigth: ");
              
                fridge.Width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---> Refrigerators heigth: ");
                fridge.Height = Console.ReadLine();

                Console.WriteLine("---> How many units of food to add to the refrigerator: ");
                fridge.Capacity = Convert.ToInt32(Console.ReadLine());

                Products[,] Pro = new Products[fridge.Capacity, 1];

                for (int i = 0; i < fridge.Capacity; i++)
                {
                    Console.WriteLine("----> Product add <----\n");
                    Console.WriteLine("Enter product name: ");
                    Pro[i, 0] = new Products();
                    Pro[i, 0].ProductName = Console.ReadLine();
                    Console.WriteLine("Enter product weight: ");
                    Pro[i, 0].ProductWidth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter how many days before the expiration date: ");
                    Pro[i, 0].ProductDate = Convert.ToInt32(Console.ReadLine());

                    
                }

                Console.WriteLine("\n\n\t\t\tModel refrigerators: {0}" + "\n\t\t\t" + "Frost level refrigerators: {1}" + "\n\t\t\t" + "Capacity of refrigerators:  {2}" + "\n\t\t\t" + "Color refrigerators: {3}" + "\n\t\t\t" + "Refrigerators weigth: {4}" + "\n\t\t\t" + "Refrigerators height:{5}", fridge.Model, fridge.frostlevel, fridge.Capacity, fridge.Color, fridge.Width, fridge.Height);
                fridge.ProductCheck();
                Console.ReadKey();

            }
            while (Off_On != 0);

        }
    }
}




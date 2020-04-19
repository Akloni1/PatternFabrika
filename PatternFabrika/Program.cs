using System;

namespace PaternFabrika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название оружия: ");
            String arms = Console.ReadLine();

                                 Factory factory = new Factory();

            switch (arms)
            {
                case "Brt92FS":
                    {
                       
                        Arms brt92FS = factory.create(arms);
                          brt92FS.Shooting();

                        break;
                    }
                case "Glock18":
                    {
                        
                         Arms glock18 = factory.create(arms);
                         glock18.Shooting();
                        break;
                    }

                case "Ak47":
                    {
                       
                        Arms ak47 = factory.create(arms);
                        ak47.Shooting();
                        break;
                    }

            }
            

        }
    }
}

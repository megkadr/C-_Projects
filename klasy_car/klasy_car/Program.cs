using System;
using System.Collections.Generic;

namespace klasy_car
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var carList = new List<Car>();
            carList.Add(new Car_petrol());
            carList.Add(new Car_gas());
            carList.Add(new Car_petrol_gas());
            foreach (var car in carList)
            {
                car.start_engine();
                car.refuel();
                car.drive();
                car.close_engine();
                car.drive();
                car.start_engine();
                car.drive();
            }

            Console.ReadKey();
        }

        private abstract class Car
        {
            public bool engine { get; set; }

            public void start_engine()
            {
                if (engine)
                    Console.WriteLine("silnik właczony zostaw ta stacyjke");
                else
                    engine = true;
                Console.WriteLine("silnik właczony");
            }

            public void close_engine()
            {
                if (engine == false) Console.WriteLine("silnik wylaczony zostaw ta stacyjke");
                engine = false;
                Console.WriteLine("silnik wylaczony");
            }

            public abstract void refuel();
            public abstract void drive();
        }

        private class Car_petrol : Car
        {
            public bool tank { get; set; }

            public override void refuel()
            {
                if (tank)
                    Console.WriteLine("bak pelny nie trzeba tankowac kierowniku");
                else
                    tank = true;
                Console.WriteLine("tankowanie baku");
                Console.WriteLine("bak pelny");
            }

            public override void drive()
            {
                if (tank && engine)
                {
                    tank = false;
                    Console.WriteLine("jazda na pelnej");
                    Console.WriteLine("bak pusty");
                }
                else if (engine == false)
                {
                    Console.WriteLine("silnik nie jest wlaczony, trzeba wlaczyc");
                }
            }
        }

        private class Car_gas : Car
        {
            public bool butla { get; set; }

            public override void refuel()
            {
                if (butla)
                    Console.WriteLine("butla pelny nie trzeba tankowac kierowniku");
                else
                    butla = true;
                Console.WriteLine("tankowanie butli");
                Console.WriteLine("butla pelna");
            }

            public override void drive()
            {
                if (butla && engine)
                {
                    butla = false;
                    Console.WriteLine("jazda na pelnej");
                    Console.WriteLine("butla pusta");
                }
                else if (engine == false)
                {
                    Console.WriteLine("silnik nie jest wlaczony, trzeba wlaczyc");
                }
            }
        }

        private class Car_petrol_gas : Car
        {
            public bool tank { get; set; }
            public bool butla { get; set; }
            private int n;

            public override void refuel()
            {
                if (butla)
                    Console.WriteLine("butla i bak pelny nie trzeba tankowac kierowniku");
                else
                    butla = true;
                tank = true;
                Console.WriteLine("tankowanie baku i butli");
                Console.WriteLine("bak i butla pelne");
            }

            public override void drive()
            {
                if (n == 0)
                    if (butla && engine && tank)
                    {
                        tank = false;
                        n = 1;
                        Console.WriteLine("jazda na pelnej");
                        Console.WriteLine("bak pusty butla pelna");
                    }

                if (n == 1)
                {
                    if (butla && engine && tank == false)
                    {
                        butla = false;
                        n = 0;
                        Console.WriteLine("jazda na pelnej");
                        Console.WriteLine("butla i bak puste");
                    }
                }
                else if (engine == false)
                {
                    Console.WriteLine("silnik nie jest wlaczony, trzeba wlaczyc");
                }
            }
        }
    }
}
using System.Text;

namespace Lab_2
{
    // Клас Car
    public class Car
    {
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        public int Passengers { get; set; }
    }

    // Клас Product
    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 1. Масив А: знайти елементи, що включають пробіл
            Console.WriteLine("\t\t1. Масив А: знайти елементи, що включають пробіл");
            string[] A = { "Falluot 3", "Daxter 2", "System Shok 2", "Morrowind", "Pes 2013" };

            IEnumerable<string> resultA = from game in A
                                          where game.Contains(" ")
                                          select game;
            Console.WriteLine("Елементи масиву A:");
            foreach (var item in A)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Елементи масиву A, що містять пробіл:");
            foreach (var item in resultA)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            // 2. Масив B: знайти негативні елементи і повернути як List<int>
            Console.WriteLine("\t\t2.Масив B: знайти негативні елементи і повернути як List");
            int[] B = { 2, -7, -10, 6, 7, 9, 3 };

            List<int>? resultB = (from number in B
                                  where number < 0
                                  select number).ToList();

            Console.WriteLine("Елементи масиву B:");
            foreach (var item in B)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Негативні елементи масиву B:");
            foreach (var item in resultB)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // 3. Масив C: знайти всі відтінки зеленого кольору
            Console.WriteLine("\t\t3. Масив C: знайти всі відтінки зеленого кольору");
            string[] C = {
                "Light Green", "Red", "Green", "Yellow", "Purple", "Dark Green",
                "Light Red", "Dark Red", "Dark Yellow",  "Light Yellow"
            };

            var resultC = from color in C
                          where color.ToLower().Contains("green")
                          select color;
            Console.WriteLine("Елементи масиву C:");
            foreach (var item in C)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Відтінки зеленого в масиві C:");
            foreach (var item in resultC)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // 4. Створити перелік автомобілів Car та вибрати Audi
            Console.WriteLine("\t\t4. Створити перелік автомобілів Car та вибрати Audi");
            List<Car> cars = new List<Car>
            {
                new Car { Manufacturer = "Audi", Color = "Red", MaxSpeed = 240, Passengers = 5 },
                new Car { Manufacturer = "BMW", Color = "Black", MaxSpeed = 230, Passengers = 4 },
                new Car { Manufacturer = "Audi", Color = "Blue", MaxSpeed = 220, Passengers = 4 }
            };

            var audiCars = from car in cars
                           where car.Manufacturer == "Audi"
                           select car;
            Console.WriteLine("Інформація про автомобілі:");
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Manufacturer}, {car.Color}, MaxSpeed: {car.MaxSpeed}, Passengers: {car.Passengers}");
            }
            Console.WriteLine();
            Console.WriteLine("Інформація про автомобілі Audi:");
            foreach (var car in audiCars)
            {
                Console.WriteLine($"{car.Manufacturer}, {car.Color}, MaxSpeed: {car.MaxSpeed}, Passengers: {car.Passengers}");
            }
            Console.WriteLine();

            // 5. Створити перелік продуктів Product та вибрати продукти, які закінчилися
            Console.WriteLine("\t\t5. Створити перелік продуктів Product та вибрати продукти, які закінчилися");
            List<Product> products = new List<Product>
            {
                new Product { Name = "Apple", Stock = 0, Description = "Fresh red apple" },
                new Product { Name = "Banana", Stock = 5, Description = "Ripe bananas" },
                new Product { Name = "Orange", Stock = 0, Description = "Juicy orange" }
            };


            var outOfStockProducts = from product in products
                                     where product.Stock == 0
                                     select product;
            Console.WriteLine("Усі продукти:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, Stock: {product.Stock}, Description: {product.Description}");
            }
            Console.WriteLine();

            Console.WriteLine("Продукти, які закінчилися:");
            foreach (var product in outOfStockProducts)
            {
                Console.WriteLine($"{product.Name}, Stock: {product.Stock}, Description: {product.Description}");
            }
            Console.WriteLine();

            // 6. Спільні елементи списків myCars та yourCars
            Console.WriteLine("\t\t6. Спільні елементи списків myCars та yourCars");
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var commonCars = from myCar in myCars
                             join yourCar in yourCars on myCar equals yourCar
                             select myCar;
            Console.WriteLine($"My cars: {string.Join(", ", myCars)}");
            Console.WriteLine($"Your cars: {string.Join(", ", yourCars)}");
            Console.WriteLine();
            Console.WriteLine("Спільні автомобілі з myCars і yourCars:");
            foreach (var car in commonCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

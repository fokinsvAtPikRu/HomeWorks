namespace Lesson15
{
    class Program
    {
        public static void Main()
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer("PC001", "Dell", "Intel Core i5", 2.4, 8, 512, 2, 45000, 5),
                new Computer("PC002", "HP", "Intel Core i7", 3.2, 16, 1024, 4, 67000, 3),
                new Computer("PC003", "Lenovo", "AMD Ryzen 5", 3.6, 8, 256, 2, 38000, 7),
                new Computer("PC004", "Asus", "Intel Core i9", 4.0, 32, 2048, 8, 125000, 2),
                new Computer("PC005", "Acer", "AMD Ryzen 7", 3.8, 16, 512, 6, 78000, 4),
                new Computer("PC006", "Apple", "M1 Pro", 3.2, 16, 512, 8, 145000, 6),
                new Computer("PC007", "MSI", "Intel Core i3", 2.0, 4, 128, 1, 25000, 10),
                new Computer("PC008", "Samsung", "Intel Core i5", 2.8, 8, 256, 2, 42000, 35)
            };
            MainMenu(computers);
        }
        private static void PrintList<T>(List<T> list)
        {
            if (list.Count > 0)
            {
                foreach (var item in list)
                    Console.WriteLine($"{item.ToString()}");
            }
            else
                Console.WriteLine("Ничего не найдено");
        }
        private static void MainMenu(List<Computer> computers)
        {
            int n = -1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Выбрать компьютеры по типу процессора.");
                Console.WriteLine("2. Выбрать компьютеры по объему ОЗУ.");
                Console.WriteLine("3. Сортировка по возрастанию цены.");
                Console.WriteLine("4. Группировка по типу процессора.");
                Console.WriteLine("5. Самый дорогой и самый дешевый компьютер.");
                Console.WriteLine("6. Есть ли хоть один компьютер в количестве 30 шт.");
                Console.Write("Введите чило от 1 до 6:");
                string input = Console.ReadLine();
                if (CheckInput(input, 6, out n))
                {
                    switch (n)
                    {
                        case 1:
                            Menu1(computers);
                            break;
                        case 2:
                            Menu2(computers);
                            break;
                        case 3:
                            Menu3(computers);
                            break;
                        case 4:
                            Menu4(computers);
                            break;
                        case 5:
                            Menu5(computers);
                            break;
                        case 6:
                            Menu6(computers);
                            break;
                    }
                }
            }
        }
        private static bool CheckInput(string input, int maxValue, out int n)
        {
            n = -1;
            if (string.IsNullOrWhiteSpace(input))
                return false;
            if (!int.TryParse(input, out int number))
                return false;
            n = Convert.ToInt32(input);
            return number >= 1 && number <= maxValue;
        }
        private static void Menu1(List<Computer> computers)
        {
            // список типов имеющихся процессоров
            var processorTypes = (from computer in computers
                                  select computer.ProcessorType)
                               .Distinct()
                               .ToList();
            // индекс выбранного пользователем процессора
            int n = -1;
            // запрашиваем пользователя ввести номер типа процессора пока не введет правильное значение
            do
            {
                Console.Clear();
                Console.WriteLine("Выберете тип процессора:");
                var i = 1;
                foreach (var processorType in processorTypes)
                    Console.WriteLine($"{i++}. {processorType.ToString()}");
                Console.Write($"Введите число от 1 до {i - 1}:");
                string input = Console.ReadLine();

                if (CheckInput(input, int.MaxValue, out n))
                    break;
                else
                    continue;

            } while (true);
            // список компьютеров с заданным типом процессора
            var computersSelected = (from computer in computers
                                     where computer.ProcessorType == processorTypes[n - 1]
                                     select computer)
                                    .ToList();
            PrintList<Computer>(computersSelected);
            Console.ReadKey();
        }
        private static void Menu2(List<Computer> computers)
        {
            int n = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите минимально допустимый объем ОЗУ:");
                string input = Console.ReadLine();
                if (CheckInput(input, int.MaxValue, out n))
                    break;
                else
                    continue;
            } while (true);
            var computersSelected = (from computer in computers
                                     where computer.RamSize >= n
                                     select computer)
                                    .ToList();
            PrintList<Computer>(computersSelected);
            Console.ReadKey();
        }
        private static void Menu3(List<Computer> computers)
        {
            Console.Clear();
            var computersOrdered = (from computer in computers
                                    orderby computer.Price
                                    select computer)
                                   .ToList();
            Console.WriteLine("Сортировка по возрастанию цены");
            PrintList<Computer>(computersOrdered);
            Console.ReadKey();
        }
        public static void Menu4(List<Computer> computers)
        {
            Console.Clear();
            var computersGrouped = from computer in computers
                                   group computer by computer.ProcessorType;
            foreach (var group in computersGrouped)
            {
                Console.WriteLine($"Тип процессора - {group.Key}");
                foreach (var computer in group)
                {
                    Console.WriteLine(computer.ToString());
                }
            }
            Console.ReadKey();
        }
        public static void Menu5(List<Computer> computers)
        {
            Console.Clear();
            var computersOrdered = (from computer in computers
                                    orderby computer.Price
                                    select computer)
                                   .ToList();
            Console.WriteLine("Самый дешевый компьютер:");
            Console.WriteLine(computersOrdered.First().ToString());
            Console.WriteLine("Самый дорогой компьютер:");
            Console.WriteLine(computersOrdered.Last().ToString());
            Console.ReadKey();
        }
        public static void Menu6(List<Computer> computers)
        {
            Console.Clear();
            bool hasAtLeastThirtyComputers = computers.Any(x => x.Quantity >= 30);
            Console.WriteLine($"есть ли хотя бы один компьютер в количестве не менее 30 штук: {hasAtLeastThirtyComputers}");
            Console.ReadKey();
        }
    }
}

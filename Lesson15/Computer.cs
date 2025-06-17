namespace Lesson15
{
    public class Computer
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public double ProcessorFrequency { get; set; } // GHz
        public int RamSize { get; set; } // GB
        public int HddSize { get; set; } // GB
        public int VideoCardMemory { get; set; } // GB
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Computer(string code, string brand, string processorType, double processorFrequency,
                       int ramSize, int hddSize, int videoCardMemory, decimal price, int quantity)
        {
            Code = code;
            Brand = brand;
            ProcessorType = processorType;
            ProcessorFrequency = processorFrequency;
            RamSize = ramSize;
            HddSize = hddSize;
            VideoCardMemory = videoCardMemory;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Код: {Code}, Марка: {Brand}, Процессор: {ProcessorType} {ProcessorFrequency}GHz, " +
                   $"ОЗУ: {RamSize}GB, HDD: {HddSize}GB, Видеокарта: {VideoCardMemory}GB, " +
                   $"Цена: {Price} у.е., Количество: {Quantity}";
        }
    }
}


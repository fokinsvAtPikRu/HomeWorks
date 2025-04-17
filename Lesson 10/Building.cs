namespace Lesson_10
{
    internal class Building
    {
        private protected string _address;
        private protected double _area;
        private protected int _yaerBuilt;
        public int BuildingAge
        { get => System.DateTime.Now.Year - _yaerBuilt; }
        public Building(string address, double area, int yaerBuilt)
        {
            _address = address;
            _area = area;
            _yaerBuilt = yaerBuilt;
        }
        public virtual double CalculateTax() => _area * 1000;
        public virtual string DisplayInfo() =>
            $"Адресс: {_address}, площадь: {_area.ToString()}, год постройки: {_yaerBuilt}";
        public virtual string WhoAmI() => "I am Building";
    }

}

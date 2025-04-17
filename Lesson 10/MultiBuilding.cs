namespace Lesson_10
{
    internal sealed class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;
        public double AreaPerFloor
        {
            get => _area / _floors;
        }
        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }
        public override double CalculateTax() =>
            _hasElevator
            ? base.CalculateTax() * (1 + (_floors - 1) * 0.05) + 5000
            : base.CalculateTax() * (1 + (_floors - 1) * 0.05);
        public override string DisplayInfo()
        {
            string elevatorInfo = _hasElevator ? "есть" : "нет";
            string info = $", количество этажей: {_floors}, Лифт {elevatorInfo} ";
            return base.DisplayInfo() + info;
        }
        public override string WhoAmI() => "I am the MultiBuilding";
    }
}

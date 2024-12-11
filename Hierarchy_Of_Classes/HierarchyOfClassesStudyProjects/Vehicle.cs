namespace HierarchyOfClasses
{
    public class Vehicle : Property
    {
        private int _engineDisplacement;

        public Vehicle(int worth, int engineDisplacement) : base(worth)
        {
            _engineDisplacement = engineDisplacement;
        }

        public override int Tax()
        {
            return _worth * _engineDisplacement / 3000;
        }

        public override string ToString()
        {
            return $"Стоимость - {_worth}, налог - {Tax()}, объём двигателя - {_engineDisplacement} см.куб";
        }
    }
}

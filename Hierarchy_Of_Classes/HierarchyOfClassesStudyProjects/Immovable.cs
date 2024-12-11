namespace HierarchyOfClasses
{
    public class Immovable : Property
    {
        private int _area;

        public Immovable(int worth, int area) : base(worth)
        {
            _area = area;
        }

        public override int Tax()
        {
            if (_area < 100)
            {
                return _worth / 500;
            }
            else if (_area < 300)
            {
                return _worth / 350;
            }
            else
            {
                return _worth / 250;
            }

        }

        public int WorthOfSquereMeter()
        {
            return _worth / _area;
        }

        public override string ToString()
        {
            return $"Стоимость - {_worth}, налог - {Tax()}, площадь - {_area} кв.м";
        }
    }
}

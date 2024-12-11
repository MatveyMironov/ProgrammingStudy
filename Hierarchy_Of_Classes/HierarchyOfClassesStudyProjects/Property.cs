namespace HierarchyOfClasses
{
    public abstract class Property
    {
        protected int _worth;

        public Property(int worth)
        {
            _worth = worth;
        }

        public abstract int Tax();
    }
}

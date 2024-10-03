namespace MockTest_NUnit
{
    public class NumberProcessor
    {
        private INumberService _numberService;

        public NumberProcessor(INumberService numberService)
        {
            _numberService = numberService;
        }

        public int CalculateSum()
        {
            int sum = 0;
            foreach (int value in _numberService.Ints())
            {
                sum += value;
            }
            return sum;
        }

        public int CalculateAverage()
        {
            int count = _numberService.Ints().Length;

            if (count > 0)
            {
                int sum = CalculateSum();
                int average = sum / count;
                return average;
            }

            return 0;
        }
    }
}

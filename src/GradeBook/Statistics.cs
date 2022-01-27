namespace GradeBook
{
    public class Statistics
    {
        public Statistics()
        {
            High = double.MinValue;
            Low = double.MaxValue;
            Sum = 0.0;
            count = 0;
        }

        public void add(double number)
        {
            Sum += number;
            count += 1;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

        public double Average
        {
            get
            {
                return Sum / count;
            }
        }
        public double High;
        public double Low;
        public char letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                        
                    case var d when d >= 80.0:
                        return 'B';
                        
                    case var d when d >= 70.0:
                        return 'C';
                        
                    case var d when d >= 60.0:
                        return 'D';
                        
                    default:
                        return 'F';
                        
                }
            }
        }
        public double Sum;
        public int count;
    }
}
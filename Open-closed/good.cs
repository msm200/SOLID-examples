public OpenClosed{
    public interface User{
        public double getMonthlyRate();
    }

    public class BasicUser implements User
    {
        public String name;
        public double getMonthlyRate()
        {
            return 5;
        }
    }

    public class PremiumUser implements User
    {
        public String name;
        public double getMonthlyRate()
        {
            return 10;
        }
    }

    public class GoldUser implements User
    {
        public String name;
        public double getMonthlyRate()
        {
            return 20;
        }
    }
}
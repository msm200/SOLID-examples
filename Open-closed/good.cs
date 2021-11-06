public OpenClosed{
    public interface User{
        public double getMonthlyRate();
    }

    public class BasicUser : User
    {
        public String name;
        public double getMonthlyRate()
        {
            return 5;
        }
    }

    public class PremiumUser : User
    {
        public String name;
        public double getMonthlyRate()
        {
            return 10;
        }
    }

    public class GoldUser : User
    {
        public String name;
        public double getMonthlyRate()
        {
            return 20;
        }
    }
}
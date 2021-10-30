public OpenClosed{
    public enum Membership
    {
        Basic = 1,
        Premium = 2,
        Gold = 3
    }
    public class User
    {
        public String name;
        public Membership membership;
        public double getMonthlyRate()
        {
            switch(membership)
            {
                case Basic:
                    return 5;
                case Premium:
                    return 10;
                case Gold:
                    return 20;
            }
        }
    }
}
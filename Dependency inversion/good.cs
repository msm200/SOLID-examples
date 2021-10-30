public class DependencyInversion
{
    public interface DatabaseAccess
    {
        public String getCustomerName(int ID);
    }
    public class SQLDatabaseAccess
    {
        public String getCustomerName(int ID)
        {
            /*
            SQL access logic
            */
            return "";
        }
    }
    public class CustomerRetrieval
    {
        private DatabaseAccess accessor;
        public CustomerRetrieval(DatabaseAccess accessor)
        {
            this.accessor = accessor;
        }
        public String getCustomerName(int ID)
        {
            SQLDatabaseAccess accessor = new SQLDatabaseAccess();
            return accessor.getCustomerName(ID);
        }
    }
}
public class DependencyInversion
{
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
        private SQLDatabaseAccess accessor;
        public CustomerRetrieval(SQLDatabaseAccess accessor)
        {
            this.accessor = accessor;
        }
        public String getCustomerName(int ID)
        {
            return accessor.getCustomerName(ID);
        }
    }
}
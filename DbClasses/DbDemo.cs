
namespace DbClasses
{
    public class DbDemo
    {
        public static void ExecuteDemo()
        {
            var dbCommand = new DbCommand("Add more data.", new OracleConnection("DataSource=(LocalDb)..."));
            var anotherDbCommand = new DbCommand("Remove data.", new SqlConnection("DataSource=(AnotherLocalDb)..."));
            dbCommand.Execute();
            anotherDbCommand.Execute();
        }
    }
}

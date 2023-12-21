namespace DbClasses
{
    public class DbCommand
    {
        private readonly string _instruction;
        private readonly DbConnection _dbConnection;

        public DbCommand(string instruction, DbConnection dbConnection)
        {
            if (string.IsNullOrEmpty(instruction))
            {
                throw new InvalidOperationException("Instruction required.");
            }

            _instruction = instruction;
            _dbConnection = dbConnection ?? throw new InvalidOperationException("DBConnection required.");
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Running the instruction: " + _instruction);
            _dbConnection.CloseConnection();
        }
    }
}

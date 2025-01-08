using _.Models;

namespace _.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "How to do", Platform = "inline", Line = "this is" },
                new Command { Id = 1, HowTo = "How to do1", Platform = "inline", Line = "this is1" },
                new Command { Id = 2, HowTo = "How to do2", Platform = "inline", Line = "this is2" },
            };

            return commands;
        }

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = id, HowTo = "How to do846235", Platform = "inline", Line = "this is" };
        }
    }
}
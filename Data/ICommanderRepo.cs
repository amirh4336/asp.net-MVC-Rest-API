using _.Models;

namespace _.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        Command GetCommandById(int id);
        IEnumerable<Command> GetAllCommands();
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}
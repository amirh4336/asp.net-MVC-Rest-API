using _.Models;

namespace _.Data
{
    public interface ICommanderRepo
    {
        Command GetCommandById(int id);
        IEnumerable<Command> GetAppCommands();
    }
}
using _.Models;

namespace _.Data;

public class SqlCommanderRepo(CommanderContext context) : ICommanderRepo
{
    public Command GetCommandById(int id)
    {
        return context.Commands.FirstOrDefault(p => p.Id == id);
    }

    public IEnumerable<Command> GetAllCommands()
    {
        return context.Commands.ToList();
    }
}
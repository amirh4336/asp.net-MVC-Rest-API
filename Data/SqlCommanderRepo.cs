using _.Models;

namespace _.Data;

public class SqlCommanderRepo(CommanderContext context) : ICommanderRepo
{
    public bool SaveChanges()
    {
        return (context.SaveChanges() >= 0 );
    }

    public Command GetCommandById(int id)
    {
        return context.Commands.FirstOrDefault(p => p.Id == id)!;
    }

    public IEnumerable<Command> GetAllCommands()
    {
        return context.Commands.ToList();
    }

    public void CreateCommand(Command cmd)
    {
        ArgumentNullException.ThrowIfNull(cmd);

        context.Commands.Add(cmd);
    }
}
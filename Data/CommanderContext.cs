using _.Models;
using Microsoft.EntityFrameworkCore;

namespace _.Data;

public class CommanderContext(DbContextOptions<CommanderContext> options) : DbContext(options)
{
    public DbSet<Command> Commands { get; set; }
}
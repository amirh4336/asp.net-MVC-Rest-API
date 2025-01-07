using _.Dto;
using _.Models;
using AutoMapper;

namespace _.Profiles;

public class CommandsProfile : Profile
{
    public CommandsProfile()
    {
        // Source --> target
        CreateMap<Command, CommandReadDto>();
        CreateMap<CommandCreateDto, Command>();
        CreateMap<CommandUpdateDto, Command>();
    }
}
using _.Dto;
using _.Models;
using AutoMapper;

namespace _.Profiles;

public class CommandsProfile : Profile
{
    public CommandsProfile()
    {
        CreateMap<Command, CommandReadDto>();
    }
}
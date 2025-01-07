using _.Data;
using _.Dto;
using _.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _.Controllers
{
    // api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController(ICommanderRepo repository, IMapper mapper) : ControllerBase
    {
        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandsItem = repository.GetAllCommands();

            return Ok(mapper.Map<IEnumerable<CommandReadDto>>(commandsItem));
        }

        //GET api/commands/{id}
        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var commandItem = repository.GetCommandById(id);
            if (commandItem != null) return Ok(mapper.Map<CommandReadDto>(commandItem));
            return NotFound();
        }

        //POST api/commands
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = mapper.Map<Command>(commandCreateDto);
            repository.CreateCommand(commandModel);
            repository.SaveChanges();

            var commandReadDto = mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById)
                , new { Id = commandReadDto.Id }, commandReadDto);
        }
    }
}
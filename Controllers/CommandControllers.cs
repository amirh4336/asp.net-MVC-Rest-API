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
    public class CommandsController(ICommanderRepo repository , IMapper mapper) : ControllerBase
    {

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandsItem = repository.GetAllCommands();

            return Ok(mapper.Map<IEnumerable<CommandReadDto>>(commandsItem));
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var commandItem = repository.GetCommandById(id);
            if (commandItem != null) return Ok(mapper.Map<CommandReadDto>(commandItem));
            return NotFound();
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuRay.API.Models;
using RuRay.BLL;
using Swashbuckle.AspNetCore.Annotations;

namespace RuRay.API.Controllers
{
    /// <summary>
    /// Defines the <see cref="TodoController" />.
    /// </summary>
    [Authorize]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/todos")]
    [ApiVersion("1.0")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Defines the _todosMockService.
        /// </summary>
        private readonly TodosMockProxyService _todosMockService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TodoController"/> class.
        /// </summary>
        /// <param name="mapper">.</param>
        /// <param name="todosMockService">.</param>
        public TodoController(IMapper mapper, TodosMockProxyService todosMockService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _todosMockService = todosMockService ?? throw new ArgumentNullException(nameof(todosMockService));
        }

        /// <summary>
        /// Get todo by id.
        /// </summary>
        /// <param name="id">Todo id.</param>
        /// <returns>.</returns>
        [HttpGet("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Description = "Missing todo object")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GetTodoById([FromRoute] int id)
        {
            var result = await _todosMockService.GetTodoById(id);
            if (result == null)
            {
                return NotFound(null);
            }
            return Ok(_mapper.Map<Todo>(result));
        }

        /// <summary>
        /// Get todos list from remote mock api.
        /// </summary>
        /// <returns>.</returns>
        [HttpGet("")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<Todo>), Description = "Returns todos array")]
        [SwaggerResponse((int)HttpStatusCode.NoContent, Description = "Missing todos array")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GetTodos()
        {
            var result = await _todosMockService.GetTodos();
            if (result == null)
            {
                return NoContent();
            }
            return Ok(_mapper.Map<IEnumerable<Todo>>(result));
        }
    }
}

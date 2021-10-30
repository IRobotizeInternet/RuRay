using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuRay.BLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuRay.API.Controllers.Pages
{
    /// <summary>
    /// Defines the <see cref="HomePageController" />.
    /// </summary>
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/HomeHeader")]
    [ApiVersion("1.0")]
    [ApiController]
    public class HomePageController : Controller
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Defines the _serviceHomePage.
        /// </summary>
        private readonly IServiceHomePage _serviceHomePage;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePageController"/> class.
        /// </summary>
        /// <param name="mapper">.</param>
        /// <param name="serviceHomePage">.</param>
        public HomePageController(IMapper mapper, IServiceHomePage serviceHomePage)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceHomePage = serviceHomePage ?? throw new ArgumentNullException(nameof(serviceHomePage));
        }


    }
}

using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuRay.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;

namespace RuRay.API.Controllers
{
    /// <summary>
    /// Defines the <see cref="NavigationController" />.
    /// </summary>
    [AllowAnonymous]
    [Route("api/v{version:apiVersion}/Navigation")]
    [ApiVersion("1.0")]
    [ApiController]
    public class NavigationController : ControllerBase
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Defines the _serviceNavigation.
        /// </summary>
        private readonly IServiceNavigation _serviceNavigation;

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper<see cref="IMapper"/>.</param>
        /// <param name="serviceNavigation">The serviceNavigation<see cref="IServiceNavigation"/>.</param>
        public NavigationController(IMapper mapper, IServiceNavigation serviceNavigation)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _serviceNavigation = serviceNavigation ?? throw new ArgumentNullException(nameof(serviceNavigation));
        }

        /// <summary>
        /// The NavigateActivityLog.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("ActivityLog")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateActivityLog()
        {
            await _serviceNavigation.NavigateActivityLog(); return Ok();
        }

        /// <summary>
        /// The NavigateAdCenter.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("AdCenter")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateAdCenter()
        {
            await _serviceNavigation.NavigateAdCenter(); return Ok();
        }

        /// <summary>
        /// The NavigateAdPreferences.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("AdPreferences")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateAdPreferences()
        {
            await _serviceNavigation.NavigateAdPreferences(); return Ok();
        }

        /// <summary>
        /// The NavigateArchived.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Archived")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateArchived()
        {
            await _serviceNavigation.NavigateArchived(); return Ok();
        }

        /// <summary>
        /// The NavigateCampus.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Campus")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateCampus()
        {
            await _serviceNavigation.NavigateCampus(); return Ok();
        }

        /// <summary>
        /// The NavigateChats.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Chats")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateChats()
        {
            await _serviceNavigation.NavigateChats(); return Ok();
        }

        /// <summary>
        /// The NavigateEvents.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Events")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateEvents()
        {
            await _serviceNavigation.NavigateEvents(); return Ok();
        }

        /// <summary>
        /// The NavigateFacebookPay.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("FacebookPay")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateFacebookPay()
        {
            await _serviceNavigation.NavigateFacebookPay(); return Ok();
        }

        /// <summary>
        /// The NavigateFriends.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Friends")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateFriends()
        {
            await _serviceNavigation.NavigateFriends(); return Ok();
        }

        /// <summary>
        /// The NavigateFundraisers.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Fundraisers")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateFundraisers()
        {
            await _serviceNavigation.NavigateFundraisers(); return Ok();
        }

        /// <summary>
        /// The NavigateGames.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Games")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateGames()
        {
            await _serviceNavigation.NavigateGames(); return Ok();
        }

        /// <summary>
        /// The NavigateGroup.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Group")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateGroup()
        {
            await _serviceNavigation.NavigateGroup(); return Ok();
        }

        /// <summary>
        /// The NavigateGroupCall.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("GroupCall")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateGroupCall()
        {
            await _serviceNavigation.NavigateGroupCall(); return Ok();
        }

        /// <summary>
        /// The NavigateHome.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Home")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateHome()
        {
            await _serviceNavigation.NavigateHome(); return Ok();
        }

        /// <summary>
        /// The NavigateJobs.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Jobs")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateJobs()
        {
            await _serviceNavigation.NavigateJobs(); return Ok();
        }

        /// <summary>
        /// The NavigateLiveProducer.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("LiveProducer")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateLiveProducer()
        {
            await _serviceNavigation.NavigateLiveProducer(); return Ok();
        }

        /// <summary>
        /// The NavigateMarketplace.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Marketplace")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateMarketplace()
        {
            await _serviceNavigation.NavigateMarketplace(); return Ok();
        }

        /// <summary>
        /// The NavigateMemories.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Memories")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateMemories()
        {
            await _serviceNavigation.NavigateMemories(); return Ok();
        }

        /// <summary>
        /// The NavigateMessages.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Messages")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateMessages()
        {
            await _serviceNavigation.NavigateMessages(); return Ok();
        }

        /// <summary>
        /// The NavigateMessengerKids.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("MessengerKids")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateMessengerKids()
        {
            await _serviceNavigation.NavigateMessengerKids(); return Ok();
        }

        /// <summary>
        /// The NavigateMovies.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Movies")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateMovies()
        {
            await _serviceNavigation.NavigateMovies(); return Ok();
        }

        /// <summary>
        /// The NavigateNotifications.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Notifications")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateNotifications()
        {
            await _serviceNavigation.NavigateNotifications(); return Ok();
        }

        /// <summary>
        /// The NavigateOffers.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Offers")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateOffers()
        {
            await _serviceNavigation.NavigateOffers(); return Ok();
        }

        /// <summary>
        /// The NavigatePages.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Pages")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigatePages()
        {
            await _serviceNavigation.NavigatePages(); return Ok();
        }

        /// <summary>
        /// The NavigatePrivacyCheckup.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("PrivacyCheckup")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigatePrivacyCheckup()
        {
            await _serviceNavigation.NavigatePrivacyCheckup(); return Ok();
        }

        /// <summary>
        /// The NavigatePromote.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Promote")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigatePromote()
        {
            await _serviceNavigation.NavigatePromote(); return Ok();
        }

        /// <summary>
        /// The NavigateSaved.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Saved")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateSaved()
        {
            await _serviceNavigation.NavigateSaved(); return Ok();
        }

        /// <summary>
        /// The NavigateSettings.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Settings")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateSettings()
        {
            await _serviceNavigation.NavigateSettings(); return Ok();
        }

        /// <summary>
        /// The NavigateStories.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Stories")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateStories()
        {
            await _serviceNavigation.NavigateStories(); return Ok();
        }

        /// <summary>
        /// The NavigateSupportInbox.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("SupportInbox")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateSupportInbox()
        {
            await _serviceNavigation.NavigateSupportInbox(); return Ok();
        }

        /// <summary>
        /// The NavigateTrash.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Trash")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateTrash()
        {
            await _serviceNavigation.NavigateTrash(); return Ok();
        }

        /// <summary>
        /// The NavigateUserTimeline.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("UserTimeline")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateUserTimeline()
        {
            await _serviceNavigation.NavigateUserTimeline(); return Ok();
        }

        /// <summary>
        /// The NavigateViewPage.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("ViewPage")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateViewPage()
        {
            await _serviceNavigation.NavigateViewPage(); return Ok();
        }

        /// <summary>
        /// The NavigateWatch.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Watch")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateWatch()
        {
            await _serviceNavigation.NavigateWatch(); return Ok();
        }

        /// <summary>
        /// The NavigateWeather.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost("Weather")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Page Not Found")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> NavigateWeather()
        {
            await _serviceNavigation.NavigateWeather(); return Ok();
        }
    }
}

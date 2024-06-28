using Microsoft.AspNetCore.Mvc;
using AirportTicketBookingSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AirportTicketBookingSystem.Core.Entities;

namespace AirportTicketBookingSystem.API.Controllers
{
    [Route("api/manager/")]
    [ApiController]
    public class ManagersController : ControllerBase
    {
        private readonly IManagerService _managerService;
        public ManagersController(IManagerService managerService)
        {
            _managerService = managerService;
        }

        [HttpGet("flights")]
        public async Task<IActionResult> GetFlightsForManager(int managerId)
        {
            var flights = await _managerService.GetFlightsForManagerAsync(managerId);
            return Ok(flights);
        }

         
    }
}

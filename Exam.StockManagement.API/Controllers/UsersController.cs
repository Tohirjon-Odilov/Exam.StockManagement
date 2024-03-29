﻿using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Exam.StockManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetAllUsers()
        {
            var result = await _userService.GetAll();

            return Ok(result);
        }
    }
}

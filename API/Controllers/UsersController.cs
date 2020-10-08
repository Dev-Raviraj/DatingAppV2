using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly IUserRepository _UserRepository;
        public UsersController(IUserRepository UserRepository, IMapper mapper)
        {
            _mapper = mapper;
            _UserRepository = UserRepository;

        }
        //Get all user

        [HttpGet]

        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var user = await _UserRepository.GetMembersAsync();
            return Ok(user);
        }
        // Get user by Id

        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
             return await _UserRepository.GetMemberAsync(username);
           
        }


    }
}
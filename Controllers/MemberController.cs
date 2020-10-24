using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HealthEquity.Data.Entity;
using HealthEquity.Data.Repository;
using HealthEquity.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthEquity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IRepositoryMember _repositoryMember;
        private readonly IMapper _mapper;
        public MemberController(IRepositoryMember repositoryMember, IMapper mapper)
        {
            _repositoryMember = repositoryMember;
            _mapper = mapper;

        }
      

        // GET api/<MemberController>/5
        [HttpGet("Contact/{MemberId:int}")]
        public async Task<ActionResult<MemberModel>> Get(int MemberId)
        {
            var result = await _repositoryMember.GetMemberById(MemberId);
            
            if (result == null) return NotFound();
 
            return _mapper.Map<MemberModel>(result);
        }
      

        // PUT api/<MemberController>/5
        [HttpPut("Contact/{MemberId:int}")]
        public async Task<ActionResult<string>> UpdateMember(int MemberId, MemberModel modifiedMember)
        {
            var result = await _repositoryMember.GetMemberById(MemberId);
            if (result == null) return NotFound();

            //result.FirstName = modifiedMember.FirstName;
            //result.LastName = modifiedMember.LastName;
            //result.PhoneNumber = modifiedMember.PhoneNumber;
            //result.Email = modifiedMember.Email;
            _mapper.Map(modifiedMember, result);
            if (await _repositoryMember.SaveChangesAsync())
            {
                return await Task.FromResult("Update was Successful");
            }
            else
            {
                return BadRequest("Failed to update Member");
            }
            
        }

        
         
    }
}

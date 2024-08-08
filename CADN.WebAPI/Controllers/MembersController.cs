using CADN.Application;
using Microsoft.AspNetCore.Mvc;

//Demo from: https://positiwise.com/blog/clean-architecture-net-core

namespace CADN.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService memberService;

        public MembersController(IMemberService memberService)
        {
            this.memberService = memberService;
        }
        // GET: api/<MembersController>
        [HttpGet]
        public ActionResult<IList<Domain.Member>> Get()
        {
            return Ok(this.memberService.GetAllMembers());
        }
    }
}

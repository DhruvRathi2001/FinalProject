using FinalProject.Model;
using FinalProject.Process;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api")]
    [ApiController]
    public class EnquiryLoginController : Controller
    {
        EnquiryLoginProcess process = new EnquiryLoginProcess();

        [HttpPost(template:"AddEnquirer")]
        public IActionResult CreateEnquirer(EnquiryLogin model)
        {
            try {
                process.CreateEnquirer(model.Email, model.Password);
                return Ok(200);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost(template: "GetEnquirer")]
        public IActionResult GetEnquirer(EnquiryLogin model)
        {
            try
            {
                int id = process.GetEnquirer(model.Email, model.Password);
                if (id <= 0)
                {
                    return BadRequest("User not found");
                }
                else
                {
                    return Ok(id);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

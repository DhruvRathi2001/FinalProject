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
                int id = process.GetEnquirer(model.Email);
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


        [HttpPost(template: "CreateEnquiry")]
        public IActionResult CreateEnquiry(CreateEnquiry model)
        {
            try
            {
               
                int EnqLogId = process.GetEnquirer(model.Email);

                if (EnqLogId > 0)
                {
                    process.CreateEnquiry(
                model.FirstName,
                model.LastName,
                model.Address1,
                model.Address2,
                model.Address3,
                model.PhoneNumber,
                model.Email,
                model.DOB,
                model.City,
                model.Country,
                model.Status,
                model.Pincode,
                model.WantsCheque,
                model.Feedback,
                model.ManagerId,
                model.IsActive,
                model.AccountType,
                EnqLogId,
                model.Balance
                 );
                    return Ok(200);
                }

                return BadRequest("Something went wrong");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

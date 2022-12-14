using Microsoft.AspNetCore.Mvc;
using Web_Api.Models;

namespace Web_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersDetailController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<UsersDetail> Get(string date)
        {
            using (var context = new Task_DBMSContext())
            {
                return context.UsersDetails.Where(userdet => userdet.RegisterDate == DateTime.Parse(date)).ToList();
            }

        }
    }
}
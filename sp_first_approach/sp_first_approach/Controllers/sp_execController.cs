using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sp_first_approach.Models;
using System.Security.Cryptography.X509Certificates;

namespace sp_first_approach.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class sp_execController : ControllerBase
    {

        [HttpGet("{Id}")]
        public async Task<IEnumerable<UsersDetail>> UsersDetails([FromQuery] int Id)
        {
            using (var context = new Task_DBMSContext())
            {   
                var data = await context.UsersDetails.FromSqlInterpolated($"Exec [dbo].[sp_User_Details]@Id = {Id}").ToListAsync();
                return (IEnumerable<UsersDetail>)data;
            }
        }
    }
}
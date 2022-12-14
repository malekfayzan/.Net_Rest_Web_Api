/*using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_sp.Models;

namespace web_api_sp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class userName : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<UserName>> UserName(int id)
        {

            var context = new Task_DBMSContext();
            var data = await context.UserName.FromSqlInterpolated($"Exec [dbo].[sp_user_detail]@id = {id}").ToListAsync();
            return data;

        }
    }
}*/
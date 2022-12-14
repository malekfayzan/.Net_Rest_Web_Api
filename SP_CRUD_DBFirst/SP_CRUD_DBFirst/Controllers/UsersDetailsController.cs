using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SP_CRUD_DBFirst.Models;

namespace SP_CRUD_DBFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersDetailsController : ControllerBase
    {
        private readonly TaskDbmsContext _context;

        public UsersDetailsController(TaskDbmsContext context)
        {
            _context = context;
        }

        // GET: api/UsersDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersDetail>>> GetUsersDetails()
        {
          if (_context.UsersDetails == null)
          {
              return NotFound();
          }
            return await _context.UsersDetails.ToListAsync();
        }
        // PUT: api/UsersDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]

        public async Task<IEnumerable<UsersDetail>> PutUsersDetail(int id,UsersDetail getData)
        {
            var data = await _context.UsersDetails.FromSqlInterpolated($"Exec [dbo].[sp_update_UserDetail]@id = {id} , @salary = {getData.Salary}").ToListAsync();
            return data;
        }

      
        // POST: api/UsersDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IEnumerable<UsersDetail>> PostUsersDetail(UsersDetail user_Details)
        {
            var data = await _context.UsersDetails.FromSqlInterpolated($"Exec [dbo].[sp_insert_update_user_details]@FirstName = {user_Details.FirstName},@LastName = {user_Details.LastName},@RegisterDate = {user_Details.RegisterDate},@DateOfBirth = {user_Details.DateOfBirth},@Email = {user_Details.Email},@DepartmentId = {user_Details.DepartmentId},@Salary = {user_Details.Salary},@@UserProofId = {user_Details.UserProofId},@UserProofStatus={user_Details.UserProofStatus},@IsActive={user_Details.IsActive},@IsDeleted={user_Details.IsDeleted}").ToListAsync();
           
            
            return data;
        }
       

        // DELETE: api/UsersDetails/5
        [HttpDelete("{id}")]
        public async Task<IEnumerable<UsersDetail>> DeleteUsersDetail(int id)
        {
            var data = await _context.UsersDetails.FromSqlInterpolated($"Exec [dbo].[sp_Delete_user_details]@id = {id}").ToListAsync();
            return data;
        }
      
        private bool UsersDetailExists(int id)
        {
            return (_context.UsersDetails?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}



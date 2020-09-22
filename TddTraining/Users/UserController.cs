using System;
using Microsoft.AspNetCore.Mvc;

namespace TddTraining.Users
{
    public class UserController : ControllerBase
    {
        public IActionResult GetUserBy(int id)
        {
            // Returns a UserResponse
            throw new NotImplementedException();
        }

        public IActionResult SaveUser(SaveUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

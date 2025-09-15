using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Infrastructure.ViewModel
{
    public class LoginDTO
    {
        public class LoginRequest
        {
            public string Name { get; set; }
            public string Password { get; set; }
        }

        public class LoginResultDto
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public int UserKey { get; set; }
        }
    }
}

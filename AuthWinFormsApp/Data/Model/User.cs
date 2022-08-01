using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuthWinFormsApp.Data.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public DateTime? LastEntered { get; set; }
        public Boolean IsLocked { get; set; } = false;
        public Activation Activation { get; set; } = new Activation();
        public Boolean IsRestorePassword { get; set; } = false;
        public List<Session> Sessions { get; set; } = new List<Session>();
        public int Role { get; set; }
        public Profile Profile { get; set; } = new Profile();
        public string Email { get; set; } = String.Empty;
    }
}

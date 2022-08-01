using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthWinFormsApp.Data.Model
{
    internal class Session
    {
        public int Id { get; set; }
        public DateTime Begin { get; set; }
        public DateTime? End { get; set; }
        public string Token { get; set; } = String.Empty;
    }
}

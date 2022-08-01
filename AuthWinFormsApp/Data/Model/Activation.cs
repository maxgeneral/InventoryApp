using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthWinFormsApp.Data.Model
{
    internal class Activation
    {
        public int Id { get; set; }
        public DateTime SendCode { get; set; }
        public string Code { get; set; } = String.Empty;
        public DateTime? EnterCode { get; set; }
        public bool IsFail { get; set; } = false;
    }
}

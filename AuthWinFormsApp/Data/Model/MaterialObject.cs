using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthWinFormsApp.Data.Model
{
    internal class MaterialObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string InventoryNumber { get; set; } = String.Empty;
    }
}

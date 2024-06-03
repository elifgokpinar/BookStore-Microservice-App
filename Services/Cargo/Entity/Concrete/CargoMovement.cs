using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CargoMovement
    {
        public long Id { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

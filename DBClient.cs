using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Страховая
{
    class DBClient
    {
        public decimal Passport { get; set; }
        public string F { get; set; }
        public string I { get; set; }
        public string O { get; set; }
        public DateTime DR { get; set; }
        public virtual DBAvto DBAvto { get; set; }
    }
}

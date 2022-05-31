using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Страховая
{
    class DBAvto
    {
        public string GosNum { get; set; }
        public string Categ { get; set; }
        public string Marka_avto { get; set; }
        public string Model { get; set; }
        public int God_avto { get; set; }
        public int Power { get; set; }
        public string VIN { get; set; }
        public string PTS { get; set; }
        public string Data_Vidachi { get; set; }
        public decimal Passport { get; set; }
        public virtual ICollection<DBClient> DBClients { get; private set; } = new ObservableCollection<DBClient>();

    }
}

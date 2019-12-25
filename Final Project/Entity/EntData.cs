using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entity {
    class EntData {
        public List<EntPelapor> dataPelapor { get; set; }
        public List<EntBarang> dataBarang { get; set; }

        public List<EntPenemu> dataPenemu { get; set; }
        public List<EntRuang> dataRuang { get; set; }
        public List<EntLokasi> dataLokasi { get; set; }
    }
}

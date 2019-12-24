using Final_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Interface {
    interface IntPelaporan {
        bool InsertData(EntPelapor e, EntLokasi loc);
        bool UpdateData(EntPelapor e);
        bool DeleteData(String[] id);
    }
}

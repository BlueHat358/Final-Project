using Final_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Interface {
    interface IntPenemu {
        Boolean InsertData(EntPenemu p, EntLokasi loc, EntRuang r, EntBarang b);
        Boolean UpdateData(EntRuang r);
        Boolean DeleteData(String id);
        bool Search(String nama);
    }
}

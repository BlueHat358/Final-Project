﻿using Final_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Interface {
    interface IntPenemu {
        Boolean InsertData(EntPenemu p, EntLokasi loc, EntRuang r, EntBarang b);
        Boolean UpdateData(EntBarang b, EntPenemu pen, EntPelapor p);
        Boolean DeleteData(String[] id);
        EntData Search(String nama);
    }
}

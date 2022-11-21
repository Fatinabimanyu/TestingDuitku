using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duitku
{
    class sisa
    {
        private int _duitAkhir; 

        public int duitAkhir
        {
            get { return _duitAkhir;}
        }

        public int duitSisa(int duitAkhir)
        {
            pemasukan n = new pemasukan();
            tabungan p = new tabungan();
            pengeluaran k = new pengeluaran();
            int sisa = n.duitAwal - p.duitTabung - k.duitKeluar;
            return sisa;
        }
    }
}

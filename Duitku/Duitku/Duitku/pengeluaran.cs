using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duitku
{
    class pengeluaran
    {
        private int _duitKeluar;

        public int duitKeluar
        {
            get { return _duitKeluar;}
            set { _duitKeluar = value;}
        }

        public Boolean duitOut(int duitAwal)
        {
            return true; 
        }
    }
}

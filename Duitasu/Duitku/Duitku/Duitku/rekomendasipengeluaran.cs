using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duitku
{
    class rekomendasipengeluaran
    {
        private int _duitRec;

        public int duitRec
        {
            get { return _duitRec; }
            set { _duitRec = value; }
        }

        public int reccomendation(int masuk, int tabung, int jawaktu)
        {
            int duitRec;
            pemasukan n = new pemasukan();
            n.duitAwal = masuk;
            tabungan m = new tabungan();
            m.duitTabung = tabung;
            jangkawaktu k = new jangkawaktu();
            k.waktuDuit = jawaktu;
            duitRec = ((masuk - tabung) / jawaktu);
            return duitRec;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod04_103022300058
{
    class KodePos
    {
        public enum Kelurahan {Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja }

        // Method untuk mendapatkan kode pos berdasarkan kelurahan
        public static string GetKodePos(Kelurahan kelurahan)
        {
            // Table-driven menggunakan array untuk kode pos
            string[] kodePos = {"40266", "40287","40267","40256", "40287","40286","40286","40286","40272","40274","40273"
        };

            return kodePos[(int)kelurahan];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpmod04_103022300058;


class Program
    {
    static void Main(){
        Console.WriteLine("Soal 1. Daftar kelurahan");
        foreach (KodePos.Kelurahan kelurahan in Enum.GetValues(typeof(KodePos.Kelurahan)))
        {
            string kodePos = KodePos.GetKodePos(kelurahan);
            Console.WriteLine("- " + kelurahan + ": " + kodePos);
            
        }

        Console.WriteLine("\nSoal 2. Door Machine ");

        DoorMachine doorMachine = new DoorMachine();
        doorMachine.Jalankan();
    }

}

   

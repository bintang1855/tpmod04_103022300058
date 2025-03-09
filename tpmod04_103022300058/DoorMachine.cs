using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod04_103022300058
{
    class DoorMachine
    {
        public enum State { TERKUNCI, TERBUKA }

        private State currentState = State.TERKUNCI;

        public void Jalankan()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("Perintah (buka/kunci/keluar): ");
                string perintah = Console.ReadLine().Trim().ToLower();

                if (perintah == "buka")
                {
                    currentState = State.TERBUKA;
                    Console.WriteLine("Pintu tidak terkunci.");
                }
                else if (perintah == "kunci")
                {
                    currentState = State.TERKUNCI;
                    Console.WriteLine("Pintu terkunci.");
                }
                else if(perintah == "keluar")
                {
                    isRunning = false;
                }   
            }

            Console.WriteLine("Program selesai.");
        }
    }
}

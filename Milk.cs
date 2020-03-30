using System;
using System.Collections.Generic;
using System.Text;

//Nama:Rio pramana putra
//NIM:19.11.3127
//Kelas:Informatika 09

namespace TheCoffeMechine
{
    class Milk
    {
        private int volumeMilk = 0;//mililiter
        private int volumeOneCupMilk = 100;

        public Milk(int volumeMilk)
        {
            this.volumeMilk = volumeMilk;
        }

        public Boolean isAvailable()
        {
            return volumeMilk >= volumeOneCupMilk;
        }

        public void addWater(int volumeMilk)
        {
            this.volumeMilk += volumeMilk;
        }

        public int makeOneCupMilk()
        {
            this.volumeMilk = this.volumeMilk - this.volumeOneCupMilk;
            return volumeOneCupMilk;
        }

        public int getVolumeMilk()
        {
            return this.volumeMilk;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMon
{
    class ConsoleMon
    {
        public int Health;
        public int Energy;
        public string Name;
        public int Level;
        public string Environment;
        public int EXP;
        public string Type;

        public void TakeDamage(int Damage)
        {
            Health = Health - Damage;
        }

        public void DepleteEnergy(int energy)
        {
            Energy = Energy - energy;
        }







    }
}

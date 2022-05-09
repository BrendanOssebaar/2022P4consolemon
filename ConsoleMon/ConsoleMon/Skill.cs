using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleMon
{
    class Skill
    {
        public int Damage;
        public int EnergyCost;
        public string Name;
        public string DamageType;

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(7);

            target.TakeDamage(11);
        }

        








    }
}

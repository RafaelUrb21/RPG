using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class blackWizard : Hero
    {
        public blackWizard(string Name, int Level, string HeroType) : base (Name, Level, HeroType) {
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia negra!";
        }

        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + "Lançou uma magia negra com um bonus de " + Bonus + "\r\n";
            }else{
                return this.Name + "Lançou uma magia não tão efetiva com bonus de " + Bonus;
            }
        }  
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base (Name, Level, HeroType){
        }

        public override string Attack()
        {
            return this.Name + " Atacou com a kunai";
        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + " Atacou com a kuani e teve um bonus de " + Bonus + "\r\n";
            }else {
                return this.Name + " Atacou com a kunai não tão efetivo e teve um bonus de " + Bonus;
            }
        }
    }
}
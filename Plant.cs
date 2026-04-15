using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D261
{
    internal class Plant
    {
        private string name;
        private int lifespan;
        private int yield;
        private int cost;
        private int price;

        private int age;

        
        public string Name { get { return name; } }
        public int Yield { get { return yield; } }
        public int Cost { get { return cost; } }
        public int Price { get { return price; } }


        public Plant(string name, int lifespan, int yield, int cost, int price)
        {
            this.name = name;
            this.lifespan = lifespan;
            this.yield = yield;
            this.cost = cost;
            this.price = price;
        }

        public void PassTurn()
        {
            age++;
        }

        public bool CanHarvest()
        {
            return age >= lifespan;
        }



    }
}

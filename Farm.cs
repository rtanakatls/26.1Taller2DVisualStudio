using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D261
{
    internal class Farm
    {
        private List<Plant> harvested;
        private List<Plant> plots;
        private int money;
        private int plotSize;


        public Farm()
        {
            plots = new List<Plant>();
        }

        public void PassTurn()
        {
            foreach (Plant plant in plots)
            {
                plant.PassTurn();
            }
        }

        public void Harvest()
        {
            List<Plant> toHarvest = new List<Plant>();
            foreach (Plant plant in plots)
            {
                if (plant.CanHarvest())
                {
                    toHarvest.Add(plant);
                }
            }

            foreach (Plant plant in toHarvest)
            { 
                plots.Remove(plant);
            }
            foreach(Plant plant in toHarvest)
            {
                harvested.Add(plant);
            }
        }

    }
}

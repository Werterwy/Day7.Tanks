using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        public string NameTank { get; set; }
        private int TankAmmunition { get; set; }
        private int ArmorLevel { get; set; }
        private int LevelOfManeuverability { get; set; }
        static int count = 0;
        private static int GenerateRandomValue()
        {
            long currentTimeMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond+count;
            count++;
            Random random = new Random((int)currentTimeMillis);
            return random.Next(0, 101);
        }
        public Tank(string NameTank) 
        {
            this.NameTank = NameTank;
            TankAmmunition = GenerateRandomValue();
            ArmorLevel= GenerateRandomValue();
            LevelOfManeuverability = GenerateRandomValue();
        }
        public string info(Tank tank)
        {
            string armorlevel = tank.ArmorLevel.ToString()+" ";
            string levelermaner=tank.LevelOfManeuverability.ToString()+" ";
            string tankamun= tank.ArmorLevel.ToString()+" ";

            string allparametr =armorlevel+levelermaner+tankamun;

            return allparametr;
        }

        public static Tank operator *(Tank tank1, Tank tank2)
        {
            int tank1Wins = 0;
            int tank2Wins = 0;

            if (tank1.TankAmmunition > tank2.TankAmmunition)
                tank1Wins++;
            else if (tank2.TankAmmunition > tank1.TankAmmunition)
                tank2Wins++;

            if (tank1.ArmorLevel > tank2.ArmorLevel)
                tank1Wins++;
            else if (tank2.ArmorLevel > tank1.ArmorLevel)
                tank2Wins++;

            if (tank1.LevelOfManeuverability > tank2.LevelOfManeuverability)
                tank1Wins++;
            else if (tank2.LevelOfManeuverability > tank1.LevelOfManeuverability)
                tank2Wins++;

            if (tank1Wins > 1)
                return tank1;
            else if (tank2Wins > 1)
                return tank2;
            else
                return null;
        }



    }
}

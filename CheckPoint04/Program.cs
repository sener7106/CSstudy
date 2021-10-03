using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UnitControl control = new UnitControl();
            string selNumStr;
            bool isLoop = true;

            while(isLoop)
            {
                selNumStr = control.Menu();

                switch (selNumStr)
                {
                    case "1":
                        control.CreateUnitMenu();
                        break;
                    case "2":
                        control.UnitRunMenu();
                        break;
                    case "3":
                        control.UnitAttackMenu();
                        break;
                    default:
                        isLoop = false;
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint04_연습_
{

    class UnitControl
    {
        const int MAX = 10;
        Army[] arrArmys;
        int indexCount = 0;

        public UnitControl()
        {
            arrArmys = new Army[MAX];
        }
        public enum UNIT
        {
            NONE,
            BABARIAN,
            GIANT,
            HEALER,
        }

       

        public string Menu()
        {
            Console.WriteLine("+++ 유닛 관리 시스템 +++");
            Console.WriteLine("(1) 생성하기 (2) 달려가기 (3) 공격하기 (0) 종료 ");

            return Console.ReadLine();

        }

        public void CreateUnitMenu()
        {
            Console.WriteLine("+++ 유닛 생성 시스템 +++");
            Console.WriteLine("(1) 바바리안 (2) 자이언츠 (3) 힐러 (0) 뒤로가기 ");

            string inputStr;
            inputStr = Console.ReadLine();

            UNIT selUnit = UNIT.NONE;

            if (indexCount >= MAX)
            {
                Console.WriteLine();
                Console.WriteLine("더 이상 유닛을 생성할 수 없습니다. {0} / {1} ", indexCount, MAX);
                return;

            }
            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputStr);
            }
            else
            {
                selUnit = UNIT.NONE;
            }

            switch (selUnit)
            {
                case UNIT.NONE:
                    indexCount--;
                    break;
                case UNIT.BABARIAN:
                    arrArmys[indexCount] = new Barbarian();
                    Console.WriteLine("바바리안, 생성되었습니다.");

                    break;
                case UNIT.GIANT:
                    arrArmys[indexCount] = new Giant();
                    Console.WriteLine("자이언츠, 생성되었습니다.");
                    break;
                case UNIT.HEALER:
                    arrArmys[indexCount] = new Healer();
                    Console.WriteLine("힐러, 생성되었습니다.");
                    break;
                default:
                    break;
            }
            indexCount++;
        }

        public void UnitRunMenu()
        {
            Console.WriteLine("+++ 유닛 돌진 시스템 +++");
            Console.WriteLine("(1) 바바리안 (2) 자이언츠 (3) 힐러 (4) 전체 달리기 (0) 뒤로가기 ");

           
            string inputStr;
            inputStr = Console.ReadLine();

            UNIT selUnit = (UNIT)int.Parse(inputStr);

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                UnitRun(selUnit);
            }
            else if (inputStr.Equals("4"))
                UnitRun();
            else
                selUnit = UNIT.NONE;

        }

        private void UnitRun(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.NONE:
                    break;
                case UNIT.BABARIAN:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Barbarian)
                            arrArmys[i].Run();
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Giant)
                            arrArmys[i].Run();
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Healer)
                            arrArmys[i].Run();
                    }
                    break;
                default:
                    break;
            }
        }

        private void UnitRun()
        {
            for(int i =0; i< indexCount; i++)
            {
                arrArmys[i].Run();
            }
        }

        public void UnitAttackMenu()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            UnitControl control = new UnitControl();
            string selNumStr;
            bool isLoop = true;

            while (isLoop)
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

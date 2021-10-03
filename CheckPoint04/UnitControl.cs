using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint04
{
    class UnitControl
    {
        const int MAX = 10;
        Army[] arrArmys;
        int indexCount = 0;

        public UnitControl()
        {
            arrArmys = new Army[MAX];
            indexCount = 0;
        }

        public enum UNIT
        {
            NONE,
            BARBARIAN,
            GIANT,
            HEALER,
        }

        public string Menu()
        {
            Console.WriteLine(" ++++ 유닛 관리 시스템 ++++ ");
            Console.WriteLine(" (1) 생성  (2) 달리기  (3) 공격 (0 : 종료하기)");

            return Console.ReadLine();
        }

        public void CreateUnitMenu()
        {
            Console.WriteLine(" ++++ 유닛 생성 시스템 ++++ ");
            Console.WriteLine(" (1) 바바리안  (2) 자이언츠  (3) 힐러 (0 : 뒤로가기)");

            string inputStr = Console.ReadLine();
            UNIT selUnit = UNIT.NONE;

            if (indexCount >= MAX)
            {
                Console.WriteLine(" 더 이상 유닛을 생성할 수 없습니다.. {0} / {1} ", indexCount, MAX);
                Console.WriteLine();
                return;
            }

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputStr);
            }
            else
                selUnit = UNIT.NONE;


            switch (selUnit)
            {
                case UNIT.NONE:
                    indexCount--;
                    break;
                case UNIT.BARBARIAN:
                    arrArmys[indexCount] = new Barbarian();
                    Console.WriteLine(" 바바리안, 생성 되었습니다. ");
                    break;
                case UNIT.GIANT:
                    arrArmys[indexCount] = new Giant();
                    Console.WriteLine(" 자이언츠, 생성 되었습니다. ");
                    break;
                case UNIT.HEALER:
                    arrArmys[indexCount] = new Healer();
                    Console.WriteLine(" 힐러, 생성 되었습니다. ");
                    break;
                default:
                    break;
            }

            indexCount++;

        }

        public void UnitRunMenu()
        {
            Console.Clear();
            Console.WriteLine(" ++++ 유닛 달리기 시스템 ++++ ");
            Console.WriteLine(" (1) 바바리안  (2) 자이언츠  (3) 힐러  (4) 전체 달리기 (0 : 뒤로가기)");

            string inputStr = Console.ReadLine();
            UNIT selUnit = (UNIT)int.Parse(inputStr);

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                UnitRun(selUnit);
            }
            else if (inputStr.Equals("4"))
            {
                UnitRun();
            }
            else
                selUnit = UNIT.NONE;
        }

        private void UnitRun(UNIT unit)
        {

            switch (unit)
            {
                case UNIT.NONE:
                    break;
                case UNIT.BARBARIAN:

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
            for (int i = 0; i < indexCount; i++)
                arrArmys[i].Run();
        }

        public void UnitAttackMenu()
        {
            Console.Clear();
            Console.WriteLine(" ++++ 유닛 공격 시스템 ++++ ");
            Console.WriteLine(" (1) 바바리안  (2) 자이언츠  (3) 힐러  (4) 전체 공격 (0 : 뒤로가기)");

            string inputStr = Console.ReadLine();
            UNIT selUnit = (UNIT)int.Parse(inputStr);

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                UnitAttack(selUnit);
            }
            else if (inputStr.Equals("4"))
            {
                UnitAttack();
            }
            else
            {
                selUnit = UNIT.NONE;
            }
        }

        private void UnitAttack(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.NONE:
                    break;
                case UNIT.BARBARIAN:
                    for(int i = 0; i<indexCount; i++)
                    {
                        if (arrArmys[i] is Barbarian)
                            arrArmys[i].Attack();
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Giant)
                            arrArmys[i].Attack();
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (arrArmys[i] is Healer)
                            arrArmys[i].Attack();
                    }
                    break;
                default:
                    break;
            }
        } 

        private void UnitAttack()
        {
            for(int i =0; i<indexCount; i++)
            {
                arrArmys[i].Attack();
            }
        }
    }
}

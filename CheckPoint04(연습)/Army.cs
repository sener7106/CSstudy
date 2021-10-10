using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint04_연습_
{
    class Army
    {
        protected int _HP;
        protected int _MP;
        protected int _Speed;
        protected int _Attack;

        public virtual void Run()
        {
            Console.Write(" [ {0} 의 속도 ] 로 ", _Speed);
        }

        public virtual void Attack()
        {
            if (this is Healer)
            {
                Console.Write(" [ {0} 의 마법 공격력 ] 으로 ", _MP * _Attack);
            }
            else
                Console.Write(" [ {0} 의 공격력 ] 으로 ", _Attack);
        }
    }

    class Barbarian : Army
    {
        public Barbarian()
        {
            _HP = 1000;
            _MP = 100;
            _Speed = 20;
            _Attack = 80;
        }

        public override void Run()
        {
            base.Run();
            Console.WriteLine(" 바바리안 달려갑니다. ");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine(" 바바리안의 몽둥이 공격!! ");
        }
    }

    class Giant : Army
    {
        public Giant()
        {
            _HP = 500;
            _MP = 10;
            _Speed = 40;
            _Attack = 90;
        }

        public override void Run()
        {
            base.Run();
            Console.WriteLine(" 자이언츠 달려갑니다. ");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine(" 자이언츠의 해머 공격!! ");
        }
    }

    class Healer : Army
    {
        public Healer()
        {
            _HP = 200;
            _MP = 500;
            _Speed = 60;
            _Attack = 30;
        }

        public override void Run()
        {
            base.Run();
            Console.WriteLine(" 힐러 날아갑니다. ");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine(" 힐러의 마법 공격!! ");
        }
    }
}

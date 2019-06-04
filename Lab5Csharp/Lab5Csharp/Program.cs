using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Csharp
{
    class Program
    {
       interface worker
        {
            void GetName();
        }

        interface staff
        {
            void GetComand();
        }

        interface engineer
        {
            void GetEngName();
        }

        interface administration
        {
            void GetAdmName();
        }

        class factory: worker, staff, engineer
        {
            public void GetName() { Console.WriteLine("Привет, Я Валера."); }
            public void GetComand() { Console.Write("У меня в команде еще Слава и Рома"); }
            public void GetEngName() { Console.WriteLine(",а инженер у нас Володя."); }
            
        }
        
        class office : factory , administration
        {
            public void GetAdmName() { Console.WriteLine("Имя директора Анатолий."); }
        }

        delegate void Message();

        public static void Main(string[] args)
        {
            Message mes;
                                 
            mes = offices;
            mes();
                     
        }
        public static void offices()
        {
            office ob = new office();

            ob.GetName();
            ob.GetComand();
            ob.GetEngName();
            ob.GetAdmName();
        }
    }
}

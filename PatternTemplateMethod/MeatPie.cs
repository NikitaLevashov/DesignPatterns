using System;
using System.Collections.Generic;
using System.Text;

namespace PatternTemplateMethod
{
    public class MeatPie : Pie
    {
        protected override void CreateDough()
        {
            Console.WriteLine("Используем дрожжевое тесто.");
        }

        protected override void CreateFilling()
        {
            Console.WriteLine("Используем мясную начинку.");
        }

        protected override void Fry()
        {
            Console.WriteLine("Запекаем в духовке при температуре 210 градусов в течении 50 минут.");
        }

        public override string ToString()
        {
            return "Мясной пирог";
        }
    }
}

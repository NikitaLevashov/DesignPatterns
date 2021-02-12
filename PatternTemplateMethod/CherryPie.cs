using System;
using System.Collections.Generic;
using System.Text;

namespace PatternTemplateMethod
{
    public class CherryPie : Pie
    {
        protected override void CreateDough()
        {
            Console.WriteLine("Используем слоеное тесто.");
        }

        protected override void CreateFilling()
        {
            Console.WriteLine("Используем вишневую начинку.");
        }

        protected override void Fry()
        {
            Console.WriteLine("Запекаем в духовке при температуре 180 градусов в течении 30 минут.");
        }

        public override string ToString()
        {
            return "Вишневый пирог";
        }
    }
}

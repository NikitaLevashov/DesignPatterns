using System;
using System.Collections.Generic;
using System.Text;

namespace PatternStrategy
{
    public class DataClientProductRepository : IRepository
    {
        public void GetProduct()
        {
            Console.WriteLine("Получаем продукты с базы данных с помощью библиотеки DataClient");
        }
    }
}

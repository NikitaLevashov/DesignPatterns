using System;
using System.Collections.Generic;
using System.Text;

namespace PatternStrategy
{
    public class EFProductRepository : IRepository
    {
        public void GetProduct()
        {
            Console.WriteLine("Получаем продуктыс базы данных с помощью EntityFraemworkCore.");
        }
    }
}

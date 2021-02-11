using System;
using System.Collections.Generic;
using System.Text;

namespace PatternStrategy
{
    public class Controller
    {
        public IRepository _repository;
        public Controller(IRepository repository)
        {
            _repository = repository;
        }

        public void Index()
        {
            _repository.GetProduct();
        }

    }
}

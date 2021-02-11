using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactoryMethod
{
    public class PythonDeveloper : Developer
    {
        public PythonDeveloper(string name) :base(name)
        {

        }

        public override Application Create()
        {
            return new PythonApplication();
        }
    }
}

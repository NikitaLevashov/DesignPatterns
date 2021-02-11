using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactoryMethod
{
    public class JavaDeveloper : Developer
    {
        public JavaDeveloper(string name) : base (name)
        {

        }
        public override Application Create()
        {
            return new JavaApplication();
        }
    }
}

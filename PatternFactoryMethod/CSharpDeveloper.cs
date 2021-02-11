using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactoryMethod
{
    public class CSharpDeveloper : Developer
    {
        public CSharpDeveloper(string name):base (name) 
        {

        }

        public override Application Create()
        {
            return new CSharpApplication();
        }
    }
}

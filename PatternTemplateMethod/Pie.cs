using System;

namespace PatternTemplateMethod
{
    public abstract class Pie
    {
        public void Cook()
        {
            CreateDough();
            CreateFilling();
            Fry();
        }

        protected abstract void CreateDough();
        protected abstract void CreateFilling();
        protected abstract void Fry();
    }
}

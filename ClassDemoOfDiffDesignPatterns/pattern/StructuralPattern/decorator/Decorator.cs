using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.decorator
{
    internal class Decorator : IComponent
    {
        private readonly IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }


        public string DoSomething(string str)
        {
            return "Dette er en decorator " + _component.DoSomething(str);
        }
    }
}

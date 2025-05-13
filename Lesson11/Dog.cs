using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Dog : Animal
    {
        public override string Name => "Dog";
        public override string Say() => "Woof!";        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_Substitution_Principle_Not_Ideal_Code
{
    abstract class Cloud
    {
        public abstract void Translate();
        public abstract void MachineLearning();
    }

    class AWS : Cloud
    {
        public override void Translate()
        {
            Console.WriteLine("AWS Translate");
        }
        public override void MachineLearning()
        {
            Console.WriteLine("AWS Machine Learning");
        }
    }

    class Azure : Cloud
    {
        // For Liskov Substitution if Azure do not has Translate method then why it is here? It is because we implement Cloud abstract class. This is not a good code that we want. This design has problem, it is not right!
        public override void Translate() => throw new NotImplementedException();
        public override void MachineLearning()
        {
            Console.WriteLine("Azure Machine Learning");
        }
    }

    class Google : Cloud
    {
        public override void Translate()
        {
            Console.WriteLine("Google Translate");
        }

        public override void MachineLearning()
        {
            Console.WriteLine("Google Machine Learning");
        }
    }
}

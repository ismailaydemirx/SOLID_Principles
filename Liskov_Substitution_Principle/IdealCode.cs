using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_Substitution_Principle_Ideal_Code
{
    abstract class Cloud
    {
        public abstract void MachineLearning();
    }

    // We moved Translate() out of Cloud and separated it into an interface
    // so that only capable clouds implement it (LSP-compliant design)
    // to ensure derived classes are not forced to implement unsupported behavior
    interface ITranslatable
    {
        void Translate();
    }

    class AWS : Cloud, ITranslatable
    {
        public override void MachineLearning()
        {
            Console.WriteLine("AWS Machine Learning");
        }

        public void Translate()
        {
            Console.WriteLine("AWS Translate");
        }
    }

    class Azure : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Azure Machine Learning");
        }
    }

    class Google : Cloud, ITranslatable
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Google Machine Learning");
        }

        public void Translate()
        {
            Console.WriteLine("Google Translate");
        }
    }

}

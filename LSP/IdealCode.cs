using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_IdealCode
{
    internal abstract class Cloud
    {
        public abstract void MachineLearning();
    }
    public interface ITranslatable
    {
        void Translate();
    }
    internal class AWS : Cloud, ITranslatable
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

    internal class Azure : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Azure Machine Learning");
        }
    }

    internal class Google : Cloud, ITranslatable
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

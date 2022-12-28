using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_NotIdealCode
{
    internal abstract class Cloud
    {
        public abstract void Translate();
        public abstract void MachineLearning();
    }
    internal class AWS : Cloud
    {
        public override void MachineLearning()
        => Console.WriteLine("AWS Machine Learning");

        public override void Translate()
        => Console.WriteLine("AWS Translate");

    }
    internal class Azure : Cloud
    {
        public override void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");

        public override void Translate()
        {
            //У azure нет сервиса ПЕРЕВОД
            //Этот метод делаем пустым или NotImplementedException
            throw new NotImplementedException();
        }
    }
    internal class Google : Cloud
    {
        public override void MachineLearning()
        => Console.WriteLine("Google Machine Learning");

        public override void Translate()
        => Console.WriteLine("Google Translate");

    }
}

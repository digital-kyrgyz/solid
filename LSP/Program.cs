using System;
using LSP_IdealCode;
//using LSP_NotIdealCode;
namespace LSP
{
    internal class Program
    {
        #region Not Ideal Code
        //Not Ideal Code
        //static void Main(string[] args)
        //{
        //    Cloud cloud = new AWS();
        //    cloud.MachineLearning();
        //    cloud.Translate();

        //    cloud = new Google();
        //    cloud.MachineLearning();
        //    cloud.Translate();

        //    cloud = new Azure();
        //    cloud.MachineLearning();

        //    //Дополнительные действия не должны быть
        //    if(cloud is not Azure)
        //    {
        //        cloud.Translate();
        //    }
        //}
        #endregion

        #region Ideal Code
        //Ideal Code
        static void Main()
        {
            Cloud cloud = new AWS();
            cloud.MachineLearning();
            (cloud as ITranslatable)?.Translate();

            cloud = new Google();
            cloud.MachineLearning();
            (cloud as ITranslatable)?.Translate();

            cloud = new Azure();
            cloud.MachineLearning();

            (cloud as ITranslatable)?.Translate();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Legacy;
using Microsoft.ML.Legacy.Models;
using Microsoft.ML.Legacy.Data;
using Microsoft.ML.Legacy.Transforms;
using Microsoft.ML.Legacy.Trainers;
using Microsoft.ML.Runtime.Api;
using CaseClassifier.Pages.Index;

namespace Model
{
    public class ML
    {
        const string _modelpath = @"D:\TFS\ML POC\SentimentAnalysis\SentimentAnalysis\Data\Model.zip";

        //public static void Predict(PredictionModel<SentimentData, SentimentPrediction> model)
        public string Predict(SentimentData SentimentData1)
        {
            ML myModel = new ML();
            return myModel.Run(SentimentData1);
        }
        public string Run(SentimentData SentimentData1)
        {
            var model = PredictionModel.ReadAsync<SentimentData, SentimentPrediction>(_modelpath.Result);
           SentimentData SentimentData2 = SentimentData1;
            var prediction = model.Predict( SentimentData1);
            return Convert.ToString(prediction.Category);

        }

       

    }
    /*public SentimentData Maker(string sentimenttext)
    {
        SentimentData SentimentData1 = new SentimentData
        {
            SentimentText = sentimenttext,
            Category = null

        };
        return SentimentData1;
    }*/
  

}

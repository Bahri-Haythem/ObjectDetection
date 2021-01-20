using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;

namespace ObjectDetection.DataStructures
{
    class ImageNetPrediction
    {
        [ColumnName("grid")]
        public float[] PredictedLabels;
    }
}

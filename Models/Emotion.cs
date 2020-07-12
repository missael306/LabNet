using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabNet.Models
{
    public class Emotion
    {
        #region Attributes
        public int EmotionID { get; set; }
        public float Score { get; set; }
        public int FaceID { get; set; }
        public EmotionEnum EmotionType { get; set; }
        #endregion

        #region Relationship
        public virtual Face Face { get; set; }
        #endregion
    }
}
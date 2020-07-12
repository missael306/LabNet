using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace LabNet.Models
{
    public class Face
    {
        #region Attributes
        public int FaceID { get; set; }
        public int PictureID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        #region Relationship
        public virtual Picture Picture { get; set; }
        public virtual ObservableCollection<Emotion> Emotions { get; set; }
        #endregion
    }
}
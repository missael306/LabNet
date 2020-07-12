using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace LabNet.Models
{
    public class Picture
    {
        #region Attributes
        public int PictureID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        #endregion

        #region  Relationship
        public virtual ObservableCollection<Face> Faces { get; set; }
        #endregion
    }
}
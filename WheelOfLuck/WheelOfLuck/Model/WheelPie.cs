using System;
using Microsoft.Xna.Framework;

namespace WheelOfLuck.Model
{
    public class WheelPie 
    {

        public int WHeelPieId { get; set; }
        public string ProductCode { get; set; }

        public string ProductName{ get; set; }
        public Color WheelPieBackColor1{ get; set; }

        public Boolean IsActive{ get; set; }
       
        public Boolean IsLoosingPie{ get; set; }
       
        public string Caption{ get; set; }

        public string ImagePath { get; set; }



    }
}
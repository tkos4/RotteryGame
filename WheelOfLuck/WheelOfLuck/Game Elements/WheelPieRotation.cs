using System;

namespace DrawGame
{
    
    public class GameItemRotation
    {        
        private static Random _random;
                
        private StructOfCicle _GameItemDegrees;        

        public void MakeStruct(float startIn, float endIn)
        {
            _GameItemDegrees = new StructOfCicle(startIn, endIn);
            _random = new Random((int)startIn);
        }

        public float RotationStop()
        {
            var min = (int) (10000*_GameItemDegrees.Start);
            var max = (int) (10000*_GameItemDegrees.End);
            var temp = _random.Next(min, max)/10000f;
            return temp;
        }
             
    }

    public class StructOfCicle
    {

        public StructOfCicle(float start, float end)
        {
            Start = start;
            End = end;
        }
        public float Start { get; set; }


        public float End { get; set; }
    }


}

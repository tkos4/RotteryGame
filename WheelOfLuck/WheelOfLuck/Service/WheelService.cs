using DrawGame.Domain.Game;
using DrawGame.Domain.Game;

namespace DrawGame.Service
{
    public class WheelService
    {

        public void CheckOrderLineIsValid(int orderLineId, int branchId)
        {

            using (var cnn = new System.Data.SqlClient.SqlConnection(""))
            {
                
            }

        }


        public bool CheckCodeIsValid(string code)
        {
            if (code == "1111") 
            {return true;}
            return false;
        }


        public GameDrawTotalStatistics GetStatistics()
        {
           
            return new GameDrawTotalStatistics();
        }





    }
}

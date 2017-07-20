using System;
using System.Data;
using System.Data.SqlClient;
using DrawGame.Domain.Game;
using DrawGame.Domain.Properties;

namespace DrawGame.Domain.Game
{
    public class GameDrawTotalStatistics
    {

        private readonly string _connectionString = "";
        public int InsertWheelDraw(Draw wheelDraw)
        {
            //new connection string @" Data Source=.\SQLEXPRESS; AttachDbFilename=|DataDirectory|\WheelOfFortune.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True"
            //old connection string @"Data Source=wizvaio\sqlexpress;Initial Catalog=WheelOfFortune;Integrated Security=True";

            using (var cnn = new SqlConnection(_connectionString))
            {

                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Insert into Draws (OrderLineId,BranchId,GameDrawDateTime,Wins,ProductCode,OrderLineQuantityIndex,GameType,GameId) Values (@OrderLineId,@BranchId,@GameDrawDateTime,@Wins,@ProductCode,@OrderLineQuantityIndex,@GameType,@GameId)";



                cmd.Parameters.AddWithValue("@OrderLineId", wheelDraw.OrderLineId);
                cmd.Parameters.AddWithValue("@BranchId", wheelDraw.BranchId);
                cmd.Parameters.AddWithValue("@GameDrawDateTime", wheelDraw.WheelDrawDateTime);
                cmd.Parameters.AddWithValue("@Wins", wheelDraw.Wins.ToString());
                cmd.Parameters.AddWithValue("@ProductCode", wheelDraw.ProductCode);
                cmd.Parameters.AddWithValue("@OrderLineQuantityIndex", wheelDraw.OrderLineQuantityIndex);
                cmd.Parameters.AddWithValue("@GameType", wheelDraw.GameType);
                cmd.Parameters.AddWithValue("@GameId", wheelDraw.GameId);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }


            return 1;



        }

    }
}

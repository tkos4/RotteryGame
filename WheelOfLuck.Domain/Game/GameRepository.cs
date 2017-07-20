using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using DrawGame.Domain.Model;
using DrawGame.Domain.Model.Core;
using DrawGame.Domain.Model.Game;
using DrawGame.Domain.Properties;

namespace DrawGame.Domain.Game
{

    public class GameRepository : IGameRepository
    {
        
        public GameRepository(string connectionString)
        {
            #region Creation Connection String From host name
            //var hostname = "";
            //if (File.Exists("server.cfg"))
            //{
            //    hostname = File.ReadAllText("server.cfg");                
            //}
            //else
            //{
            //    File.Create("server.cfg");
            //}

            //var hostEntry = Dns.GetHostEntry(hostname);
            //if (hostEntry.AddressList.Length > 0)
            //{
                
            //    var ip =Convert.ToString(hostEntry.AddressList.FirstOrDefault(x=>x.ToString().Length<16));
               
            //}
            #endregion

            ConnectionString = connectionString;
        }

        private string ConnectionString;

        public string GetConnectionString { get { return ConnectionString; } }

        #region WizGame
        public WizDrawGame GetWizDrawGameById2(int id)
        {
            //old connection string @"Data Source=wizvaio\sqlexpress;Initial Catalog=WheelOfFortune;Integrated Security=True"
            //new connection string @" Data Source=.\SQLEXPRESS; AttachDbFilename=|DataDirectory|\WheelOfFortune.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True"
            // new and offline string @" Server=(localdb)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\WheelOfFortune.mdf; Integrated Security=True; Connect Timeout=30"

            var wizDrawGame = new WizDrawGame();
            using (var cnn = new SqlConnection(ConnectionString))
            {

                using (var cmd = new SqlCommand())
                {
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from WizDrawGame where GameId=@Id;Select * from WizDrawGameItem where GameId=@Id";
                    cmd.CommandTimeout = 3600;
                    //Σε περίπτωση που θα τρέξει αρκετή ώρα το θέτουμε για να μην κάνει timeout.
                    cmd.Parameters.AddWithValue("@Id", id);

                    var rdr = cmd.ExecuteReader();

                   

                    while (rdr.Read())
                    {
                        wizDrawGame.GameId = rdr.GetInt32(rdr.GetOrdinal("GameId"));
                        wizDrawGame.Name = rdr.GetString(rdr.GetOrdinal("Name"));
                        wizDrawGame.GameTypeId = rdr.GetInt16(rdr.GetOrdinal("GameTypeId"));
                        wizDrawGame.IsActive = rdr.GetBoolean(rdr.GetOrdinal("IsActive"));
                        if (!rdr.IsDBNull(rdr.GetOrdinal("BackgroundImage")))
                            wizDrawGame.BackgroundImage = (byte[])rdr.GetValue(rdr.GetOrdinal("BackgroundImage"));
                        if (!rdr.IsDBNull(rdr.GetOrdinal("WinningImage")))
                            wizDrawGame.WinImage = (byte[])rdr.GetValue(rdr.GetOrdinal("WinningImage"));
                        if (!rdr.IsDBNull(rdr.GetOrdinal("LoosingImage")))
                            wizDrawGame.LostImage = (byte[])rdr.GetValue(rdr.GetOrdinal("LoosingImage"));
                        if (!rdr.IsDBNull(rdr.GetOrdinal("WinningSound")))
                            wizDrawGame.WinSound = (byte[])rdr.GetValue(rdr.GetOrdinal("WinningSound"));
                        if (!rdr.IsDBNull(rdr.GetOrdinal("LosingSound")))
                            wizDrawGame.LostSound = (byte[])rdr.GetValue(rdr.GetOrdinal("LosingSound"));
                    }

                    rdr.NextResult();

                    while (rdr.Read())
                    {
                        var GameItem = new WizDrawGameItem
                        {
                            GameItemId = rdr.GetInt32(rdr.GetOrdinal("GameItemId")),
                            GamelId = rdr.GetInt32(rdr.GetOrdinal("GameId")),
                            ProductCode = rdr.GetString(rdr.GetOrdinal("ProductCode")),
                            Caption = rdr.GetString(rdr.GetOrdinal("Caption")),
                            IsLoosing = rdr.GetBoolean(rdr.GetOrdinal("IsLoosing")),
                            IsActive = rdr.GetBoolean(rdr.GetOrdinal("IsActive")),
                            BackColorString = rdr.GetString(rdr.GetOrdinal("BackColor")),
                            Image = (byte[]) rdr.GetValue(rdr.GetOrdinal("Image")),
                            GameDrawBeforeWinsCount = rdr.GetInt32(rdr.GetOrdinal("WheelDrawBeforeWinsCount")),
                            ProductName = rdr.GetString(rdr.GetOrdinal("ProductName")),
                            WinningTitle = rdr.GetString(rdr.GetOrdinal("WinningTitle"))
                            
                        };

                        wizDrawGame.GameItems.Add(GameItem);
                    }


                }

            }
            wizDrawGame.MarkUnchanged();

            foreach (var GameItem in wizDrawGame.GameItems)
            {
                GameItem.MarkUnchanged();
            }


            return wizDrawGame;
        }

        public void UpdateWizDrawGame(WizDrawGame drawGame)
        {

            using (var cnn = new SqlConnection(ConnectionString))
            {

                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText =
                    "Update WizDrawGame SET  Name=@Name,GameTypeId=@GameTypeId,IsActive=@IsActive where GameId=@Id";
                cmd.CommandTimeout = 3600; //Σε περίπτωση που θα τρέξει αρκετή ώρα το θέτουμε για να μην κάνει timeout.

                cmd.Parameters.AddWithValue("@Id", drawGame.GameId);
                cmd.Parameters.AddWithValue("@Name", drawGame.Name);
                cmd.Parameters.AddWithValue("@GameTypeId", drawGame.GameTypeId);
                cmd.Parameters.AddWithValue("@IsActive", drawGame.IsActive);
               



                cnn.Open();
                cmd.ExecuteNonQuery();

                UpdateGameAppearance(drawGame);

                foreach (var gameItem in drawGame.GameItems)
                {
                    if (gameItem.ObjectState == ObjectState.Modified)
                    {

                        cmd.Parameters.Clear();
                        cmd.CommandText =
                            "Update WizDrawGameItem SET ProductCode=@ProductCode,Caption=@Caption,IsLoosing=@IsLoosing,IsActive=@IsActive,BackColor=@BackColor,Image=@Image,WheelDrawBeforeWinsCount=@WheelDrawBeforeWinsCount,ProductName=@ProductName,WinningTitle=@WinningTitle where GameItemId=@GameItemId";

                        cmd.Parameters.AddWithValue("@ProductCode", gameItem.ProductCode);
                        cmd.Parameters.AddWithValue("@Caption", gameItem.Caption);
                        cmd.Parameters.AddWithValue("@IsLoosing", gameItem.IsLoosing.ToString());
                        cmd.Parameters.AddWithValue("@IsActive", gameItem.IsActive.ToString());
                        cmd.Parameters.AddWithValue("@BackColor", gameItem.BackColorString);
                        cmd.Parameters.AddWithValue("@Image", gameItem.Image);
                        cmd.Parameters.AddWithValue("@WheelDrawBeforeWinsCount", gameItem.GameDrawBeforeWinsCount);
                        cmd.Parameters.AddWithValue("@ProductName", gameItem.ProductName);
                        cmd.Parameters.AddWithValue("@GameItemId", gameItem.GameItemId);
                        cmd.Parameters.AddWithValue("@WinningTitle", gameItem.WinningTitle);

                        cmd.ExecuteNonQuery();
                    }
                    else if (gameItem.ObjectState == ObjectState.New)
                    {


                        gameItem.GamelId = drawGame.GameId;

                        InsertGameItem(gameItem);


                    }
                        // NEVER USED 
                    else if (gameItem.ObjectState == ObjectState.Deleted)
                    {

                        DeleteGameItem(gameItem.GameItemId);
                    }



                }

            }
        }

        public WizDrawGame InsertWizDrawGame(WizDrawGame drawGame)
        {

            using (var cnn = new SqlConnection(ConnectionString))
            {

                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Insert into WizDrawGame (Name,GameTypeId,IsActive) Values (@Name,@GameTypeId,@IsActive); SELECT SCOPE_IDENTITY();";


                cmd.Parameters.AddWithValue("@Name", drawGame.Name);
                cmd.Parameters.AddWithValue("@GameTypeId", drawGame.GameTypeId);
                cmd.Parameters.AddWithValue("@IsActive", drawGame.IsActive);
                cnn.Open();
                var newId = cmd.ExecuteScalar();

                drawGame.GameId = Convert.ToInt32(newId);
                foreach (var gameItem in drawGame.GameItems)
                {

                    gameItem.GamelId = drawGame.GameId;
                    gameItem.GameItemId = InsertGameItem(gameItem);

                }

                UpdateGameAppearance(drawGame);


                return drawGame;
            }
        }

        public int InsertGameItem(WizDrawGameItem gameItem)
        {
            using (var cnn = new SqlConnection(ConnectionString))
            {


                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText =
                    "Insert into WizDrawGameItem ( GameId,ProductCode,Caption,IsLoosing,IsActive,BackColor,Image,WheelDrawBeforeWinsCount,ProductName,WinningTitle) Values (@GameId,@ProductCode,@Caption,@IsLoosing,@IsActive,@BackColor,@Image,@WheelDrawBeforeWinsCount,@ProductName,@WinningTitle); SELECT SCOPE_IDENTITY(); ";


                cmd.Parameters.AddWithValue("@GameId", gameItem.GamelId);
                cmd.Parameters.AddWithValue("@ProductCode", gameItem.ProductCode);
                cmd.Parameters.AddWithValue("@Caption", gameItem.Caption);
                cmd.Parameters.AddWithValue("@IsLoosing", gameItem.IsLoosing.ToString());
                cmd.Parameters.AddWithValue("@IsActive", gameItem.IsActive.ToString());
                cmd.Parameters.AddWithValue("@BackColor", gameItem.BackColorString);
                cmd.Parameters.AddWithValue("@Image", gameItem.Image);
                cmd.Parameters.AddWithValue("@WheelDrawBeforeWinsCount", gameItem.GameDrawBeforeWinsCount);
                cmd.Parameters.AddWithValue("@ProductName", gameItem.ProductName);
                cmd.Parameters.AddWithValue("@WinningTitle", gameItem.WinningTitle);
                cnn.Open();
                var newId = cmd.ExecuteScalar();
                gameItem.GameItemId = Convert.ToInt32(newId);

                return Convert.ToInt32(newId);

            }

        }

        public void DeleteWizDrawGame(int gameId)
        {
            using (var cnn = new SqlConnection(ConnectionString))
            {

                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "DELETE FROM WizDrawGame WHERE GameId=@id";

                cmd.Parameters.AddWithValue("@id", gameId);
                cnn.Open();
                cmd.ExecuteNonQuery();

                #region Delete GameItems and Images




                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "DELETE FROM WizDrawGameItem WHERE GameId=@id";

                cmd.Parameters.AddWithValue("@id", gameId);


                cmd.ExecuteNonQuery();


                #endregion


            }
        }

        public void DeleteGameItem(int gameItemId)
        {

            using (var cnn = new SqlConnection(ConnectionString))
            {

                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM WizDrawGameItem WHERE GameItemId=@GameItemId";

                cmd.Parameters.AddWithValue("@GameItemId", gameItemId);

                cnn.Open();
                cmd.ExecuteNonQuery();


            }

        }

        public WizDrawGame SaveWizDrawGame(WizDrawGame drawGame)
        {

            if (drawGame.ObjectState == ObjectState.New)
            {
                return InsertWizDrawGame(drawGame);
            }

            if (drawGame.ObjectState == ObjectState.Modified)
            {
                UpdateWizDrawGame(drawGame);
            }
            if (drawGame.ObjectState == ObjectState.Deleted)
            {
                DeleteWizDrawGame(drawGame.GameId);
                return drawGame;

            }


            return drawGame;

        }

        public List<WizDrawGameInfo> GetAllWizDrawGameInfo()
        {
            var wizDrawGameInfoList = new List<WizDrawGameInfo>();

            using (var cnn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText =
                        @"SELECT        dbo.WizDrawGame.GameId,dbo.WizDrawGame.IsActive, dbo.WizDrawGame.Name AS GameName, dbo.GameType.Name AS GameTypeName
FROM            dbo.WizDrawGame INNER JOIN
                         dbo.GameType ON dbo.WizDrawGame.GameTypeId = dbo.GameType.GameTypeId";
                    cmd.CommandTimeout = 3600;


                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        var wizDrawGameInfo = new WizDrawGameInfo();
                        wizDrawGameInfo.GameId = rdr.GetInt32(rdr.GetOrdinal("GameId"));
                        wizDrawGameInfo.GameName = rdr.GetString(rdr.GetOrdinal("GameName"));
                        wizDrawGameInfo.GameTypeName = rdr.GetString(rdr.GetOrdinal("GameTypeName"));
                        wizDrawGameInfo.IsActive = rdr.GetBoolean(rdr.GetOrdinal("IsActive"));
                        wizDrawGameInfoList.Add(wizDrawGameInfo);
                        
                    }
                }
            }
            return wizDrawGameInfoList;

        }

        public BindingList<WizDrawGame> GetAllWizDrawGames()
        {
            var wheels = new BindingList<WizDrawGame>();

            using (var cnn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText =
                        "Select * from WizDrawGame";
                    cmd.CommandTimeout = 3600;


                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        var id = rdr.GetInt32(rdr.GetOrdinal("GameId"));

                        wheels.Add(GetWizDrawGameById2(id));
                    }
                }
            }
            return wheels;

        }

        public void UpdateGameAppearance(WizDrawGame drawGame)
        {
            using (var cnn = new SqlConnection(ConnectionString))
            {

                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "Update WizDrawGame SET  BackgroundImage=@BackgroundImage,WinningImage=@WinningImage,LoosingImage=@LoosingImage,WinningSound=@WinningSound,LosingSound=@LosingSound where GameId=@Id";
                cmd.CommandTimeout = 3600; //Σε περίπτωση που θα τρέξει αρκετή ώρα το θέτουμε για να μην κάνει timeout.


                cmd.Parameters.AddWithValue("@Id", drawGame.GameId);

                if (drawGame.BackgroundImage == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@BackgroundImage", SqlDbType.VarBinary)).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BackgroundImage", drawGame.BackgroundImage);
                }
                if (drawGame.WinImage == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@WinningImage", SqlDbType.VarBinary)).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WinningImage", drawGame.WinImage);
                }
                if (drawGame.LostImage == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@LoosingImage", SqlDbType.VarBinary)).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@LoosingImage", drawGame.LostImage);
                }
                if (drawGame.WinSound == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@WinningSound", SqlDbType.VarBinary)).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@WinningSound", drawGame.WinSound);
                }
                if (drawGame.LostSound == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@LosingSound", SqlDbType.VarBinary)).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@LosingSound", drawGame.LostSound);
                }

                
                cnn.Open();
                cmd.ExecuteNonQuery();

            }
        }

        #endregion

        #region Branches
        public List<Branch> GetBranches()
        {
            var Branches = new List<Branch>();

            using (var cnn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText =
                        "Select * from Branch";
                    cmd.CommandTimeout = 3600;


                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        var branch = new Branch();
                        branch.BranchCode = rdr.GetString(rdr.GetOrdinal("BranchCode"));
                        branch.BranchName = rdr.GetString(rdr.GetOrdinal("BranchName"));
                        Branches.Add(branch);
                    }
                }
            }
            return Branches;
        }



        public List<BranchGame> GetBranchGames(int wizDrawGameId)
        {
            var branchGame = new List<BranchGame>();

            using (var cnn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText =
                        "Select * from BranchGame Where GameId=@GameId";

                    cmd.Parameters.AddWithValue("@GameId", wizDrawGameId);

                    cmd.CommandTimeout = 3600;


                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        branchGame.Add(new BranchGame(){BranchCode = rdr.GetString(rdr.GetOrdinal("BranchCode")),GameId = wizDrawGameId});
                    }
                }
            }
            return branchGame;
        }

        public List<int> GetBranchGamesByBranchCode(string branchCode)
        {
            var GameIds = new List<int>();

            using (var cnn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText =
                        @"SELECT [WheelOfFortune].[dbo].[WizDrawGame].[GameId] 
                          FROM [WheelOfFortune].[dbo].[WizDrawGame]
                          INNER JOIN [WheelOfFortune].[dbo].[BranchGame] ON [WheelOfFortune].[dbo].[BranchGame].[GameId] = [WheelOfFortune].[dbo].[WizDrawGame].[GameId] 
                          WHERE [WheelOfFortune].[dbo].[BranchGame].BranchCode=@BranchCode 
                          GROUP BY [WheelOfFortune].[dbo].[WizDrawGame].[GameId]        
                          UNION 
                          SELECT [WheelOfFortune].[dbo].[WizDrawGame].[GameId] 
                          FROM [WheelOfFortune].[dbo].[WizDrawGame]
                          WHERE [WheelOfFortune].[dbo].[WizDrawGame].[IsSharedByAllBranches]='1' AND [WheelOfFortune].[dbo].[WizDrawGame].IsActive='1'
                          GROUP BY [WheelOfFortune].[dbo].[WizDrawGame].[GameId]  
                          ";

                    cmd.Parameters.AddWithValue("@BranchCode", branchCode);

                    cmd.CommandTimeout = 3600;


                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        GameIds.Add(rdr.GetInt32(rdr.GetOrdinal("GameId")));
                    }


                }
            }
            return GameIds;
        }
       
        public void InsertBranchGame(BranchGame branchGame)
        {
            using (var cnn = new SqlConnection(ConnectionString))
            {


                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;


                cmd.CommandText =
                    "Insert into BranchGame ( GameId,BranchCode) Values (@GameId,@BranchCode); ";

                cmd.Parameters.AddWithValue("@GameId", branchGame.GameId);
                cmd.Parameters.AddWithValue("@BranchCode", branchGame.BranchCode);
                cnn.Open();
                cmd.ExecuteNonQuery();



            }
        }

        public void DeleteBranchGame(BranchGame branchGame)
        {
            using (var cnn = new SqlConnection(ConnectionString))
            {


                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;


                cmd.CommandText =
                    "Delete From BranchGame where GameId=@GameId AND BranchCode=@BranchCode ; ";

                cmd.Parameters.AddWithValue("@GameId", branchGame.GameId);
                cmd.Parameters.AddWithValue("@BranchCode", branchGame.BranchCode);
                cnn.Open();
                cmd.ExecuteNonQuery();



            }
        }

        public void UpdateWizGameBranchRights(int gameId, bool isSharedByAllBranches)
        {
            using (var cnn = new SqlConnection(ConnectionString))
            {
                var cmd = cnn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText =
                    "Update WizDrawGame SET  IsSharedByAllBranches=@IsSharedByAllBranches where GameId=@Id";
                cmd.CommandTimeout = 3600; //Σε περίπτωση που θα τρέξει αρκετή ώρα το θέτουμε για να μην κάνει timeout.
                cmd.Parameters.AddWithValue("@Id", gameId);
                cmd.Parameters.AddWithValue("@IsSharedByAllBranches", isSharedByAllBranches);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

    }
}


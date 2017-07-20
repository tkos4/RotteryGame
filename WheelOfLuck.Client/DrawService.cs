using System;
using System.IO;
using System.Net;
using Microsoft.AspNet.SignalR.Client;

namespace DrawGame.Client
{
    public class DrawService
    {
        public bool Restart { get; set; }
        public bool Response { get; set; }
        private IHubProxy HubProxy { get; set; }        
        public HubConnection Connection { get; set; }      
        public DrawResponse DrawResponse { get; set; }

        string ServerUri = "";

        public delegate void ResponseDelegate(DrawResponse result);

        public delegate void RestartGameDelege();

        private RestartGameDelege _restartGameDelege;

        private ResponseDelegate _responseDelegate;



        public DrawService()
        {
            #region Creating Signalr Server Uri From HostName
            if (File.Exists("server.cfg"))
            {
                var text = File.ReadAllText("server.cfg");
                ServerUri = text;//"https://" + text + ":667/server";                
            }
            else
            {
                File.Create("server.cfg");
            }
            #endregion

            _responseDelegate = WaitForResponce;
            _restartGameDelege = RestartGame;

            Connect();
            
        }

        public void RestartGame()
        {
            Restart = true;
        }
        
        public void WaitForResponce(DrawResponse result)
        {
            DrawResponse = result;
            Response = true;
        }       

        private  void Connect()
        {
            
            Connection = new HubConnection(ServerUri);
            Connection.Headers.Add("UserName", System.Net.Dns.GetHostName());
            Connection.Credentials=CredentialCache.DefaultCredentials;
           
            HubProxy = Connection.CreateHubProxy("GameHub");

            HubProxy.On<DrawResponse>("result", status => _responseDelegate.Invoke(status));
            HubProxy.On<bool>("Restart", status => _restartGameDelege.Invoke());

            try
            {
                Connection.Start();
            }
            catch
            {
                throw new Exception("Server is not available. Please try again later or contact your administrator.");
            }

        }
        

        public void SentRequest(int id)
        {
           
            HubProxy.Invoke("Send", id).Wait(5000);
        }

        public bool RestartServer()
        {
            try
            {
                HubProxy.Invoke("Restart").Wait(5000);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
    public class DrawResponse
    {
        public bool Win;
        public int WinnerId;

    }
}

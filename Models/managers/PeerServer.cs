using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Models.model;

namespace Models.managers
{
    public class PeerServer
    {
        protected bool serverstop = false;
        protected List<String> supportedFiles = new List<string>();
        protected FileEndPoint fileEP = new FileEndPoint();

        public PeerServer()
        {

            //Fylder filer ind i serveren
            if (Directory.Exists(Configurations.FileServerPath))
            {
                foreach (string filename in Directory.GetFiles(Configurations.FileServerPath))
                {
                    string[] filedetails = filename.Split(@"\");
                    supportedFiles.Add(filedetails[filedetails.Length - 1]);
                }
            }

            Console.WriteLine("Server started");
            Console.WriteLine("with files supported");
            Console.WriteLine(String.Join("\n", supportedFiles));
        }


        private void Startup()
        {
            Console.WriteLine("Peer server started");

            HttpClient restClient = new HttpClient();
            //Configuration er en klasse i mappen "managers".
            fileEP.Port = Configurations.PORT;

            //Dns.GetHostName tager computerens local adresse
            string hostName = Dns.GetHostName();

            //Dns.GetHostAddresses tager hosts IP adresse
            IPAddress[] adrs = Dns.GetHostAddresses(hostName);

            foreach (IPAddress adr in adrs)
            {
                //adr.GetAddressBytes copy af IPadresse i et array af bytes
                byte[] bytes = adr.GetAddressBytes();


            }

        }




    }
}

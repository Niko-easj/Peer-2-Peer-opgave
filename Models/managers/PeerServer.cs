using System;
using System.Collections.Generic;
using System.IO;
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



    }
}

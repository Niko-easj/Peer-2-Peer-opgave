using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using Models.model;
using Newtonsoft.Json;

namespace Models.managers
{
    public class PeerClient
    {
        public List<FileEndPoint> Search(string filename)
        {
            List<FileEndPoint> liste = new List<FileEndPoint>();
            {
                HttpClient restClient = new HttpClient();
                String jstr = restClient.GetStringAsync(Configurations.URI + filename).Result;
                ICollection<FileEndPoint> files = JsonConvert.DeserializeObject<ICollection<FileEndPoint>>(jstr);

                liste.AddRange(files);

                return liste;
            }
        }

        public void Download(string filename, FileEndPoint ep, string outFileName)
        {
            TcpClient client = new TcpClient(ep.IpAddress, ep.Port);
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.WriteLine("Get " + filename);
            sw.Flush();

            NetworkStream fromStream = client.GetStream();
            FileStream toStream = File.Create(Configurations.FileClientPath + outFileName);

            fromStream.CopyTo(toStream);

            toStream?.Close();
            client?.Close();
        }

    }
}

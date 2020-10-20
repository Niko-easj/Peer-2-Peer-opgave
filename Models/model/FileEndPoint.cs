using System;
using System.Collections.Generic;
using System.Text;

namespace Models.model
{
    //Husk klasser skal være public, ellers kan man ikke refferere til den
    public class FileEndPoint
    {
        #region Properties

        public string IpAddress { get; set; }
        public int Port { get; set; }

        #endregion

        #region Constructors

        public FileEndPoint(string ipAddress, int port)
        {
            IpAddress = ipAddress;
            Port = port;
        }

        public FileEndPoint()
        {
            
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{nameof(IpAddress)}: {IpAddress}, {nameof(Port)}: {Port}";
        }

        #endregion


    }
}

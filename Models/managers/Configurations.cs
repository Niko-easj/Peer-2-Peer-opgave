using System;
using System.Collections.Generic;
using System.Text;

namespace Models.managers
{
    public static class Configurations
    {

        //Husk og lav mappe
        private const String FilePath = @"C:\P2P\";

        //Link til rest i azure
        public const String URI = "https://powernaprest20201022110228.azurewebsites.net/api/files/";

        //root til uploads mappe i P2P mappe
        public const String FileServerPath = FilePath + @"uploads\";

        //root til download mappe i P2P
        public const String FileClientPath = FilePath + @"downloads\";

        //predefineret portnummer
        public const int PORT = 3000;
    }
}

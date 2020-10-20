using System;
using System.Collections.Generic;
using System.Text;

namespace Models.managers
{
    public static class Configurations
    {
        private const String FilePath = @"C:\P2P\";

        public const String URI = "INDSÆT CONTROLLER PATH HER";

        public const String FileServerPath = FilePath + @"uploads\";
        public const String FileClientPath = FilePath + @"downloads\";
        public const int PORT = 3000;
    }
}

﻿using SSCMS.Core.Packaging;

namespace SSCMS.Web.Controllers.Admin.Plugins
{
    public partial class ViewController
    {
        public class GetResult
        {
            public bool IsNightly { get; set; }
            public string Version { get; set; }
            public bool Installed { get; set; }
            public string InstalledVersion { get; set; }
            public PackageMetadata Plugin { get; set; }
        }
    }
}

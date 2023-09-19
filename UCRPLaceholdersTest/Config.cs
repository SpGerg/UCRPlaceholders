using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCRPLaceholdersTest
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; }

        public bool Debug { get; set; }

        public string SomeCoolText { get; set; } = "Yayaya {ucr-role_1_count}";
    }
}

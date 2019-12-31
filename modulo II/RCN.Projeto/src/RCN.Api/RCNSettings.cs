using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCN.Api
{
    public class RCNSettings
    {
        public string Nome { get; set; }
        public EmailConfig EmailConfig { get; set; }
    }

    public class EmailConfig
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}

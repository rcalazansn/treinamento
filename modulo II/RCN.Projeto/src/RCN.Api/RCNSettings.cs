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

    public class SettingsJWT
    {
        public string Secret { get; set; } //Segredo
        public int ExpiracaoHoras { get; set; } //Quantas horas leva até expiração
        public string Emissor { get; set; } //Quem emiriu (API)
        public string ValidoEm { get; set; } //Em qual url é válido
    }
}

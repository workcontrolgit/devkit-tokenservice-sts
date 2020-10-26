using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Services
{
    public class CertificateConfiguration
    {
        public bool UseLocalCertStore { get; set; }
        public string CertificateThumbprint { get; set; }
        public string CertificateNameKeyVault { get; set; }
        public string KeyVaultEndpoint { get; set; }
        public string DevelopmentCertificatePfx { get; set; }
        public string DevelopmentCertificatePassword { get; set; }
    }
}

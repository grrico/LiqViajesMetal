using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetalLiqViajes_Forms.Util
{
    public class Credentials : ICredentials
    {
        public NetworkCredential GetCredential(Uri uri, string authType)
        {
            throw new NotImplementedException();
        }
    }
}

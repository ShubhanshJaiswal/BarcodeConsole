using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooORM;

namespace DataEntryConsole
{
    public class LicenseController
    {
        private const string LicenseEndpoint = "portal.cogitateinc.com:45212";

        public void SetLicenseToken(PortalSqlCalls sqlcall, bool admin)
        {
            if (sqlcall == null) return;
            if (!admin) return;
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 7, true);
            sqlcall.AccessToken = licenseToken;
        }
        public PortalSqlCalls GetLicensePortalCalls()
        {
            return new PortalSqlCalls(LicenseEndpoint);
        }
    }

}

    
  

using WahooORM;

namespace DataEntryConsole
{
    public static class Lookup
    {
        //method to look up an inventory id given a code
        public async static Task<int> LookupInventory(string code)
        {
            //creates portal connection to sql database
            var InventorFind = new WahooTable<Inventor>(); 
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            InventorFind.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken = licenseToken };

            InventorFind.Rows.UseContextPost = false;
            //loads the rows from column InvetorId based on the user inputted code. this will select from SQL the column InventorId,  
            //and all the rows that the user inputed code.
            await InventorFind.PrepareWahooQueryAndReadResults($"select InventorId from {nameof(Inventor)} where Code='{code}'");
            //check to see if the user entered code is in the table
            if (InventorFind.Rows.Any())
            { 
                //if that code exists, return the first row's InventorId
                var tt= InventorFind.Rows.FirstOrDefault();
                if (tt != null)
                    return tt.InventorId;

            }
            //if that code does not exist in the code column, check a different column for that code
            await InventorFind.PrepareWahooQueryAndReadResults($"select InventorId from {nameof(Inventor)} where ScanCode='{code}'");
            if (InventorFind.Rows.Any())
            {
                var tt = InventorFind.Rows.FirstOrDefault();
                if (tt != null)
                    return tt.InventorId;

            }
            //loads the data from the given sql table
            await InventorFind.PrepareWahooQueryAndReadResults($"select InventorId from {nameof(Inventor)} where ManufactureNbr='{code}'");
            if (InventorFind.Rows.Any())
            {
                var tt = InventorFind.Rows.FirstOrDefault();
                if (tt != null)
                    return tt.InventorId;

            }
            //returns 0 if the user inputted code is not found
            return 0;
        }
        //these methods below act the same as the above one, they connect to the database, look for the user
        //inputted code in the appropriate table, then return that id if found, otherwise a 0
        public async static Task<int> LookupEquipment(string code)
        {
            var EquFind = new WahooTable<Equipmen>();
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            EquFind.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken = licenseToken };

            EquFind.Rows.UseContextPost = false;
            await EquFind.PrepareWahooQueryAndReadResults($"select EquipmenId from {nameof(Equipmen)} where Code='{code}'");
            if (EquFind.Rows.Any())
            {
                var tt = EquFind.Rows.FirstOrDefault();
                if (tt != null)
                    return tt.EquipmenId;

            }
            return 0;
        }
        public async static Task<int> LookupWorkOrder(string code)
        {
            var WorkFind = new WahooTable<WorkOrde>();
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            WorkFind.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken = licenseToken };
            WorkFind.Rows.UseContextPost = false;
            await WorkFind.PrepareWahooQueryAndReadResults($"select WONbr from {nameof(WorkOrde)} where EquNbr='{code}'");
            if (WorkFind.Rows.Any())
            {
                var tt = WorkFind.Rows.FirstOrDefault();
                if (tt != null)
                    return tt.WONbr;
            }
            return 0;
        }
        public async static Task<int> LookupPurchaseOrder(string code)
        {
            var POFind = new WahooTable<POHeader>();
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            POFind.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken = licenseToken };
            POFind.Rows.UseContextPost = false;
            await POFind.PrepareWahooQueryAndReadResults($"select POHeaderId from {nameof(POHeader)} where PONumber='{code}'");
            if (POFind.Rows.Any())
            {
                var tt = POFind.Rows.FirstOrDefault();
                if (tt != null)
                    return tt.POHeaderId;
            }
            return 0;
        }
        public async static Task<int> LookupAccount(string code)
        {
            var AccFind = new WahooTable<GLAccts>();
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            AccFind.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken = licenseToken };
            AccFind.Rows.UseContextPost = false;
            await AccFind.PrepareWahooQueryAndReadResults($"select AutoIncrementID from {nameof(GLAccts)} where ScannerCode='{code}'");
            if (AccFind.Rows.Any())
            {
                var tt = AccFind.Rows.FirstOrDefault();
                if (tt != null)
                    return tt.AutoIncrementID;
            }
            return 0;
        }
    }
}

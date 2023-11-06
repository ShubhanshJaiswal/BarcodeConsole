using WahooORM;
namespace DataEntryConsole
{
    public static class GetList
    {
        //creates the Wahootable I will need to connect to the database
        public static WahooTable<Inventor> InventorList = new WahooTable<Inventor>();
        public static WahooTable<BarCodeTrans> BarTransList = new WahooTable<BarCodeTrans>();

        //gets the whole SQL database Inventory, every column and row
        public async static Task GetInventorList()
        {
            //creates the portal connection to the SQL database 
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            InventorList.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken=licenseToken};           
            InventorList.Rows.UseContextPost = false;
            //gets the entire inventor table from sql
            await InventorList.PrepareWahooQueryAndReadResults($"select * from {nameof(Inventor)}");
        }
        public async static Task GetTransList()
        {
            //creates the portal connection to the SQL database
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            BarTransList.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken = licenseToken };          
            BarTransList.Rows.UseContextPost = false;
            //gets the BarCodeTrans table from sql
            await BarTransList.PrepareWahooQueryAndReadResults($"select * from {nameof(BarCodeTrans)}");
        }

    }
}

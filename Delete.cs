using WahooORM;
namespace DataEntryConsole
{
    public static class Delete
    {
        public static WahooTable<BarCodeTrans> BarTransList = new WahooTable<BarCodeTrans>();

        public async static void DeleteAll()
        {
            //creates the protal connection to the SQL database
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            BarTransList.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken=licenseToken};
            BarTransList.Rows.UseContextPost = false;
            //loads the data from the table
            await BarTransList.PrepareWahooQueryAndReadResults($"select * from {nameof(BarCodeTrans)}"); 
            //goes through each row and deletes it from the table
            foreach(var row in BarTransList.Rows)
            {
                BarTransList.DeleteRow(row);
            }
            await BarTransList.UpdateAsync();
        }
    }
}

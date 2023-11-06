using WahooORM;

namespace DataEntryConsole
{
    public static class WriteBarCodeTrans
    {
        public static WahooTable<BarCodeTrans> BarTransList = new WahooTable<BarCodeTrans>();

        public async static void WriteOne()
        {
            var licenseToken = PortalSqlCalls.MakeTokenCode(DateTime.Now, 123, 1, true);
            BarTransList.PortalInterfaceCalls = new PortalSqlCalls(Global.PortalEndpoint) { AccessToken=licenseToken};
            BarTransList.Rows.UseContextPost = false;
            await BarTransList.PrepareWahooQueryAndReadResults($"select * from {nameof(BarCodeTrans)} where BarCodeTransId=-1");

            //creates a new row in the sql database with the hardcoded values
            var trans= BarTransList.NewRow();
            trans.EffDate = DateTime.Now;
            trans.TransType = (int) BarCodeTransType.Charge;
            trans.RefType = (int) BarCodeReferenceType.Equipment;
            trans.Quantity = 2.5M;
            trans.Amount = decimal.Zero;
            trans.RefValueOne = 23;
            trans.RefValueTwo = 0;
            trans.InvCodeId = 3187;
            trans.UserId = 12;
            await BarTransList.UpdateAsync();
        }
    }
}

using WahooORM;

// ReSharper disable InconsistentNaming

namespace DataEntryConsole
{
    public class POHeader : ObservableWahooRecord
    {
        //properties of the sql table: POHeader, these match the 
        //column names in the SQL table
        public string VendorCode { get; set; } = default!;
        public string PONumber { get; set; } = default!;
        public DateTime PODate { get; set; }
        public string POPostDate { get; set; } = default!;
        public bool? POCompleteFlag { get; set; }

        [PrimaryKey, AutoGen]
        public int POHeaderId { get; set; }

        public string InventoryCode { get; set; } = default!;
        public string VndName { get; set; } = default!;
    }
}

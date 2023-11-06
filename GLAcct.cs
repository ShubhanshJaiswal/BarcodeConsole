using WahooORM;

// ReSharper disable InconsistentNaming

namespace DataEntryConsole
{
    public class GLAccts : ObservableWahooRecord
    {


        [PrimaryKey, AutoGen]
        public int AutoIncrementID { get; set; }
        public string ScannerCode { get; set; } = default!;
    }
}

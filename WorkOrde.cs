
using WahooORM;

// ReSharper disable InconsistentNaming

namespace DataEntryConsole
{
    public class WorkOrde : ObservableWahooRecord
    {
        //properties of the sql table: WorkOrde, these match the 
        //column names in the SQL table
        [PrimaryKey]
        public int WONbr { get; set; }
        public DateTime? WODate { get; set; }
        public string EquNbr { get; set; } = default!;
        public bool? ClosedFlag { get; set; }
       
    }
}

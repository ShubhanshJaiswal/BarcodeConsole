using WahooORM;

namespace DataEntryConsole
{
    public class WOLine : ObservableWahooRecord
    {
        //properties of the sql table: WOLine, these match the 
        //column names in the SQL table
        [PrimaryKey, AutoGen]
        public int WOLinesId { get; set; }
        public int WONbr { get; set; }
        public int WOLineNbr { get; set; }

    }
}

using WahooORM;

// ReSharper disable InconsistentNaming

namespace DataEntryConsole
{
    public class Equipmen : ObservableWahooRecord
    {
        //properties of the sql table: Equipmen, these match the 
        //column names in the SQL table
        //not all columns are used in this program. 
        [PrimaryKey, AutoGen]
        public int EquipmenId { get; set; }
        public string Code { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Name { get; set; } = default!;

    }
}

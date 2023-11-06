using WahooORM;

namespace DataEntryConsole
{
    public class Inventor : ObservableWahooRecord
    {
        //properties of the sql table: Inventor, these match the 
        //column names in the SQL table
        [PrimaryKey, AutoGen]
        public int InventorId { get; set; }
        public string Code { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Units { get; set; } = default!;
        public decimal? Price { get; set; }
        public decimal? FixedSellPrice { get; set; }
        private int? _imageID;
        public int? ImageID
        {
            get => _imageID;
            set => SetProperty(ref _imageID, value);
        }

        public string Category { get; set; } = default!;
        public string ManufactureNbr { get; set; } = default!;

        private string? _scanCode;
        public string? ScanCode
        {
            get => _scanCode;
            set => SetProperty(ref _scanCode, value);
        }
    }
}

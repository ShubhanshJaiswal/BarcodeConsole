using WahooORM;
namespace DataEntryConsole
{
    public class BarCodeTrans : ObservableWahooRecord
    {
        //properties of the sql table: BarCodeTrans, these match the 
        //column names in the SQL table
        [PrimaryKey, AutoGen]
        public int BarCodeTransId { get; set; }
        private DateTime _effDate;
        public DateTime EffDate
        {
            get => _effDate;
            set => SetProperty(ref _effDate, value);
        }
        private int _transType;
        public int TransType
        {
            get => _transType;
            set => SetProperty(ref _transType, value);
        }
        private int _invCodeId;
        public int InvCodeId
        {
            get => _invCodeId;
            set => SetProperty(ref _invCodeId, value);
        }
        private int? _refType;
        public int? RefType 
        {
            get => _refType;
            set => SetProperty(ref _refType, value);
        }
        private int? _refValueOne;
        public int? RefValueOne 
        {
            get => _refValueOne;
            set => SetProperty(ref _refValueOne, value);
        }
        private int? _refValueTypeTwo;
        public int? RefValueTwo 
        {
            get => _refValueTypeTwo;
            set => SetProperty(ref _refValueTypeTwo, value);
        } 
        private decimal? _quantity;
        public decimal? Quantity 
        { 
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }
        private decimal? _amount;
        public decimal? Amount 
        { 
            get => _amount;
            set => SetProperty(ref _amount, value);
        }
        private int _userId;
        public int UserId 
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }

    }

    public enum BarCodeTransType
    {
        Charge, Receive, Physical
    }
    public enum BarCodeReferenceType
    {
        Equipment, Account, WorkOrder, PurchaseOrder
    }
}

//var trans = BarTransList.NewRow();
//trans.EffDate = DateTime.Now;
//trans.RefType = 1;
//trans.Quantity = 2.5M;
//trans.Amount = decimal.Zero;
//trans.RefVal = 23;
//trans.InvCodeId = 5;
//trans.TransType = 1;
//trans.UserId = 12;

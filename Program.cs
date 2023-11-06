
using DataEntryConsole;

var forever = true;

Console.WriteLine();
//Screen.DisplayList(conlist);
Console.WriteLine();

while(forever)
{
    Console.Clear();
    //Screen.DisplayBanner(Ip, Port);
    Console.WriteLine();
    Screen.DisplayMenu();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    var key= Console.ReadKey(true);
    
   switch(key.KeyChar)
    {
        case 'x':
        case 'X':
            forever = false;
           break;
       
        case 'l':
        case 'L':
            //grabs the entire inventory table and
            await GetList.GetInventorList();
            //goes through each item and displays it
            foreach(var item in GetList.InventorList.Rows)
            {
                Screen.ShowInventory(item);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            break;
        case 'v':
        case 'V':
            {
                //grabs the entire BarCodeTrans table and 
                await GetList.GetTransList();
                //goes through each item and displays the effective date
                foreach (var item in GetList.BarTransList.Rows)
                {
                    Screen.ShowBarCodeTrans(item);
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
            }
            break;
        case 'c':
        case 'C':
            {
                //deletes every row from the BarCodeTrans table 
                Console.WriteLine("Deleting all transactions");
                Delete.DeleteAll();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
            }
            break;
        case 'U':
        case 'u':
            {
                Console.WriteLine("Enter Inventory code to lookup: ");
                //code can be null as not every lookup will have a value
                var code =Console.ReadLine();
                //uncomment out the line youy want to lookup
                var id= await Lookup.LookupInventory(code);
                //var id = await Lookup.LookupEquipment(code);
                //var id = await Lookup.LookupWorkOrder(code);
                //var id = await Lookup.LookupPurchaseOrder(code);
                //var id = await Lookup.LookupAccount(code);
                Console.WriteLine($"Id= {id}");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
            }
            break;
        case 'w':
        case 'W':
            {
                //creates a new row in the BarCodeTrans table with hard coded data
                Console.WriteLine("Writing one transactions");
                WriteBarCodeTrans.WriteOne();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
            }
            break;
    }

}
// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory2

{
    class InventoryItem
    {
        //class properties
        public string Id { get; set; }
        public string ItemName { get; set; }
        public int StartingQty { get; set; }
        public int QtyMinRestock { get; set; }
        public int QtySold { get; set; }
        public int QtyRestocked { get; set; }
        public decimal UnitPrice;
        public int QtyHand { get { return (StartingQty - QtySold + QtyRestocked); } }
        public decimal TotalSales { get { return (QtySold * UnitPrice); } }

        public InventoryItem(string id, string itemName, int startingQty, int qtyMinRestock, int qtySold,
            int qtyRestocked, decimal unitPrice) // constructor
        {
            Id = id;
            ItemName = itemName;
            StartingQty = startingQty;
            QtyMinRestock = qtyMinRestock;
            QtySold = qtySold;
            QtyRestocked = qtyRestocked;
            UnitPrice = unitPrice;
        }

        public override string ToString()  //Each inventory item output to listBox formated with String.Format
        {
            string outputStr = "";
            outputStr += String.Format("{0,-14}", Id)
                        + String.Format("{0,-25}", ItemName)
                        + String.Format("{0,-14}", StartingQty)
                        + String.Format("{0,-14}", QtyMinRestock)
                        + String.Format("{0,-10}", QtySold)
                        + String.Format("{0,-12}", QtyRestocked)
                        + String.Format("{0,-10:C}", UnitPrice)
                        + String.Format("{0,-10}", QtyHand)
                        + String.Format("{0,-10:C}", TotalSales);
            return outputStr;
        }

        public string ToString(char delim) //SaveInventory File output
        {
            string outputStr = "";
            outputStr += Id + delim
                        + ItemName + delim
                        + StartingQty + delim
                        + QtyMinRestock + delim
                        + QtySold + delim
                        + QtyRestocked + delim
                        + UnitPrice.ToString("F2");
            return outputStr;
        }

        public string ToString(int i) //SalesReport File output
        {
            char delim = ',';
            string outputStr = "";
            outputStr +=  Id + delim
                        + ItemName + delim
                        + QtySold + delim
                        + UnitPrice.ToString("C") + delim
                        + TotalSales.ToString("C");
            return outputStr;
        }

        public string ToString(int i, int j) //RestockReport File output
        {
            char delim = ',';
            string outputStr = "";
            outputStr +=  Id + delim
                        + ItemName + delim
                        + QtyMinRestock + delim
                        + QtyHand;
            return outputStr;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Student:Luis Araujo

namespace Inventory2
{
    public partial class Form1 : Form
    {
        List<InventoryItem> inventoryList = new List<InventoryItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadInventoryDataButton_Click(object sender, EventArgs e)
        {
            ReadFromFile("inventory_ip.csv"); // setting the file which information will be showed to listBox
            statusLabel.Text = "Read " + inventoryList.Count + " Items from the file.."; //update status label
            LoadAllItemsToListBox(); //load from list to listbox
        }

        private void ReadFromFile(string FileName)
        {
            inventoryList = new List<InventoryItem>(); //resetting the list to empty
            using (StreamReader myInputStream = new StreamReader(FileName))
            {
                string eachLine;
                if (!myInputStream.EndOfStream)
                {
                    eachLine = myInputStream.ReadLine(); //first line of input
                }
                while (!myInputStream.EndOfStream) // test if reached the end of file
                {
                    eachLine = myInputStream.ReadLine();

                    string[] fieldsArray = eachLine.Split(','); //split the array within ',' as delimiter
                    string id = fieldsArray[0];
                    string itemName = fieldsArray[1];
                    int startingQty = int.Parse(fieldsArray[2]);
                    int qtyMinRestock = int.Parse(fieldsArray[3]);
                    int qtySold = int.Parse(fieldsArray[4]);
                    int qtyRestocked = int.Parse(fieldsArray[5]);
                    decimal unitPrice = decimal.Parse(fieldsArray[6]);

                    InventoryItem eachItem = new InventoryItem(id, itemName, startingQty, qtyMinRestock, qtySold, qtyRestocked, unitPrice); // instantiate object
                    inventoryList.Add(eachItem); //adding each item to the List
                }
            }
            //Note: No return list here because method is void.
        }

        private void LoadAllItemsToListBox()
        {
            inventoryListBox.Items.Clear(); //clears the listbox
            string outputStr = "";
            outputStr += String.Format("{0,-14}", "Id")
                        + String.Format("{0,-25}", "Item Name")
                        + String.Format("{0,-14}", "StartingQty")
                        + String.Format("{0,-14}", "QtyMinRestck")
                        + String.Format("{0,-10}", "QtySold")
                        + String.Format("{0,-12}", "QtyRestckd")
                        + String.Format("{0,-10}", "UnitPrice")
                        + String.Format("{0,-10}", "QtyHand")
                        + String.Format("{0,-10}", "Sales");
            inventoryListBox.Items.Add(outputStr); // create a header
            foreach (InventoryItem eachInventoryItem in inventoryList) // load each item on the listBox
            {
                string eachElem = eachInventoryItem.ToString();
                inventoryListBox.Items.Add(eachElem); //show each item
            }
        }

        private void updateSoldQtyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int qttyInput = 0;
                int.TryParse(qtySoldBox.Text, out qttyInput);
                int i = inventoryListBox.SelectedIndex;

                if (inventoryListBox.SelectedIndex == -1 || inventoryListBox.SelectedIndex == 0)
                {
                    statusLabel.Text = "Please selected an inventory item to increment sold qty";
                }
                else if ((!(int.TryParse(qtySoldBox.Text, out qttyInput)) || (qttyInput <= 0) || (qttyInput > inventoryList[i - 1].QtyHand))) // test the conditions for update sold qtty
                {
                    if (!(int.TryParse(qtySoldBox.Text, out qttyInput))) //shows relevant messages to user for this unmet condition
                    {
                        statusLabel.Text = "Error in TryParse";
                        ClearFields();
                    }
                    else if (qttyInput <= 0) //shows relevant messages to user for this unmet condition
                    {
                        statusLabel.Text = "The value is less or equal 0";
                        ClearFields();
                    }
                    else if (qttyInput > inventoryList[i - 1].QtyHand) //shows relevant messages to user for this unmet condition
                    {
                        statusLabel.Text = "The value is greater than Qty on Hand";
                        ClearFields();
                    }
                }
                else if ((qttyInput > 0) && (qttyInput <= inventoryList[i - 1].QtyHand)) // if user input is gt 0 and is less than qty in hand update the sold qty
                {
                    inventoryList[i - 1].QtySold += qttyInput;
                    statusLabel.Text = "Sold Qty has been increased for the item code: " + inventoryList[i - 1].Id;
                    LoadAllItemsToListBox();
                    ClearFields();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error in tryParse: " + ex.Message);
            }
            
        }

        private void ClearFields()
        {
            qtySoldBox.Text = "";
            qtyRestockedBox.Text = "";
        }

        private void updateRestockedQtySelectedItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int qttyInput = 0;
                int.TryParse(qtyRestockedBox.Text, out qttyInput);
                int i = inventoryListBox.SelectedIndex;

                if (inventoryListBox.SelectedIndex == -1 || inventoryListBox.SelectedIndex == 0)
                {
                    statusLabel.Text = "Please selected an inventory item to increment Restocked qty";
                }
                else if ((!(int.TryParse(qtyRestockedBox.Text, out qttyInput)) || (qttyInput <= 0))) // test if user input is correct or qty is lt 0
                {
                    if (!(int.TryParse(qtyRestockedBox.Text, out qttyInput)))
                    {
                        statusLabel.Text = "Error in TryParse";
                        ClearFields();
                    }
                    else if (qttyInput <= 0)
                    {
                        statusLabel.Text = "The value is less or equal 0";
                        ClearFields();
                    }
                }
                else // increment restocked items
                {
                    inventoryList[i - 1].QtyRestocked += qttyInput;
                    LoadAllItemsToListBox();
                    statusLabel.Text = "Incremented Restocked Qty for item with item code: " + inventoryList[i - 1].Id;
                    ClearFields();
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Error in tryParse: " + ex.Message);
            }
        }

        private void deleteSelectedInventoryItemButton_Click(object sender, EventArgs e)
        {
            int i = inventoryListBox.SelectedIndex;

            if (inventoryListBox.SelectedIndex == -1 || inventoryListBox.SelectedIndex == 0)
            {
                statusLabel.Text = "Please selected an inventory item to delete";
            }else
            {
                statusLabel.Text = "Deleted Item with code: " + inventoryList[i - 1].Id;
                inventoryList.Remove(inventoryList[i - 1]); //deleting item in the list box
                LoadAllItemsToListBox();
                ClearFields();
            }

            
        }

        private void WriteToFile(string fileName)
        {
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter(fileName))
                {
                    char delim = ',';
                    string outputStr = "";
                    outputStr += "Id" + delim
                                + "Item Name" + delim
                                + "StartingQty" + delim
                                + "QtyMinRestck" + delim
                                + "QtySold" + delim
                                + "QtyRestckd" + delim
                                + "UnitPrice";
                                
                    myOutputStream.WriteLine(outputStr); // write a header

                    foreach (InventoryItem item in inventoryList)
                    {
                        myOutputStream.WriteLine(item.ToString(',')); // print each item with the correct delimiter
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Contents cannot be written to file: " + ex.Message);
            }

        }

        private void saveInventoryDataButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Inventory";
            //CLICKED OK OR CANCEL MESSAGE
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                WriteToFile(saveFileDialog1.FileName);
                statusLabel.Text = "Written " + inventoryList.Count + " Items to the file"; //status label update
            } else
            {
                MessageBox.Show("Save Inventory Operation was cancelled");
            }
            
        }

        private void saveSalesReportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Sales Report";
            //CLICKED OK OR CANCEL MESSAGE
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                WriteToFileSalesReport(saveFileDialog1.FileName, out int counter);
                statusLabel.Text = "Saved " + counter + " records into the output sales file"; //status label update
            }
            else
            {
                MessageBox.Show("Save Sales Report Operation was cancelled");
            }
            
        }

        private void WriteToFileSalesReport(string fileName, out int counter)
        {
            counter = 0;
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter(fileName))
                {
                    char delim = ',';
                    string outputStr = "";
                    outputStr += "Id" + delim
                                + "Item Name" + delim
                                + "QtySold" + delim
                                + "UnitPrice" + delim
                                + "Sales";
                    myOutputStream.WriteLine(outputStr); // writing header in the file

                    foreach (InventoryItem item in inventoryList)
                    {
                        if (item.QtySold > 0)
                        {
                            myOutputStream.WriteLine(item.ToString(1)); // print each item in one line
                            counter++;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Contents cannot be written to file: " + ex.Message);
            }

        }

        private void saveRestockNeedsReportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Restock Needs Report";
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                WriteToFileRestockReport(saveFileDialog1.FileName, out int counter);
                statusLabel.Text = "Saved " + counter + " records into the Restock needed output file"; //status label update
            }
            else
            {
                MessageBox.Show("Save Restock Needs Report Operation was cancelled");
            }
            
        }

        private void WriteToFileRestockReport(string fileName, out int counter)
        {
            counter = 0;
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter(fileName))
                {
                    char delim = ',';
                    string outputStr = "";
                    outputStr += "Id" + delim
                                + "Item Name" + delim
                                + "QtyMinRestck" + delim
                                + "QtyHand";

                    myOutputStream.WriteLine(outputStr);

                    foreach (InventoryItem item in inventoryList)
                    {
                        if (item.QtyHand < item.QtyMinRestock)
                        {
                            myOutputStream.WriteLine(item.ToString(1, 1)); //print each item in the file
                            counter++; //increment after adding each line in the file, this will be used in the statusLabel
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Contents cannot be written to file: " + ex.Message);
            }

        }
    }
}

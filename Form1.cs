using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Text.RegularExpressions;
using CsvHelper.Configuration;

/************************************************************************************************
 * Author:          Chris Boseak
 * Description:     takes a csv file that has area code, exchange code,
 *                  and carrier information and search for values that
 *                  match the number entered. 
 * 
 * CSV format should be {area code, exchange, empty row, carrier, carrier band, text domain}  
 *  
 * TO DO items:     regex validation for phone number, ability to save output file,
 *                  ability to process numbers in batch, checkbox to decide to continue
 *                  to append the output box or clear on each run. 
************************************************************************************************/


namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Stream myStream = null;
        private String openPath;
        private String phoneNum;

        //made global so it could be accessed by both classes, if I was to do it over again, I would have had the csv
        //class inherit from this class so I could have made this private
        public static List<Provider> ProvList = new List<Provider>(); 

        private void NumberInput_TextChanged(object sender, EventArgs e)
        {
            //sets max length of textbox to 10
            NumberInput.MaxLength = 12;
            phoneNum = NumberInput.Text;

            // ****TO DO: Implement RegEx for number checking**** //
            //waits for full number to be entered before formatting, this specifically checks if the 4th char is 
            //a hyphen so it knows if the user is entering the number in xxx-xxx-xxxx format
            //this leaves room for error so regex would be best in this case

            if (NumberInput.Text.Length >= 10 && NumberInput.Text.Substring(3,1) != "-")
            {
                //formats number to standard xxx-xxx-xxxx format if only 10 digits
                if (NumberInput.Text.Length == 10)
                {
                    NumberInput.Text = String.Format("{0}-{1}-{2}", phoneNum.Substring(0, 3), phoneNum.Substring(3, 3),
                        phoneNum.Substring(6));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //stores the path of the opened file into a string so it can be used later
                            openPath = Path.GetDirectoryName(openFileDialog1.FileName) + "\\" + Path.GetFileName(openFileDialog1.FileName);

                            //reads all lines from CSV and stores them into a List of Provider Objects
                            var lines = File.ReadLines(openPath);
                            foreach (var i in lines)
                            {
                                //sends line to function that will add each comma separated value to an object list so it 
                                //can later be searched.
                                Provider.FromCsv(i);
                            }

                            //uses our previously stored value to display the file directory in the openfile dialog text area
                            LoadFileTextBox.Text = openPath;
                        }
                    }
                }
                catch (Exception)
                {
                    //generic exception handling, I may later add it so it handles each exception differently but this is good for now
                    MessageBox.Show("Error: Could not read file.");
                }
            }

        }

        private void LookupNumButton_Click(object sender, EventArgs e)
        {
            //checks if there is a valid number and if the file has been loaded.
            if (openPath != null && NumberInput.TextLength == 12)
            {
                //clears box when new lookup is done
                ProviderOutputBox.Clear();

                //checks for all objects where the area code and exchange match our format
                //read as "result = Provider object where area code contains area code in phone number
                //and exchange code equals exchange code in phone number. 
                var result = ProvList.Where(x => x.AreaCode.Contains(phoneNum.Substring(0, 3))).Where(x => x.ExchangeCode.Contains(phoneNum.Substring(4, 3))).ToList();

                foreach (var i in result)
                {
                    //output to textbox line by line of each property in all object that match our criteria
                    ProviderOutputBox.AppendText("Area Code: " + i.AreaCode + "\n");
                    ProviderOutputBox.AppendText("Exchage Code: " + i.ExchangeCode + "\n");
                    ProviderOutputBox.AppendText("Carrier: " + i.ProviderName + "\n");
                    ProviderOutputBox.AppendText("Carrier Type: " + i.ProviderType + "\n");
                    ProviderOutputBox.AppendText("SMS/MMS Domain " + i.TextDomain + "\n");
                    ProviderOutputBox.AppendText("------------------------------------------" + "\n");
                }
            }
        }
    }


    public class Provider
    {
        //class properties
        public string AreaCode { get; set; }
        public string ExchangeCode { get; set; }
        public string ProviderName { get; set; }
        public string ProviderType { get; set; }
        public string TextDomain { get; set; }

        public static void FromCsv(string csvLine)
        {
            //separate items in line by comma and assign to values in new object
            string[] values = csvLine.Split(',');
            Provider newProv = new Provider();
            newProv.AreaCode = values[0];
            newProv.ExchangeCode = values[1];
            newProv.ProviderName = values[3];
            newProv.ProviderType = values[4];
            newProv.TextDomain = values[5];
            
            //add object to object list
            Form1.ProvList.Insert(Form1.ProvList.Count,newProv);
        }
    }
}

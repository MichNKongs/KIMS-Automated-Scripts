using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public class tags
        {
            public string splitMe;
            public string[] splitLine = new string[3];
            //Create Tag List
            public List<String> tagList = new List<String>();
        }

        public Form1()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            convertTagList();
            writeBat(); 
        }
        public void createTagList()
        {
            //Call Class
            tags tag = new tags();

            //Create Tag List
            List<String> tagList = new List<String>();

            //Temp String
            string tempString;

            // Open the file into a streamreader and populate tag list
            using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\TEMP\\tagnames1.txt"))
            {
                while (!sr.EndOfStream) // Keep reading until end of file
                {
                    tag.splitMe = sr.ReadLine();             //Read that shit
                    tag.splitLine = tag.splitMe.Split(null); //Split at the spaces
                    tempString = tag.splitLine[1];           //Each separation goes into it's own index
                    tagList.Add(tempString);                 //Add Middle column

                    //Testing
                    /*foreach (String test in tagList)
                    {
                        Console.WriteLine(test);
                    }*/
                }
            }
        }

        public void convertTagList()
        {
            //Call Class
            tags tag = new tags();
            
            
            string tempString;
            // Open the file, read and convert list
            using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\TEMP\\tagnames1.txt"))
            {
                while (!sr.EndOfStream) // Keep reading until we get to the end
                {
                    tag.splitMe = sr.ReadLine();
                    tag.splitLine = tag.splitMe.Split(null);        //Split at the spaces
                    tempString = tag.splitLine[1];                  //Assign temp var
                    tempString = tempString.Replace('/', '_');      //Replace characters
                    //Console.WriteLine(tempString);
                    tag.tagList.Add(tempString);                        //Add to da list
                    /*foreach (String test in tag.tagList)
                    {
                        Console.WriteLine(test);
                    }*/

                    Console.Write(tag.tagList[0]);                  //This prints fucking everything
                }
            }
        }

        public void writeBat()
        {
            //Call Class
            tags tag = new tags();

            //Console.Write(tag.tagList[0]);
            string tempString;
            //tempString = tagList; 
            //C:\Program Files\RAPID\bin>DumpEvents.exe /o d:\rapidexport\WIT-CT308_Meas1_PRIM.csv /c /b %rapidboot% /i WIT-CT308/Meas1/PRIM /s %oldestarc% /e %newestarc%
            string cat1 = @"C:\Program Files\RAPID\bin>DumpEvents.exe /o d:\rapidexport\";
            //string cat2 = tag.tagList[0];
            string cat3 = " /c /b %rapidboot% /i WIT-CT308/Meas1/PRIM /s %oldestarc% /e %newestarc%";

            //string lines = cat1 + cat2 + cat3;

            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllText(@"C:\TEMP\WriteText.txt", lines);
            // Compose string including list variables
            /* string[] test = { "echo\n", "test" };
             //string line2 = "test";

             // Write the string to a file.
             System.IO.File.WriteAllText(@"C:\\TEMP\\WriteText.txt", test);*/
            //file.Close();

            //This is going to get hairy
            //string lines = cat1 + 
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllLines(@"C:\\TEMP\\WriteText.txt", lines);
        }
    }
}

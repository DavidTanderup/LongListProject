using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LongListLibrary
{
    public class Class1
    {
    }

    public class List
    {

        List<Tuple<string, bool>> MyList = new List<Tuple<string, bool>>();

        /// <summary>
        /// Adds a new item to the list and then updates the Data File
        /// t.2 is set to false indicating the item has not been completed.
        /// </summary>
        
        public void AddThingsToMyList(string userInput)
        {
            
            Files files = new Files();

            Console.WriteLine("");
            
            userInput = Console.ReadLine();

            MyList.Add(new Tuple<string, bool>(userInput, false));

            files.SaveItem(MyList);

        }
       
        /// <summary>
        /// Removes the items from the specified location on the list.
        /// </summary>

        public void RemoveThingsFromMyList(List<Tuple<string,bool>> MyList, int indexNumber)
        {
            MyList.RemoveRange(0, indexNumber);

        }




    }




    public class Files
    {
        // Ref: stackoverflow.com/questions/20823698/c-sharp-serialize-deserialize-or-save-
        //      load-a-list-of-tuples




        /// <summary>
        /// Saves the changes made to the data file
        /// </summary>

        public void SaveItem(List<Tuple<string,bool>> MyList)
        {

            FileStream stream = new FileStream(@"C:\Users\David Tanderup\Desktop\Data2.dat", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, MyList);

            stream.Close();
        }


    }





}

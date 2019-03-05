using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using LongListLibrary;

namespace LongList
{
    class Program
    {
        static void Main(string[] args)
        {
                           
                      
                        
            
            // Creation of the master list.
            List<Tuple<string, bool>> MyList = new List<Tuple<string, bool>>();
     

            // The call to add new things to the list.
            MyList.Add(new Tuple<string, bool>("Jim",true));

 
            // unpack a Tuple
            var myTuple = MyList[0];
            var row = myTuple.Item1;  // value of 0
            var col = myTuple.Item2;  // value of 1

            Console.WriteLine(row);



            MyList.Insert(0, new Tuple<string, bool>( "cat", true ));
            
            // Remove items from the list
            MyList.RemoveRange(0,3);


            // Ref: stackoverflow.com/questions/20823698/c-sharp-serialize-deserialize-or-save-load-a-list-of-tuples
            
            FileStream stream = new FileStream(@"C:\Users\David Tanderup\Desktop\Data2.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, MyList);
            stream.Close();
            
            Console.WriteLine("Load filename.dat...");
            FileStream inStr = new FileStream(@"C:\Users\David Tanderup\Desktop\Data2.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            MyList = bf.Deserialize(inStr) as List<Tuple<string, bool>>;
            Console.WriteLine($"{MyList[0]} {MyList.Count()}" );
            
            //File.Open(@"C:\Users\David Tanderup\Desktop\Data.txt",FileMode.OpenOrCreate).Close();

            //File.(@"C:\Users\David Tanderup\Desktop\Data.txt", MyList);
            
            Console.ReadLine();
        }
    }
    public class BigLongList
    {



    }
}

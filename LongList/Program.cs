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


            //Files files = new Files();

            //List<Tuple<string, bool>> MyList = files.LoadItem();

            //foreach (Tuple<string, bool> item in MyList)
            //{
            //    Console.WriteLine($"{item.Item1}");
            //}


            MainMenu mM = new MainMenu();
            bool displayMenu = true;
            while (displayMenu)
            {
                mM.WelcomeToYourList();
                displayMenu = mM.MainMenuUserInput();

            }


            // Add Input selection method


            //ClassLists cL = new ClassLists();
            //Files files = new Files();
            //ProgramLaunch pL = new ProgramLaunch();


            //foreach (Tuple<string, bool> item in MyList)
            //{
            //    Console.WriteLine($"{item.Item1}");
            //}












            /*
            
            Console.Write("Enter Item: ");
            string userInput = Console.ReadLine();

            cL.AddThingsToMyList(userInput);

                                                     
            //List<Tuple<string, bool>> MyList = files.LoadItem();
            MyList.Add(new Tuple<string, bool>("Jim",false));
            files.SaveItem(MyList);


            int index = 1;
            int count;
            if (MyList.Count() > 25)
            {
                count = 25;
            }
            else
            {
                count = MyList.Count();
            }
            int i = 0;
            while (count > 0)
            {
                var tuple = MyList[i];
                string x = tuple.Item1;
                bool y = tuple.Item2;
                if (y != true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n\t{index} {tuple.Item1}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"\n\t{index} {tuple.Item1}");
                }
                count--;
                index++;
                i++;
            }
            
            


                */
            Console.Clear();
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();








        }







    }







}

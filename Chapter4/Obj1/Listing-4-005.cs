using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Obj1
{
    public static class Listing_4_005
    {
        public static void RunMain()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\");
            ListDirectories(directoryInfo,"*",3,0);


            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        private static void ListDirectories(DirectoryInfo directoryInfo, 
            string searchPattern, 
            int maxLevel, 
            int currentLevel)
        {
            if (currentLevel >= maxLevel)
            {
                return;
            }

            string indent = new string('-', currentLevel);

            try
            {
                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories(searchPattern);

                foreach (var subDirectory in subDirectories)
                {
                    Console.WriteLine(indent + subDirectory.Name);
                    ListDirectories(subDirectory,searchPattern,maxLevel,currentLevel+1);
                }

            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(indent + "Can't access: " + directoryInfo.Name);

                return;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(indent + "Can't find: " + directoryInfo.Name);

                return;
            }
        }
    }
}
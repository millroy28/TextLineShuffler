using System;

namespace TextLineShuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            bool fileExists = false;
            string fileName; string newFileName;
            
            while (run)
            {
                fileName = UX.PromptAndGetFileName();
                fileExists = FileIO.CheckFileExists(fileName);

                while (run && !fileExists)
                {

                    if (!fileExists)
                    {
                        run = UX.NotifyFileFailure();
                    }
                    if (run)
                    {
                        fileName = UX.PromptAndGetFileName();
                        fileExists = FileIO.CheckFileExists(fileName);
                    }
                }

                if (run)
                {
                    newFileName = FileIO.ShuffleFile(fileName);
                    UX.NotifySuccess(newFileName);
                    run = UX.PromptAndGetYesNo("Shuffle another?");
                }

            }



        }
    }
}

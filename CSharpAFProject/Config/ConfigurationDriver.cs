using System;

namespace CSharpAFProject.Config
{
    public class ConfigurationDriver
    {

        bool toDelete = false;

        public void getConfig() {
        string Mode = Environment.GetEnvironmentVariable("Test_Browser");
            if (Mode == null)
            {
                Environment.SetEnvironmentVariable("Test_Browser", "Testing");
                toDelete = true;

                // Now retrieve it.
                Mode = Environment.GetEnvironmentVariable("Test_Browser");
            }
            Console.WriteLine(Mode);
        } 
}
}

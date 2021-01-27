using SyntraABTools.Plugins;
using System;

namespace AppCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            PluginTools plugins = new PluginTools();

            foreach (string item in args)
            {
                Console.WriteLine($"Application arguments: {item}");
            }

            try
            {
                if (plugins.LoadPlugin(args?.Length > 0 ? args[0] : null) == true)
                {
                    Console.WriteLine("Plugin is loaded");

                    Console.WriteLine($"Plugin name: {plugins.Plugin.FullName}");
                }
                else
                {
                    Console.WriteLine("Plugin is NOT found");
                }   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

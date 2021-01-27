using AppWPF.ViewModels.Commands;
using SyntraABTools.Plugins;
using SyntraABTools.WPF;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace AppWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        // PLUGINS
        private PluginTools _plugins = new PluginTools();
        public PluginTools Plugins { get => _plugins; set => _plugins = value; }


        // PROPERTIES
        public string _customPlugin = "Not any";
        public string CustomPlugin // BINDED MODE: ONE-WAY
        {
            get
            {
                return _customPlugin;
            }
            set
            {
                _customPlugin = value;
                this.Notify();
            }
        }

        // CONSTRUCTOR
        public MainViewModel()
        {
            try
            {
                if (Plugins.LoadPlugin(GetApplicationArguments) == true)
                {
                    MessageBox.Show($"Plugin {Plugins.Plugin.FullName} is loaded");
                    CustomPlugin = Plugins.Plugin.FullName.ToString();
                }
                else
                {
                    MessageBox.Show($"Plugin is NOT found");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}");
            }
        }


        public string GetApplicationArguments
        {
            get
            {
                string[] args = Environment.GetCommandLineArgs();

                // DEV
                //string output = string.Empty;
                //foreach (string item in args)
                //{
                //    output += item + "\n";
                //}
                //MessageBox.Show(output);

                string lastItem = args[args.Length - 1]; // value from [ Project > Debug > Application arguments ] is stored in last item

                Debug.WriteLine($"{lastItem}"); // Application arguments

                return lastItem;
            }
        }
    }
}

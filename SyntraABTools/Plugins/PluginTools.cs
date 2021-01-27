using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace SyntraABTools.Plugins
{
    public class PluginTools
    {
        private Assembly _plugin = null;

        public Assembly Plugin
        {
            get
            {
                return _plugin;
            }
            set
            {
                _plugin = value;
            }
        }

        public bool LoadPlugin(string path)
        {
            if (path != null && File.Exists(path))
            {
                Debug.WriteLine($"File found");

                Plugin = Assembly.LoadFrom(path);
                return Plugin != null;
            }
            else
            {
                Debug.WriteLine($"File NOT found");

                return false;
            }
        }
    }
}

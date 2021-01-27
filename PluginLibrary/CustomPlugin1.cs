using System;
using System.Collections.Generic;
using System.Text;

namespace PluginLibrary
{
    public class CustomPlugin1
    {
        // normaly you would use dependencies in the projects that use this library
        // with reflection we can load assemblies that are not known in the current assemblies
        // once loaded it will be added to the reference list of the app
        // this assembly can not be released as long as the current app runs


        private string _updateMessage = "안녕하세요";
        public string UpdateMessage { get => _updateMessage; set => _updateMessage = value; }

        public CustomPlugin1()
        {

        }



    }
}

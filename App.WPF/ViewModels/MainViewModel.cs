using SyntraABTools.WPF;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {


        public string _userName = "Benny";
        public string UserName // BINDED MODE: ONE-WAY
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                this.Notify();
            }
        }


        public MainViewModel()
        {
            //MessageBox.Show($"Hello World");

            try
            {

                //rTool.LoadAssembly(args)
            }
            catch (Exception e)
            {

            }
        }

    }
}

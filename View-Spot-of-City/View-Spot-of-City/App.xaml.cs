﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using View_Spot_of_City.helper;
using View_Spot_of_City.UIControls.helper;
using View_Spot_of_City.UIControls.Progress;

namespace View_Spot_of_City
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //验证License
            if (!RegisterMaster.CanStart())
            {
                Environment.Exit(0);
            }
            base.OnStartup(e);
        }
    }
}

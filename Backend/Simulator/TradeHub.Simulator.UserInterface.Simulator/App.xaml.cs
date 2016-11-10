﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TradeHub.SimulatedExchange.UserInterface.Simulator;

namespace TradeHub.Simulator.UserInterface.Simulator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            /*Submits Control to boobstrapper class.*/
            base.OnStartup(e);
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run(); // Shifting Control to Bootstrapper Class.
        }
    }
}
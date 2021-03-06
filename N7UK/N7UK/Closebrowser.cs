﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace N7UK
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Closebrowser recording.
    /// </summary>
    [TestModule("35c4146f-e9b2-4796-87e8-64c2982134a1", ModuleType.Recording, 1)]
    public partial class Closebrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the N7UKRepository repository.
        /// </summary>
        public static N7UKRepository repo = N7UKRepository.Instance;

        static Closebrowser instance = new Closebrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Closebrowser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Closebrowser Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.hearyourway.com/wps/wcm/connect/uk/n7/home' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            //Host.Current.OpenBrowser("http://www.hearyourway.com/wps/wcm/connect/uk/n7/home", "chrome", "", false, false, false, false, false);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.ClinicFinder'.", repo.CochlearImplantSoundProcessorNucleus.ClinicFinderInfo, new RecordItemIndex(1));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.ClinicFinderInfo);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus1' at 1889;12.", repo.CochlearImplantSoundProcessorNucleus1.SelfInfo, new RecordItemIndex(2));
            //repo.CochlearImplantSoundProcessorNucleus1.Self.Click("1889;12");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'CochlearImplantSoundProcessorNucleus1'.", repo.CochlearImplantSoundProcessorNucleus1.SelfInfo, new RecordItemIndex(3));
            Host.Current.CloseApplication(repo.CochlearImplantSoundProcessorNucleus1.Self, 1000);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

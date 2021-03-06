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
    ///The Upgrade_Slider02 recording.
    /// </summary>
    [TestModule("1fa5cd3f-301f-479c-8e27-6c02d0ed7f4e", ModuleType.Recording, 1)]
    public partial class Upgrade_Slider02 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the N7UKRepository repository.
        /// </summary>
        public static N7UKRepository repo = N7UKRepository.Instance;

        static Upgrade_Slider02 instance = new Upgrade_Slider02();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Upgrade_Slider02()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Upgrade_Slider02 Instance
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo, new RecordItemIndex(1));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade' at 47;9.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo, new RecordItemIndex(2));
            repo.CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade.Click("47;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo, new RecordItemIndex(3));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'CochlearImplantSoundProcessorNucleus' at 1909;44.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(4));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1909;44");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'CochlearImplantSoundProcessorNucleus' at 1909;652.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(5));
            repo.CochlearImplantSoundProcessorNucleus.Self.MoveTo("1909;652");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://www.hearyourway.com/wps/wcm/connect/6091a507-7005-4289-a186-0aff689e415c/video_placeholder_locate_my_processor.jpg?MOD=AJPERES&CACHEID=ROOTWORKSPACE-6091a507-7005-4289-a186-0aff689e415c-lRhKArn') on item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.HttpWwwHearyourwayComWpsWcmConne1'.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.HttpWwwHearyourwayComWpsWcmConne1Info, new RecordItemIndex(6));
            //Validate.AttributeEqual(repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.HttpWwwHearyourwayComWpsWcmConne1Info, "Src", "http://www.hearyourway.com/wps/wcm/connect/6091a507-7005-4289-a186-0aff689e415c/video_placeholder_locate_my_processor.jpg?MOD=AJPERES&CACHEID=ROOTWORKSPACE-6091a507-7005-4289-a186-0aff689e415c-lRhKArn");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1' at 24;20.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1Info, new RecordItemIndex(7));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1.Click("24;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1' at 24;20.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1Info, new RecordItemIndex(8));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1.Click("24;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1' at 24;20.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1Info, new RecordItemIndex(9));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1.Click("24;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1' at 24;20.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1Info, new RecordItemIndex(10));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1.Click("24;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1' at 24;20.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1Info, new RecordItemIndex(11));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1.Click("24;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1' at 24;20.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1Info, new RecordItemIndex(12));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronLeft1.Click("24;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1' at 33;17.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1Info, new RecordItemIndex(13));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1.Click("33;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1' at 33;17.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1Info, new RecordItemIndex(14));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1.Click("33;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1' at 33;22.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1Info, new RecordItemIndex(15));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1.Click("33;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1' at 33;26.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1Info, new RecordItemIndex(16));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1.Click("33;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1' at 33;27.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1Info, new RecordItemIndex(17));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1.Click("33;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1' at 33;27.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1Info, new RecordItemIndex(18));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.TypcnTypcnChevronRight1.Click("33;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag1' at 3;6.", repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag1Info, new RecordItemIndex(19));
            repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag1.Click("3;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag3' at 5;9.", repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag3Info, new RecordItemIndex(20));
            repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag3.Click("5;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag2' at 6;8.", repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag2Info, new RecordItemIndex(21));
            repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag2.Click("6;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag1' at 1;6.", repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag1Info, new RecordItemIndex(22));
            repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag1.Click("1;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag' at 7;9.", repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTagInfo, new RecordItemIndex(23));
            repo.CochlearImplantSoundProcessorNucleus.CarouselIndicators.SomeLiTag.Click("7;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CochlearImplantSoundProcessorNucleus.CarouselVideo.BtnPlay2' at 85;83.", repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.BtnPlay2Info, new RecordItemIndex(24));
            repo.CochlearImplantSoundProcessorNucleus.CarouselVideo.BtnPlay2.Click("85;83");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus'.", repo.CochlearImplantSoundProcessorNucleus.SelfInfo, new RecordItemIndex(25));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.SelfInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UpgradeToCochlearImplantSoundProces' at 26;65.", repo.UpgradeToCochlearImplantSoundProces.SelfInfo, new RecordItemIndex(26));
            repo.UpgradeToCochlearImplantSoundProces.Self.Click("26;65");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'CochlearImplantSoundProcessorNucleus.UtilityNav.Upgrade'.", repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo, new RecordItemIndex(27));
            Validate.Exists(repo.CochlearImplantSoundProcessorNucleus.UtilityNav.UpgradeInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

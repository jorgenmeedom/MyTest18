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

namespace MyTest18
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("edd9fb28-7ec8-4a02-87aa-bbcab03cb370", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest18Repository repository.
        /// </summary>
        public static MyTest18Repository repo = MyTest18Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.TxtUserName' at 24;23.", repo.RxMainFrame.RxTabIntroduction.TxtUserNameInfo, new RecordItemIndex(0));
            repo.RxMainFrame.RxTabIntroduction.TxtUserName.Click("24;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Testman' with focus on 'RxMainFrame.RxTabIntroduction.TxtUserName'.", repo.RxMainFrame.RxTabIntroduction.TxtUserNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.RxTabIntroduction.TxtUserName.PressKeys("Testman");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.BtnSubmitUserName' at 51;22.", repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserName.Click("51;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Welcome, Testman!') on item 'RxMainFrame.RxTabIntroduction.LblWelcomeMessage'.", repo.RxMainFrame.RxTabIntroduction.LblWelcomeMessageInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.RxMainFrame.RxTabIntroduction.LblWelcomeMessageInfo, "Text", "Welcome, Testman!");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

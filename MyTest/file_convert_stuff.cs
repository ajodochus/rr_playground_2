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

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The file_convert_stuff recording.
    /// </summary>
    [TestModule("2615ee37-af8b-4d6b-bfa0-f48686be1d47", ModuleType.Recording, 1)]
    public partial class file_convert_stuff : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static file_convert_stuff instance = new file_convert_stuff();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public file_convert_stuff()
        {
            return_string = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static file_convert_stuff Instance
        {
            get { return instance; }
        }

#region Variables

        string _return_string;

        /// <summary>
        /// Gets or sets the value of variable return_string.
        /// </summary>
        [TestVariable("ecf6e777-7c51-4c60-a9d9-e94166dfc9c7")]
        public string return_string
        {
            get { return _return_string; }
            set { _return_string = value; }
        }

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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            return_string = convert_xml_file_to_json("Projektbaum_Sperrstatus.xml");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", return_string, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

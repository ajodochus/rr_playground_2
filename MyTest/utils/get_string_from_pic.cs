/*
 * Created by Ranorex
 * User: Administrator
 * Date: 27.10.2023
 * Time: 20:31
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace MyTest.utils
{
    /// <summary>
    /// Description of get_string_from_pic.
    /// </summary>
    [TestModule("93C3B31C-CCA3-467F-93F9-4D040D56CC08", ModuleType.UserCode, 1)]
    public class get_string_from_pic : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public get_string_from_pic()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}

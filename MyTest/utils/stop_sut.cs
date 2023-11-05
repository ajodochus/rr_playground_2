/*
 * Created by Ranorex
 * User: Administrator
 * Date: 05.11.2023
 * Time: 18:29
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
using System.Diagnostics;
using System.IO;
namespace MyTest.utils
{
    /// <summary>
    /// Description of stop_sut.
    /// </summary>
    [TestModule("95C94189-CE93-45BA-B79B-D9E3E92D6ED5", ModuleType.UserCode, 1)]
    public class stop_sut : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public stop_sut()
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
            foreach (var process in Process.GetProcessesByName("target_app_for_ocr_test"))
			{
				process.Kill();
			}
        }
    }
}

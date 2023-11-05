/*
 * Created by Ranorex
 * User: Administrator
 * Date: 05.11.2023
 * Time: 18:50
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
    /// Description of data_connector_handler.
    /// </summary>
    [TestModule("B3FAA843-55E5-40F9-B89A-C5714657E342", ModuleType.UserCode, 1)]
    public class data_connector_handler : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public data_connector_handler()
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
            var curTC = TestSuite.CurrentTestContainer; //current TestCase/SmartFolder  
			//var curTC = TestSuite.Current.GetTestContainer("ContainerName"); //ContainerName = TestCase/SmartFolder name  
			var valFromCurRowAndGivenColumn = curTC.DataContext.CurrentRow.Values[curTC.DataContext.Source.Columns["name"].Index]; //returns value from current data connector row and given column
			Ranorex.Report.Info("name: " + valFromCurRowAndGivenColumn);
			
			var DC = curTC.DataContext.EffectiveRow.Values;
        }
    }
}

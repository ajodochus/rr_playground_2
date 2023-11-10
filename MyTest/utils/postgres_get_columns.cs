/*
 * Created by Ranorex
 * User: BerndW
 * Date: 10.11.2023
 * Time: 22:35
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
using postgres;

namespace MyTest.utils
{
    /// <summary>
    /// Description of postgres_get_columns.
    /// </summary>
    [TestModule("52166BB0-A462-4B5B-8D77-F245E61AFC7B", ModuleType.UserCode, 1)]
    public class postgres_get_columns : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public postgres_get_columns()
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
        	//Ranorex.Report.Info("count columns: " + postgres.postgres_handler.count_columns_of_mytable());
        	 postgres_handler.get_values_from_column();
        }
    }
}

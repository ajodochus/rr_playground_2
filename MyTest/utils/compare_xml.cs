/*
 * Created by Ranorex
 * User: Administrator
 * Date: 05.11.2023
 * Time: 18:57
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

using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;

using XmlDiffLib;
using Org.XmlUnit.Builder;
using Org.XmlUnit.Diff;

namespace MyTest.utils
{
    /// <summary>
    /// Description of compare_xml.
    /// </summary>
    [TestModule("E989CACB-C8F4-45AB-BBAE-9A38080A7A6B", ModuleType.UserCode, 1)]
    public class compare_xml : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public compare_xml()
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
        	compare_xml_files();
        }
        
        public static void compare_xml_files()
		{
			string org_directory = System.IO.Directory.GetCurrentDirectory();
			string source_xml = Path.Combine(org_directory, @"sources\_source.xml");
			string compare_xml = Path.Combine(org_directory, @"sources\_compare.xml");
			
			XmlDocument source_xml_parsed =  new XmlDocument();
			source_xml_parsed.Load(source_xml);
			
			XmlDocument compare_xml_parsed =  new XmlDocument();
			compare_xml_parsed.Load(compare_xml);
			
			var exclude_attributes = new List<string> { "", "", "some attributes to exclude from diff" };
			var exclude_nodes= new List<string> { "Data", "", "some nodes to exlude from diff" };
			
			var myDiff = DiffBuilder.Compare(Input.FromString(source_xml_parsed.InnerXml))
				.WithTest(Input.FromString(compare_xml_parsed.InnerXml))
				.WithNodeFilter(x => !exclude_nodes.Contains(x.Name))
				.WithAttributeFilter(x => !exclude_attributes.Contains(x.Name))
				.Build();
			
			var sb = new StringBuilder();
			foreach(var dif in myDiff.Differences){
				sb.AppendLine(dif.Comparison.ToString());
			}
			if (myDiff.HasDifferences()) {
				Ranorex.Report.Info("xml differs: " + sb.ToString());
			}
			
		}
    }
}

/*
 * Created by Ranorex
 * User: Administrator
 * Date: 05.11.2023
 * Time: 18:15
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
using System.Diagnostics;

namespace MyTest.utils
{
	/// <summary>
	/// Description of start_sut.
	/// </summary>
	[TestModule("1C1BA6F8-B396-47CB-A522-0DD66AA790B8", ModuleType.UserCode, 1)]
	public class start_sut : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public start_sut()
		{
			// Do not delete - a parameterless constructor is required!
		}
		static string sut_folder = Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"utils\sut");
		static	string sut = Path.Combine(sut_folder, "target_app_for_ocr_test.exe");
		
		void ITestModule.Run()
		{
			start_SUT();
		}
		
		public void start_SUT(){
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = sut;
			startInfo.WorkingDirectory = sut_folder;
			Process process;
			process = Process.Start(startInfo);
			

		}
		
		public void stop_SUT(){
			foreach (var process in Process.GetProcessesByName("target_app_for_ocr_test"))
			{
				process.Kill();
			}
		}
	}
}

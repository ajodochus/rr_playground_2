﻿/*
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
using Ranorex.Core.Repository;

using System.Diagnostics;
using System.IO;
using System.IO.Compression;

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


		static string source_path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
		static string org_directory = System.IO.Directory.GetCurrentDirectory();

		static string ocr_folder = Path.Combine(source_path, @"ocr");
		
		static	string ocr_reader_zip = "netcoreapp3.0.zip";
		static string ocr_reader_exe = @"netcoreapp3.0\Tesseract.ConsoleDemo.exe";
		static	string ocr_target_app = "target_app_for_ocr_test.exe";
		static string png_destination = Path.Combine(ocr_folder, "myimage.png");
		
		
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
		}
		
		public void ocr_element(RepoItemInfo ItemInfo)
		{
			
			Ranorex.Report.Info("exec dir: " + source_path);
			if(Directory.Exists(ocr_folder)){
				Directory.Delete(Path.Combine(source_path, @"ocr\netcoreapp3.0"), true);
			}

			System.IO.Compression.ZipFile.ExtractToDirectory(Path.Combine(ocr_folder, ocr_reader_zip), ocr_folder);
			Ranorex.Unknown repo_element = ItemInfo.CreateAdapter<Ranorex.Unknown>(true);

			//Ranorex.Unknown pictureBox1  = repo.Form1.pic_box_hello_worldInfo.CreateAdapter<Ranorex.Unknown>(true);
			//Ranorex.Unknown pictureBox2  = repo.Form1.pic_box_masterserviceInfo.CreateAdapter<Ranorex.Unknown>(true);
			//Ranorex.Unknown textbox  = repo.Form1.textboxInfo.CreateAdapter<Ranorex.Unknown>(true);
			

			SaveScreenshot(repo_element);
			ocr_and_return_string();
		}
		
		public static void SaveScreenshot(Ranorex.Unknown element)
		{
			Bitmap image = Ranorex.Imaging.CaptureDesktopImage(element);
			image.Save(png_destination, System.Drawing.Imaging.ImageFormat.Png);
		}
		
		public static void ocr_and_return_string(){
			Dictionary<string, string> result_dict = new Dictionary<string, string>();
			List<string> TIME_FORMATS = new List<string>();
			TIME_FORMATS.Add("1st row");
			TIME_FORMATS.Add("2nd row");
			TIME_FORMATS.Add("3rd row");
			TIME_FORMATS.Add("5th row");
			TIME_FORMATS.Add("6th row");
			
			int count = 0;
			
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = Path.Combine(ocr_folder, ocr_reader_exe);
			startInfo.WorkingDirectory  = Path.GetFullPath(Path.Combine( ocr_folder ,@"netcoreapp3.0"));

			startInfo.Arguments = "\"" + png_destination + "\"";

			startInfo.UseShellExecute = false;
			startInfo.RedirectStandardOutput = true;
			startInfo.CreateNoWindow = true;
			
			Process process;
			process = Process.Start(startInfo);
			string standard_output;
			while ((standard_output = process.StandardOutput.ReadLine()) != null) {
				
				if (!standard_output.IsEmpty()){
					
					//Ranorex.Report.Info("aaa" + ((++count).ToString()));
					result_dict.Add(TIME_FORMATS[count], standard_output);
					count++;
				}
			}
			
			process.WaitForExit();
			Ranorex.Report.Info(result_dict["2nd row"]);
			
			

		}
		
		public void start_SUT(){
			Ranorex.Report.Info("exe dir: " + source_path);
			Ranorex.Report.Info("org dir: " + org_directory);
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = Path.Combine(ocr_folder, ocr_target_app);
			startInfo.WorkingDirectory = ocr_folder;
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

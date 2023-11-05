/*
 * Created by Ranorex
 * User: Administrator
 * Date: 29.10.2023
 * Time: 17:32
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
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Xml;


namespace MyTest.utils
{
	/// <summary>
	/// Description of json_stuff.
	/// </summary>
	[TestModule("F87D69BF-BCD6-47E8-AEE7-C148626F24D1", ModuleType.UserCode, 1)]
	public class Json_handler : ITestModule
	{
		
		public static string xml_string = @"<?xml version='1.0'?>
					    <SquidGame>
					      <Genre>Thriller</Genre>
					      <Rating Type='Imdb'>8.1</Rating>
					      <Stars>Lee Jung-jae</Stars>
					      <Stars>Park Hae-soo</Stars>
					      <Budget />
					    </SquidGame>";
		
		public Json_handler()
		{
			// Do not delete - a parameterless constructor is required!
		}


		void ITestModule.Run()
		{
			
			Ranorex.Report.Info("xml to json: " + convert_xml_to_json(xml_string));
			
			
		}
		
		public static string convert_xml_to_json(string xml_string_to_convert_to_json){
			
			var doc = XDocument.Parse(xml_string_to_convert_to_json);
			string res =  JsonConvert.SerializeXNode(doc, Newtonsoft.Json.Formatting.Indented);
			return res;
		}
		
		public static string convert_xml_file_to_json(string path_to_xml_file){
			string org_directory = System.IO.Directory.GetCurrentDirectory();
			string path_to_file = Path.Combine(org_directory, "sources" ,  path_to_xml_file);
			XmlDocument doc = new XmlDocument();
			doc.Load(path_to_file);
			string json_string = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
			return json_string; 
		}
		

		
		
	}
}

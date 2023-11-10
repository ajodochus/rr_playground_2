/*
 * Created by Ranorex
 * User: BerndW
 * Date: 10.11.2023
 * Time: 22:30
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

using Npgsql;

namespace postgres
{
	/// <summary>
	/// Description of postgres_handler.
	/// </summary>
	[TestModule("0375718B-C355-4F69-8E6A-F7BB9278C05C", ModuleType.UserCode, 1)]
	public class postgres_handler : ITestModule
	{
		static NpgsqlConnection connection;
		
		public postgres_handler()
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

		}
		
		public static string count_columns_of_mytable(){
			NpgsqlConnection connection = connect_to_db();
			connection.Open();
			NpgsqlCommand command = new NpgsqlCommand("SELECT  COUNT(*) FROM mytable", connection);
			Int64 count = (Int64)command.ExecuteScalar();
			connection.Close();		
			return count.ToString();
		}
		
		private static NpgsqlConnection connect_to_db(){
			string connstring = @"Server='127.0.0.1';Port='5432';User Id='postgres';Password='robert.123';Database='postgres';";
			connection = new NpgsqlConnection(connstring);
			return connection;
		}
	}
}

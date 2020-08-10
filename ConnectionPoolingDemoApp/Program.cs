using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading;
using System.Security.Principal;

namespace ConnectionPoolingDemoApp
{
	// PerfMon - SQLServer:GeneralStatistics - Logical Connections
	// SELECT * FROM sys.dm_exec_connections
	public static class Program
	{
		private const string connectionString1 = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdventureWorks;Integrated Security=True;";
		private const string connectionString2 = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdventureWorks;Integrated Security=True;";
		private const string connectionString3 = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdventureWorks;Integrated Security=True;";

		public static void Main(string[] args)
		{
			Console.WriteLine("Press ENTER to start!");
			Console.ReadLine();

			Console.WriteLine("Creating connection1, press ENTER to close it.");
			using (SqlConnection connection1 = new SqlConnection(connectionString1))
			{
				connection1.Open();

				Console.ReadLine();
			}

			Console.WriteLine("Creating connection2, press ENTER to close it.");
			using (SqlConnection connection2 = new SqlConnection(connectionString2))
			{
				connection2.Open();

				Console.ReadLine();
			}

			Console.WriteLine("Creating connection3, press ENTER to close it.");
			using (SqlConnection connection3 = new SqlConnection(connectionString3))
			{
				connection3.Open();

				Console.ReadLine();
			}
		}
	}
}

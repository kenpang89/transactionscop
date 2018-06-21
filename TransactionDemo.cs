using System;
using System.Data;
using System.Data.SqlClient;

namespace GeneseeSurvey.Demo
{
	/// <summary>
	/// This is a quick class to demonstrate transactions in ADO.NET.
	/// </summary>
	public class TransactionDemo
	{
		public TransactionDemo()
		{

		}

		[STAThread]
		public static void Main() 
		{
			Demo1();
		}

		private static void Demo1() 
		{
			SqlConnection db = new SqlConnection("User ID=sa;Data Source=localhost;Initial Catalog=Experimental;Persist Security Info=True;");
			SqlTransaction transaction;

			db.Open();
			transaction = db.BeginTransaction();
			try 
			{
				new SqlCommand("INSERT INTO TransactionDemo (Text) VALUES ('Row1');", db, transaction).ExecuteNonQuery();
				new SqlCommand("INSERT INTO TransactionDemo (Text) VALUES ('Row2');", db, transaction).ExecuteNonQuery();
				new SqlCommand("INSERT INTO CrashMeNow VALUES ('Die', 'Die', 'Die');", db, transaction).ExecuteNonQuery();
				transaction.Commit();
			} 
			catch (SqlException sqlError) 
			{
				transaction.Rollback();
			}
			//transaction.Rollback();
			db.Close();
		}
	}
}

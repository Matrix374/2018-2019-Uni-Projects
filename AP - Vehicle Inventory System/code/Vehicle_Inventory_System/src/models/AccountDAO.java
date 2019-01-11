/*
 * This is where the user table is accessed and where a login attempt would be made
 * 
 * @author Irfan_Hanafi
 */
package models;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class AccountDAO {
	
	private static Connection getDBConnection()
	{
		Connection dbConnection = null;
		try {
			Class.forName("org.sqlite.JDBC");
		}
		catch(ClassNotFoundException e) {
			System.out.print(e.getMessage());
		}
		
		try {
			String dbURL = "jdbc:sqlite:vehicles.sqlite";
			dbConnection = DriverManager.getConnection(dbURL);
			return dbConnection;
		}
		catch (SQLException e) {
			System.out.println(e.getMessage());
		}
		
		return dbConnection;
	}
	
	public Account Login(String user, String pass) throws SQLException
	{
		System.out.print("Logging in...");
		Connection dbConnection = null;
		Statement statement = null;
		ResultSet result = null;
		String query = "Select * FROM users;";
		
		try {
			dbConnection = getDBConnection();
			statement = dbConnection.createStatement();
			System.out.println("DBQuery = " + query);
			result = statement.executeQuery(query);
			
			Account current = null;
			
			while(result.next())
			{
				if(user.equals(result.getString("username")) && pass.equals(result.getString("password")))
				{
					String firstname = result.getString("firstname");
					String surname = result.getString("surname");
					
					current = new Account(firstname, surname, user);
					return current;
				}
			}
			
			current = new Account();
			current.setLogin(false);
			
			return current;
		} finally {
			if (result != null) { result.close(); }
			if (statement != null) { statement.close(); }
			if (dbConnection != null) { dbConnection.close(); }
		}
	}
}

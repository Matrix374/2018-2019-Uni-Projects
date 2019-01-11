/*
 * This is where connection is made with the database to access the Sales table
 * 
 * @author Irfan_Hanafi
 * 
 */
package models;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

public class SalesDAO {
	
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
	
	public ArrayList<Sales> getAllSales() throws SQLException {
		System.out.print("Retrieving all Sales...");
		Connection dbConnection = null;
		Statement statement = null;
		ResultSet result = null;
		String query = "Select * FROM sales;";
		Vehicle temp = null;
		ArrayList<Sales> salesList = new ArrayList<>();
		
		try {
			dbConnection = getDBConnection();
			statement = dbConnection.createStatement();
			System.out.println("DBQuery = " + query);
			result = statement.executeQuery(query);
			while(result.next())
			{
				int vehicle_id = result.getInt("vehicle_id");
				String sold_date = result.getString("sold_date");
				int sold_price = result.getInt("sold_price");
				String status_info = result.getString("status_info");
				
				salesList.add(new Sales(vehicle_id, sold_date, sold_price, status_info));
			}
		} finally {
			if (result != null) { result.close(); }
			if (statement != null) { statement.close(); }
			if (dbConnection != null) { dbConnection.close(); }
		}
		
		return salesList;
	}
	
	public Boolean insertSale(Sales s) throws SQLException
	{
		Boolean attempt = false;
		System.out.print("inserting vehicle into Sale...");
		Connection dbConnection = null;
		Statement statement = null;
		String query = "INSERT INTO sales(vehicle_id, sold_date, sold_price, status_info) VALUES( " + s.getVehicle_id() + "," 
				+ "\"" + s.getSold_date() + "\"" + "," + s.getSold_price() + ", \"" + s.getStatus_info() + "\");";
		
		try {
			dbConnection = getDBConnection();
			statement = dbConnection.createStatement();
			System.out.println("DBQuery = " + query);
			attempt = statement.execute(query);
			
		} catch(SQLException e){
			System.out.println(e.getMessage());
		} finally {
			if (statement != null) { statement.close(); }
			if (dbConnection != null) { dbConnection.close(); }
		}
		
		return attempt;
	}
}

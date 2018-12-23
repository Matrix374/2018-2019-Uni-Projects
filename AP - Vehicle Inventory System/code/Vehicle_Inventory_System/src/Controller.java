/**
 * This is the main method of the system
 * 
 * @author Irfan_Hanafi
 * @version 0.2
 *
 */

import java.util.ArrayList;
import java.util.Scanner;
import java.sql.SQLException;

public class Controller {
	static Scanner in = new Scanner(System.in);
	public static void main(String[] args) throws SQLException{
		// TODO Auto-generated method stub
		
		Boolean exit = false;
		while(!exit)
		{
			int choice = menu();
			switch(choice)
			{
				case 1: allVehicles();
					break;
				case 2: searchVehicle();
					break;
				case 5: deleteVehicle();
					break;
				case 6: exit = true;
					break;
			}
			
			System.out.println("");
		}
		
		System.out.println("Exiting...");
		System.exit(0);
	}
	
	public static int menu()
	{
		System.out.println("--------------------");
		System.out.println("Vehicle Inventory System\nChoose from these options");
		System.out.println("--------------------");
		System.out.println("1 - Retrieve all vehicles");
		System.out.println("2 - Search for vehicle");
		System.out.println("3 - Insert new vehicle into database");
		System.out.println("4 - Update existing vehicle details");
		System.out.println("5 - Delete vehicle from database");
		System.out.println("6 - Exit");
		System.out.print("Enter choice > ");
		int choice = in.nextInt();
		return choice;
		
	}
	
	public static void allVehicles() throws SQLException
	{
		VehicleDAO dao = new VehicleDAO();
		
		ArrayList<Vehicle> allVehicles = null;
		
		allVehicles = dao.getAllVehicles();
		
		for(Vehicle v: allVehicles)
		{
			System.out.println("--------------------");
			System.out.println(v);
		}
	}
	
	public static void searchVehicle() throws SQLException
	{
		System.out.print("Enter Vehicle ID > ");
		int vehicle_id = in.nextInt();
		System.out.println("");
		
		VehicleDAO dao = new VehicleDAO();
		
		Vehicle v = null;
		v = dao.getVehicle(vehicle_id);
		
		System.out.println("--------------------");
		System.out.println(v);
	}
	
	public static void deleteVehicle() throws SQLException
	{
		System.out.print("Enter Vehicle ID > ");
		int vehicle_id = in.nextInt();
		System.out.println("");
		
		VehicleDAO dao = new VehicleDAO();
		
		Boolean state = null;
		state = dao.deleteVehicle(vehicle_id);
	}

}

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
				case 3: insertVehicle();
					break;
				case 5: deleteVehicle();
					break;
				case 4: updateVehicle();
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
		
		boolean state = false;
		state = dao.deleteVehicle(vehicle_id);
	}
	
	public static void insertVehicle() throws SQLException
	{
		VehicleDAO dao = new VehicleDAO();
	
		int vehicle_id = 1;
		
		System.out.print("Enter Make > ");
		String make = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Model > ");
		String model = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Year > ");
		int year = in.nextInt();
		System.out.println("");
		
		System.out.print("Enter Price > ");
		int price = in.nextInt();
		System.out.println("");
		
		in.nextLine();
		
		System.out.print("Enter License Number > ");
		String license_number = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Colour > ");
		String colour = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Number of Doors > ");
		int number_doors = in.nextInt();
		System.out.println("");
		
		in.nextLine();
		
		System.out.print("Enter Transmission > ");
		String transmission = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Mileage > ");
		int mileage = in.nextInt();
		System.out.println("");
		
		in.nextLine();
		
		System.out.print("Enter Fuel Type > ");
		String fuel_type = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Engine Size > ");
		int engine_size = in.nextInt();
		System.out.println("");
		
		in.nextLine();
		
		System.out.print("Enter Body Style > ");
		String body_style = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Condition > ");
		String condition = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Notes > ");
		String notes = in.nextLine();
		System.out.println("");
		
		Vehicle temp = new Vehicle(vehicle_id, make, model, year, price, 
				license_number, colour, number_doors, transmission, mileage,
				fuel_type, engine_size, body_style, condition, notes);
		
		boolean state = false;
		state = dao.insertVehicle(temp);
	}
	
	public static void updateVehicle() throws SQLException
	{
		VehicleDAO dao = new VehicleDAO();
		
		System.out.println("--------------------");
		System.out.print("Choose Car to Update:\nEnter Vehicle ID > ");
		int vehicle_id = in.nextInt();
		Vehicle v = null;
		v = dao.getVehicle(vehicle_id);
		
		System.out.println("--------------------");
		System.out.println("Choose Data to Update");
		System.out.println("--------------------");
		System.out.println("1 - Make");
		System.out.println("2 - Model");
		System.out.println("3 - Year");
		System.out.println("4 - Price");
		System.out.println("5 - License Number");
		System.out.println("6 - Colour");
		System.out.println("7 - Number of Doors");
		System.out.println("8 - Transmission");
		System.out.println("9 - Mileage");
		System.out.println("10 - Fuel Type");
		System.out.println("11 - Engine Size");
		System.out.println("12 - Body Style");
		System.out.println("13 - Condition");
		System.out.println("14 - Notes");
		System.out.println("15 - Exit");
		
		System.out.print("Enter choice > ");
		int choice = in.nextInt();
		System.out.println("");
		
		switch(choice)
		{
			case 1: v.setMake(in.nextLine());
				break;
			case 2:v.setModel(in.nextLine());
				break;
			case 3:v.setYear(in.nextInt());
				break;
			case 4:
				break;
			case 5:
				break;
			case 6:
				break;
			case 7:
				break;
			case 8:
				break;
			case 9:
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				break;
			case 13:
				break;
			case 14:
				break;
			case 15: menu();
				break;
		}
	}

}

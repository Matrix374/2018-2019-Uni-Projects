/**
 * This is the main method of the system
 * Console Testing is all done here
 * 
 * @author Irfan_Hanafi
 * @version 1.0
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
	
	//Menu
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
		int choice = Integer.parseInt(in.nextLine());
		return choice;
		
	}
	
	//Prints All Vehicles
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
	
	//Gets Specific Vehicle
	public static void searchVehicle() throws SQLException
	{
		System.out.print("Enter Vehicle ID > ");
		int vehicle_id = Integer.parseInt(in.nextLine());
		System.out.println("");
		
		VehicleDAO dao = new VehicleDAO();
		
		Vehicle v = null;
		v = dao.getVehicle(vehicle_id);
		
		System.out.println("--------------------");
		System.out.println(v);
	}
	
	//Removes Vehicle
	public static void deleteVehicle() throws SQLException
	{
		System.out.print("Enter Vehicle ID > ");
		int vehicle_id = Integer.parseInt(in.nextLine());
		System.out.println("");
		
		VehicleDAO dao = new VehicleDAO();
		
		dao.deleteVehicle(vehicle_id);
	}
	
	//Inserts new Vehicle
	public static void insertVehicle() throws SQLException
	{
		VehicleDAO dao = new VehicleDAO();
	
		int vehicle_id = 1; //vehicle_id doesn't matter because the SQL database will auto-increment the ID
		
		System.out.print("Enter Make > ");
		String make = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Model > ");
		String model = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Year > ");
		int year = Integer.parseInt(in.nextLine());
		System.out.println("");
		
		System.out.print("Enter Price > ");
		int price = Integer.parseInt(in.nextLine());
		System.out.println("");
		
		System.out.print("Enter License Number > ");
		String license_number = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Colour > ");
		String colour = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Number of Doors > ");
		int number_doors = Integer.parseInt(in.nextLine());
		System.out.println("");
		
		System.out.print("Enter Transmission > ");
		String transmission = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Mileage > ");
		int mileage = Integer.parseInt(in.nextLine());
		System.out.println("");
		
		System.out.print("Enter Fuel Type > ");
		String fuel_type = in.nextLine();
		System.out.println("");
		
		System.out.print("Enter Engine Size > ");
		int engine_size = Integer.parseInt(in.nextLine());
		System.out.println("");
		
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
		
		dao.insertVehicle(temp);
	}
	
	//Updates Vehicle Information
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
		in.nextLine();
		System.out.println("");
		String temp = null;
		
		switch(choice)
		{
			case 1:
				System.out.print("Enter Make > ");
				temp = in.nextLine();
				v.setMake(temp);
				break;
			case 2:
				System.out.print("Enter Model > ");
				temp = in.nextLine();
				v.setModel(temp);
				break;
			case 3:
				System.out.print("Enter Year > ");
				temp = in.nextLine();
				v.setYear(Integer.parseInt(temp));
				break;
			case 4:
				System.out.print("Enter Price > ");
				temp = in.nextLine();
				v.setPrice(Integer.parseInt(temp));
				break;
			case 5:
				System.out.print("Enter License Number > ");
				temp = in.nextLine();
				v.setLicense_number(temp);
				break;
			case 6:
				System.out.print("Enter Colour > ");
				temp = in.nextLine();
				v.setColour(temp);
				break;
			case 7:
				System.out.print("Enter Number of Doors > ");
				temp = in.nextLine();
				v.setNumber_doors(Integer.parseInt(temp));
				break;
			case 8:
				System.out.print("Enter Transmission > ");
				temp = in.nextLine();
				v.setTransmission(temp);
				break;
			case 9:
				System.out.print("Enter Mileage > ");
				temp = in.nextLine();
				v.setMileage(Integer.parseInt(temp));
				break;
			case 10:
				System.out.print("Enter Fuel Type > ");
				temp = in.nextLine();
				v.setFuel_type(temp);
				break;
			case 11:
				System.out.print("Enter Engine Size > ");
				temp = in.nextLine();
				v.setEngine_size(Integer.parseInt(temp));
				break;
			case 12:
				System.out.print("Enter Body Style > ");
				temp = in.nextLine();
				v.setBody_style(temp);
				break;
			case 13:
				System.out.print("Enter Condition > ");
				temp = in.nextLine();
				v.setCondition(temp);
				break;
			case 14:
				System.out.print("Enter Notes > ");
				temp = in.nextLine();
				v.setNotes(temp);
				break;
			case 15: menu();
				break;
		}
		
		dao.updateVehicle(v, vehicle_id);
	}

}

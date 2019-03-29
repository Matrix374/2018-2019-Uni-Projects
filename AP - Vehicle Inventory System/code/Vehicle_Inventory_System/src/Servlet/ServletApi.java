package Servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.google.gson.Gson;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;

import models.Vehicle;
import models.VehicleDAO;

public class ServletApi extends HttpServlet {
	
	private static final long serialVersionUID = 1L;
	
	VehicleDAO dao = new VehicleDAO();
	Gson gson = new Gson();
	PrintWriter writer;
	
	//All Vehicles
	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException
	{
		ArrayList<Vehicle> allVehicles = new ArrayList<Vehicle>();
		
		try {
			allVehicles = dao.getAllVehicles();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		resp.setContentType("application/json");
		
		writer = resp.getWriter();
		String conJSON = gson.toJson(allVehicles);
		writer.write(conJSON);
		writer.close();
	}
	
	//Insert Vehicle
	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException
	{
		Vehicle temp = null;
		
		String jsonVehicle = req.getParameter("json");
		JsonParser jsonParser = new JsonParser();
		JsonElement jsonElement = jsonParser.parse(jsonVehicle);
		JsonObject vehicle = jsonElement.getAsJsonObject();
		
		String make = vehicle.get("make").getAsString();
		String model = vehicle.get("model").getAsString();
		
		int year = vehicle.get("year").getAsInt();
		int price = vehicle.get("price").getAsInt();
		
		String license_number = vehicle.get("license_number").getAsString();
		String colour = vehicle.get("colour").getAsString();
		
		int number_doors = vehicle.get("number_doors").getAsInt();
		
		String transmission = vehicle.get("transmission").getAsString();
		
		int mileage = vehicle.get("mileage").getAsInt();
		
		String fuel_type = vehicle.get("fuel_type").getAsString();
		
		int engine_size = vehicle.get("engine_size").getAsInt();
		
		String body_style = vehicle.get("body_style").getAsString();
		String condition = vehicle.get("condition").getAsString();
		String notes = vehicle.get("notes").getAsString();
		
		temp = new Vehicle(1, make, model, year, price, license_number, colour, number_doors, transmission, mileage,
				fuel_type, engine_size, body_style, condition, notes);

		try {
			dao.insertVehicle(temp);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	//Update Vehicle
	@Override 
	protected void doPut(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException
	{
		Vehicle temp = null;
		
		String jsonVehicle = req.getParameter("json");
		JsonParser jsonParser = new JsonParser();
		JsonElement jsonElement = jsonParser.parse(jsonVehicle);
		JsonObject vehicle = jsonElement.getAsJsonObject();
		
		int vehicle_id = vehicle.get("vehicle_id").getAsInt();
		
		String make = vehicle.get("make").getAsString();
		String model = vehicle.get("model").getAsString();
		
		int year = vehicle.get("year").getAsInt();
		int price = vehicle.get("price").getAsInt();
		
		String license_number = vehicle.get("license_number").getAsString();
		String colour = vehicle.get("colour").getAsString();
		
		int number_doors = vehicle.get("number_doors").getAsInt();
		
		String transmission = vehicle.get("transmission").getAsString();
		
		int mileage = vehicle.get("mileage").getAsInt();
		
		String fuel_type = vehicle.get("fuel_type").getAsString();
		
		int engine_size = vehicle.get("engine_size").getAsInt();
		
		String body_style = vehicle.get("body_style").getAsString();
		String condition = vehicle.get("condition").getAsString();
		String notes = vehicle.get("notes").getAsString();
		
		try {
			temp = dao.getVehicle(vehicle_id);
			
			temp.setMake(make);
			temp.setModel(model);
			temp.setYear(year);
			temp.setPrice(price);
			temp.setLicense_number(license_number);
			temp.setColour(colour);
			temp.setNumber_doors(number_doors);
			temp.setTransmission(transmission);
			temp.setMileage(mileage);
			temp.setFuel_type(fuel_type);
			temp.setEngine_size(engine_size);
			temp.setBody_style(body_style);
			temp.setCondition(condition);
			temp.setNotes(notes);
			
			dao.updateVehicle(temp, temp.getVehicle_id());
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	
	@Override
	protected void doDelete(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException
	{
		//Delete
		int vehicle_id = Integer.valueOf(req.getParameter("vehicle_id"));
		try {
			dao.deleteVehicle(vehicle_id);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		resp.sendRedirect("home");
	}

}

package Servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.google.gson.Gson;

import models.Vehicle;
import models.VehicleDAO;

public class ServletApi extends HttpServlet {
	
	private static final long serialVersionUID = 1L;
	
	VehicleDAO dao = new VehicleDAO();
	Gson gson = new Gson();
	PrintWriter writer;
	
	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException
	{
		//Get all vehicles?
		int vehicle_id = Integer.valueOf(req.getParameter("vehicle_id"));
		Vehicle tempVehicle = null;
		
		try {
			tempVehicle = dao.getVehicle(vehicle_id);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		resp.setContentType("application/json");
		
		writer = resp.getWriter();
		String conJSON = gson.toJson(tempVehicle);
		writer.write(conJSON);
		writer.close();
	}
	
	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException
	{
		//Insert?
	}
	
	@Override 
	protected void doPut(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException
	{
		//Update?
		/*
		 * Get Vehicle Parameters as JSON
		 * Parse
		 * Change Values
		 * Send New Vehicle values with JSON
		 */
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

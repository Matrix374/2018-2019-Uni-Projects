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
	
	//@Override doPut
	
	//@Override doDelete

}

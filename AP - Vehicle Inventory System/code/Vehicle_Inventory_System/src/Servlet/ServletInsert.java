package Servlet;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import models.Vehicle;
import models.VehicleDAO;


public class ServletInsert extends HttpServlet {
	private static final long serialVersionUID = 1L;

	HttpSession session;

	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException{

		session = req.getSession();

		if(session.getAttribute("loggedin") == null)
		{
			session.setAttribute("loggedin", false);
			resp.sendRedirect("home");
		}	

		RequestDispatcher view = req.getRequestDispatcher("insert.jsp");
		req.setAttribute("session", session.getAttribute("loggedin"));
		view.forward(req,resp);
	}

	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException{
		
		session = req.getSession();

		if(session.getAttribute("loggedin") == null)
			session.setAttribute("loggedin", false);

		VehicleDAO dao = new VehicleDAO();
		Vehicle temp = null;

		String make = req.getParameter("make");
		String model = req.getParameter("model");
		int year = Integer.valueOf(req.getParameter("year"));
		int price = Integer.valueOf(req.getParameter("price"));
		String license_number = req.getParameter("license_number");
		String colour = req.getParameter("colour");
		int number_doors = Integer.valueOf(req.getParameter("number_doors"));
		String transmission = req.getParameter("transmission");
		int mileage = Integer.valueOf(req.getParameter("mileage"));
		String fuel_type = req.getParameter("fuel_type");
		int engine_size = Integer.valueOf(req.getParameter("engine_size"));
		String body_style = req.getParameter("body_style");
		String condition = req.getParameter("condition");
		String notes = req.getParameter("notes");

		temp = new Vehicle(1, make, model, year, price, license_number,
				colour, number_doors, transmission, mileage, fuel_type,
				engine_size, body_style, condition, notes);


		try {
			dao.insertVehicle(temp);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		RequestDispatcher view = req.getRequestDispatcher("insert.jsp");
		view.forward(req,resp);
		resp.sendRedirect("home");
	}
}

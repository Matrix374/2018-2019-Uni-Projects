package Servlet;
/*
 * Where you can change the details of an existing vehicle
 * 
 * @author Irfan_Hanafi
 */
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

public class ServletUpdate extends HttpServlet {
	private static final long serialVersionUID = 1L;

	HttpSession session;

	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		VehicleDAO dao = new VehicleDAO();
		Vehicle temp = null;

		session = req.getSession();

		if (session.getAttribute("loggedin") == null || session.getAttribute("loggedin").equals(false))
		{
			session.setAttribute("loggedin", false);
			resp.sendRedirect("home");
		}

		if (session.getAttribute("loggedin").equals(true)) {
			int vehicle_id = Integer.valueOf(req.getParameter("vehicle_id"));
			try {
				temp = dao.getVehicle(vehicle_id);
				session.setAttribute("temp", temp);

				req.setAttribute("make", temp.getMake());
				req.setAttribute("model", temp.getModel());
				req.setAttribute("year", temp.getYear());
				req.setAttribute("price", temp.getPrice());
				req.setAttribute("license_number", temp.getLicense_number());
				req.setAttribute("colour", temp.getColour());
				req.setAttribute("number_doors", temp.getNumber_doors());
				req.setAttribute("transmission", temp.getTransmission());
				req.setAttribute("mileage", temp.getMileage());
				req.setAttribute("fuel_type", temp.getFuel_type());
				req.setAttribute("engine_size", temp.getEngine_size());
				req.setAttribute("body_style", temp.getBody_style());
				req.setAttribute("condition", temp.getCondition());
				req.setAttribute("notes", temp.getNotes());

				RequestDispatcher view = req.getRequestDispatcher("update.jsp");
				view.forward(req, resp);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				resp.sendRedirect("home");
			}
		}
	}

	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		session = req.getSession();

		VehicleDAO dao = new VehicleDAO();
		Vehicle temp = null;

		if (session.getAttribute("loggedin") == null || session.getAttribute("loggedin").equals(false))
		{
			session.setAttribute("loggedin", false);
			resp.sendRedirect("home");
		}

		if (session.getAttribute("loggedin").equals(true)){
			temp = (Vehicle) session.getAttribute("temp");
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

			try {
				dao.updateVehicle(temp, temp.getVehicle_id());
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}

		resp.sendRedirect("home");

	}
}

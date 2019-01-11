package Servlet;

import java.io.IOException;
import java.sql.SQLException;
import java.util.ArrayList;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import models.Vehicle;
import models.VehicleDAO;

public class ServletHome extends HttpServlet {
	private static final long serialVersionUID = 1L;

	HttpSession session;

	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		session = req.getSession();

		if(session.getAttribute("loggedin") == null)
			session.setAttribute("loggedin", false);

		VehicleDAO dao = new VehicleDAO();
		ArrayList<Vehicle> allVehicles = null;
		try {
			allVehicles = dao.getAllVehicles();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		RequestDispatcher view = req.getRequestDispatcher("index.jsp");
		req.setAttribute("allVehicles", allVehicles);
		req.setAttribute("session", session.getAttribute("loggedin"));
		req.setAttribute("userGreet", session.getAttribute("username"));
		view.forward(req, resp);
	}

	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException{

		session = req.getSession();

		if(session.getAttribute("loggedin") == null)
			session.setAttribute("loggedin", false);

		VehicleDAO dao = new VehicleDAO();

		int vehicle_id = Integer.valueOf(req.getAttribute("Button"));
		try {
			dao.deleteVehicle(vehicle_id);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}


		ArrayList<Vehicle> allVehicles = null;
		try {
			allVehicles = dao.getAllVehicles();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		RequestDispatcher view = req.getRequestDispatcher("index.jsp");
		req.setAttribute("allVehicles", allVehicles);
		req.setAttribute("session", session.getAttribute("loggedin"));
		req.setAttribute("userGreet", session.getAttribute("username"));
		view.forward(req, resp);

	}
}

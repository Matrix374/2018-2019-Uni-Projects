package Servlet;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import models.VehicleDAO;

public class ServletDelete extends HttpServlet {
	private static final long serialVersionUID = 1L;

	HttpSession session;

	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		session = req.getSession();

		if (session.getAttribute("loggedin") == null || session.getAttribute("loggedin").equals(false))
			session.setAttribute("loggedin", false);

		VehicleDAO dao = new VehicleDAO();

		if (session.getAttribute("loggedin").equals(true)) {
			int vehicle_id = Integer.valueOf(req.getParameter("vehicle_id"));
			try {
				dao.deleteVehicle(vehicle_id);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		resp.sendRedirect("home");
	}
}

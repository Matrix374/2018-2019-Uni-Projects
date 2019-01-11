package Servlet;
/*
 * Where new Sales insertions are made in the website
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

import models.Sales;
import models.SalesDAO;
import models.VehicleDAO;

public class ServletSalesInsert extends HttpServlet{
	private static final long serialVersionUID = 1L;

	HttpSession session;

	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		session = req.getSession();

		if (session.getAttribute("loggedin") == null || session.getAttribute("loggedin").equals(false))
		{
			session.setAttribute("loggedin", false);
			resp.sendRedirect("home");
		}
		
		int vehicle_id = Integer.valueOf(req.getParameter("vehicle_id"));
		
		session.setAttribute("vehicle_id", vehicle_id);
		
		RequestDispatcher view = req.getRequestDispatcher("salesInsert.jsp");
		req.setAttribute("session", session.getAttribute("loggedin"));
		view.forward(req, resp);
	}

	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		session = req.getSession();

		if (session.getAttribute("loggedin") == null || session.getAttribute("loggedin").equals(false))
		{
			session.setAttribute("loggedin", false);
			resp.sendRedirect("home");
		}
		
		VehicleDAO vehDao = new VehicleDAO();
		SalesDAO salesDao = new SalesDAO();
		
		Sales s = null;
		
		if (session.getAttribute("loggedin").equals(true)) {
			
			int vehicle_id = (int) session.getAttribute("vehicle_id");
			String sold_date = req.getParameter("day") + "/" + req.getParameter("month") + "/" + req.getParameter("year");
			int sold_price = Integer.valueOf(req.getParameter("sold_price"));
			String status_info = req.getParameter("status_info");

			s = new Sales(vehicle_id, sold_date, sold_price, status_info);
			try {
				salesDao.insertSale(s);
				vehDao.deleteVehicle(vehicle_id);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}

		resp.sendRedirect("sales");
	}
}

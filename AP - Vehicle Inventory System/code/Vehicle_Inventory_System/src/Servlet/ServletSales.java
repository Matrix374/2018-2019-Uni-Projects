package Servlet;
/*
 * Displays Sales data
 * 
 * @author Irfan_Hanafi
 */
import java.io.IOException;
import java.sql.SQLException;
import java.util.ArrayList;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import models.Sales;
import models.SalesDAO;

public class ServletSales extends HttpServlet{
	private static final long serialVersionUID = 1L;

	HttpSession session;

	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

		session = req.getSession();

		if(session.getAttribute("loggedin") == null)
			session.setAttribute("loggedin", false);

		SalesDAO dao = new SalesDAO();
		ArrayList<Sales> allSales = null;
		try {
			allSales = dao.getAllSales();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		RequestDispatcher view = req.getRequestDispatcher("salesIndex.jsp");
		
		req.setAttribute("allSales", allSales);
		
		req.setAttribute("session", session.getAttribute("loggedin"));
		req.setAttribute("userGreet", session.getAttribute("username"));
		view.forward(req, resp);
	}
}

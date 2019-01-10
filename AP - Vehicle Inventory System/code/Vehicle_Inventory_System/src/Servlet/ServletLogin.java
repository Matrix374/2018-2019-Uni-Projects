package Servlet;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import models.Account;
import models.AccountDAO;

public class ServletLogin extends HttpServlet{
private static final long serialVersionUID = 1L;
	
	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		
		RequestDispatcher view = req.getRequestDispatcher("login.jsp");
		view.forward(req, resp);
	}
	
	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException{
		
		HttpSession session = req.getSession();
		
		AccountDAO dao = new AccountDAO();
		Account current = null;
		
		String username = req.getParameter("username");
		String password = req.getParameter("password");
		
		try {
			current = dao.Login(username, password);
			
			if(current.getLogin())
			{
				session.setAttribute("loggedin", true);
				session.setAttribute("username", current);
			}
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		RequestDispatcher view = req.getRequestDispatcher("login.jsp");
		req.setAttribute("session", session.getAttribute("loggedin"));
		req.setAttribute("userGreet", session.getAttribute("username"));
		view.forward(req,resp);
	}
}

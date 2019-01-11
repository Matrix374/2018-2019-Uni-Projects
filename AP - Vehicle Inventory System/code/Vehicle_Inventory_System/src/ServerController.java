/*
 * This is the Jetty server controller
 * 
 * This is where the front-end of the system is controlled from
 * 
 * the url of the website should be as follows:
 * 
 * localhost:4000/VDB
 * 
 * @author Irfan_Hanafi
 * @version 1.5
 * 
 * @param ctx WebAppContext
 * 
 */

import org.eclipse.jetty.server.Server;
import org.eclipse.jetty.webapp.WebAppContext;
import org.eclipse.jetty.webapp.Configuration.ClassList;

public class ServerController {

	public static void main(String[] args) throws Exception {
		// TODO Auto-generated method stub
		
		Server server = new Server(4000);
		
		WebAppContext ctx = new WebAppContext();
		
		ctx.setResourceBase("webapp");
		ctx.setContextPath("/VDB"); //base URL
		
		ctx.setAttribute("org.eclipse.jetty.server.webapp.ContainerIncludeJarPattern", ".*/[^/]*jstl.*\\.jar$");
		ClassList classlist = ClassList.setServerDefault(server);
		classlist.addBefore("org.eclipse.jetty.webapp.JettyWebXmlConfiguration", "org.eclipse.jetty.annotations.AnnotationConfiguration");
		
		ctx.addServlet("Servlet.ServletHome", "/home");
		ctx.addServlet("Servlet.ServletLogin","/login");
		ctx.addServlet("Servlet.ServletLogout", "/logout");
		ctx.addServlet("Servlet.ServletInsert", "/insert");
		ctx.addServlet("Servlet.ServletDelete", "/delete");
		ctx.addServlet("Servlet.ServletUpdate", "/update");
		ctx.addServlet("Servlet.ServletSales", "/sales");
		ctx.addServlet("Servlet.ServletSalesInsert", "/salesInsert");
		
		server.setHandler(ctx);
		server.start();
		server.join();
	}

}

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
		
		server.setHandler(ctx);
		server.start();
		server.join();
	}

}

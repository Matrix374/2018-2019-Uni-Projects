import java.util.ArrayList;
import java.sql.SQLException;

/**
 * This is the main method of the system
 * 
 * @author Irfan_Hanafi
 * @version 0.2
 *
 */
public class Controller {

	public static void main(String[] args) throws SQLException {
		// TODO Auto-generated method stub
		VehicleDAO dao = new VehicleDAO();
		
		ArrayList<Vehicle> allVehicles = null;
		
		allVehicles = dao.getAllVehicles();
		
		for(Vehicle v: allVehicles)
		{
			System.out.println("--------------------");
			System.out.println(v);
		}
	}

}

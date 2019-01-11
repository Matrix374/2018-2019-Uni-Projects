/*
 * This is the object that holds Sales data
 * 
 * @author Irfan_Hanafi
 */
package models;

public class Sales {
	
	int vehicle_id;
	String sold_date;
	int sold_price;
	String status_info;
	
	public Sales(int vehicle_id, String sold_date, int sold_price, String status_info)
	{
		setVehicle_id(vehicle_id);
		setSold_date(sold_date);
		setSold_price(sold_price);
		setStatus_info(status_info);
	}

	public int getVehicle_id() {
		return vehicle_id;
	}

	public void setVehicle_id(int vehicle_id) {
		this.vehicle_id = vehicle_id;
	}

	public String getSold_date() {
		return sold_date;
	}

	public void setSold_date(String sold_date) {
		this.sold_date = sold_date;
	}

	public int getSold_price() {
		return sold_price;
	}

	public void setSold_price(int sold_price) {
		this.sold_price = sold_price;
	}

	public String getStatus_info() {
		return status_info;
	}

	public void setStatus_info(String status_info) {
		this.status_info = status_info;
	}
	
	public String toString()
	{
		return "Vehicle ID = " + getVehicle_id() + "\n"
		+ "Sold Date = " + getSold_date() + "\n"
		+"Sold Price = " + getSold_price() + "\n"
		+"Status Info = " + getStatus_info();
	}
	
}

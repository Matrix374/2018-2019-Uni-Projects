/*
 * This is where Account details are stored temporarily after accessing AccountDAO
 * 
 * @author Irfan_Hanafi
 */

package models;

public class Account {
	
	private String firstname;
	private String surname;
	private String username;
	private Boolean login = false;
	
	Account()
	{
		this.setLogin(false);
	}
	
	Account(String firstname, String surname, String username)
	{
		this.firstname = firstname;
		this.surname = surname;
		this.username = username;
		this.setLogin(true);
	}

	public String getFirstname() {
		return firstname;
	}

	public void setFirstname(String firstname) {
		this.firstname = firstname;
	}

	public String getSurname() {
		return surname;
	}

	public void setSurname(String surname) {
		this.surname = surname;
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}
	
	public Boolean getLogin() {
		return login;
	}

	public void setLogin(Boolean login) {
		this.login = login;
	}

	public String toString()
	{
		return "Hello " + firstname + " " + surname + "!";
		
	}
}

<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Adding Vehicles</title>
<meta
	<%@taglib uri = "http://java.sun.com/jsp/jstl/core" prefix = "c" %>>
</head>
<body>
	<ul>
		<li class="highlight"><a href="./home">Home</a></li>
	</ul>
	
	<table>
		<tr>
			<th>New Vehicle</th>

		</tr>
		<form action="./insert" method="post">
			<tr>
				<td>Make</td>
				<td><input type="text" name="make"></td>
			</tr>

			<tr>
				<td>Model</td>
				<td><input type="text" name="model"></td>
			</tr>

			<tr>
				<td>Year</td>
				<td><input type="number" name="year"></td>
			</tr>

			<tr>
				<td>Price</td>
				<td><input type="number" name="price"></td>
			</tr>

			<tr>
				<td>License Number</td>
				<td><input type="text" name="license_number"></td>
			</tr>

			<tr>
				<td>Colour</td>
				<td><input type="text" name="colour"></td>
			</tr>

			<tr>
				<td>Number of Doors</td>
				<td><input type="number" name="number_doors"></td>
			</tr>

			<tr>
				<td>Transmission</td>
				<td><input type="text" name="transmission"></td>
			</tr>

			<tr>
				<td>Mileage</td>
				<td><input type="number" name="mileage"></td>
			</tr>

			<tr>
				<td>Fuel Type</td>
				<td><input type="text" name="fuel_type"></td>
			</tr>

			<tr>
				<td>Engine Size</td>
				<td><input type="number" name="engine_size"></td>
			</tr>

			<tr>
				<td>Body Style</td>
				<td><input type="text" name="body_style"></td>
			</tr>

			<tr>
				<td>Condition</td>
				<td><input type="text" name="condition"></td>
			</tr>

			<tr>
				<td>Notes</td>
				<td><input type="text" name="notes"></td>
			</tr>

			<tr>

				<td><input type="submit" value="Submit"></td>
			</tr>
		</form>
	</table>

</body>
</html>
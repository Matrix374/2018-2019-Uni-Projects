<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Update Vehicle</title>
<meta
	<%@taglib uri = "http://java.sun.com/jsp/jstl/core" prefix = "c" %>>
</head>
<body>
	<ul>
		<li class="highlight"><a href="./home">Home</a></li>
	</ul>
	
	<table>
		<tr>
			<th>Update Vehicle</th>

		</tr>
		<form action="./update" method="post">
			<tr>
				<td>Make</td>
				<td><input type="text" name="make" value="${make}"></td>
			</tr>

			<tr>
				<td>Model</td>
				<td><input type="text" name="model" value="${model}"></td>
			</tr>

			<tr>
				<td>Year</td>
				<td><input type="number" name="year" value="${year}"></td>
			</tr>

			<tr>
				<td>Price</td>
				<td><input type="number" name="price" value="${price}"></td>
			</tr>

			<tr>
				<td>License Number</td>
				<td><input type="text" name="license_number"
					value="${license_number}"></td>
			</tr>

			<tr>
				<td>Colour</td>
				<td><input type="text" name="colour" value="${colour}"></td>
			</tr>

			<tr>
				<td>Number of Doors</td>
				<td><input type="number" name="number_doors"
					value="${number_doors}"></td>
			</tr>

			<tr>
				<td>Transmission</td>
				<td><input type="text" name="transmission"
					value="${transmission}"></td>
			</tr>

			<tr>
				<td>Mileage</td>
				<td><input type="number" name="mileage" value="${mileage}"></td>
			</tr>

			<tr>
				<td>Fuel Type</td>
				<td><input type="text" name="fuel_type" value="${fuel_type}"></td>
			</tr>

			<tr>
				<td>Engine Size</td>
				<td><input type="number" name="engine_size"
					value="${engine_size}"></td>
			</tr>

			<tr>
				<td>Body Style</td>
				<td><input type="text" name="body_style" value="${body_style}"></td>
			</tr>

			<tr>
				<td>Condition</td>
				<td><input type="text" name="condition" value="${condition}"></td>
			</tr>

			<tr>
				<td>Notes</td>
				<td><input type="text" name="notes" value="${notes}"></td>
			</tr>

			<tr>

				<td><input type="submit" value="Submit"></td>
			</tr>
		</form>
	</table>

</body>
</html>
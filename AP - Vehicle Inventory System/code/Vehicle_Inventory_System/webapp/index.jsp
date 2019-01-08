<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Vehicle Database</title>
<meta <%@taglib uri = "http://java.sun.com/jsp/jstl/core" prefix = "c" %>>
</head>
<body>
	<h1>All Vehicles</h1>
	<table>
		<tr>
			<th>Vehicle ID</th>
			<th>Make</th>
			<th>Model</th>
			<th>Year</th>
			<th>Price</th>
			<th>License Number</th>
			<th>Colour</th>
			<th>Number of Doors</th>
			<th>Transmission</th>
			<th>Mileage</th>
			<th>Fuel Type</th>
			<th>Engine Size</th>
			<th>Body Style</th>
			<th>Condition</th>
			<th>Notes</th> 
		</tr>
		<c:forEach items="${allVehicles}" var="c">
			<tr>
				<td>${c.getVehicle_id()}</td>
				<td>${c.getMake()}</td>
				<td>${c.getModel()}</td>
				<td>${c.getYear()}</td>
				<td>${c.getPrice()}</td>
				<td>${c.getLicense_number()}</td>
				<td>${c.getColour()}</td>
				<td>${c.getNumber_doors()}</td>
				<td>${c.getTransmission()}</td>
				<td>${c.getMileage()}</td>
				<td>${c.getFuel_type()}</td>
				<td>${c.getEngine_size()}</td>
				<td>${c.getBody_style()}</td>
				<td>${c.getCondition()}</td>
				<td>${c.getNotes()}</td>
			</tr>
		</c:forEach>
	</table>
	<br>
		<a href = "./addnew">+ New Vehicle</a>
		<a href = "./login"> Login</a>
</body>
</html>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Vehicle Database</title>
<meta
	<%@taglib uri = "http://java.sun.com/jsp/jstl/core" prefix = "c" %>>
</head>
<body>

	<nav role="navigation">

		<ul>

			<li class="highlight"><a href="./home">Home</a></li>
			
			<li><a href="./sales">Sales</a></li>
			
			<c:if test="${session == false}">
				<li><a href="./login">Log In</a></li>
			</c:if>
			<c:if test="${session == true}">
				<li><a href="./logout">Log Out</a></li>
			</c:if>

		</ul>

	</nav>

	<main> <c:if test="${session == true}">
		<h1>Hello ${username}!</h1>
	</c:if>

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

				<c:if test="${session == true}">
					<td><a href="update?vehicle_id=${c.getVehicle_id()}"> <input
							type="submit" value="Update">
					</a></td>
					<td><a href="delete?vehicle_id=${c.getVehicle_id()}"> <input
							type="submit" value="Delete">
					</a></td>
					<td><a href="salesInsert?vehicle_id=${c.getVehicle_id()}"> <input
							type="submit" value="Sell">
					</a></td>
				</c:if>

			</tr>
		</c:forEach>
	</table>
	<c:if test="${session == true}">
		<form action="./insert">
			<input type="submit" value="Add New Vehicle">
		</form>
	</c:if> </main>
</body>
</html>
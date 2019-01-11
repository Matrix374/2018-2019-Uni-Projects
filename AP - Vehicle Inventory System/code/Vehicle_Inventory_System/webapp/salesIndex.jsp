<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Sales Database</title>
<meta
	<%@taglib uri = "http://java.sun.com/jsp/jstl/core" prefix = "c" %>>
</head>
<body>

	<nav role="navigation">

		<ul>

			<li><a href="./home">Home</a></li>

			<li class="highlight"><a href="./sales">Sales</a></li>

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

	<h1>All Sales</h1>
	<table>
		<tr>
			<th>Vehicle ID</th>
			<th>Sold Date</th>
			<th>Sold Price</th>
			<th>Status Info</th>
		</tr>

		<c:forEach items="${allSales}" var="c">
			<tr>
				<td>${c.getVehicle_id()}</td>
				<td>${c.getSold_date()}</td>
				<td>${c.getSold_price()}</td>
				<td>${c.getStatus_info()}</td>

			</tr>
		</c:forEach>
	</table>
	</main>
</body>
</html>
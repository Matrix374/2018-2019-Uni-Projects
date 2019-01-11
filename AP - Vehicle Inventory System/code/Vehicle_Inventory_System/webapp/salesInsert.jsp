<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Inserting Sale</title>
<meta
	<%@taglib uri = "http://java.sun.com/jsp/jstl/core" prefix = "c" %>>
</head>
<body>
	<ul>
		<li class="highlight"><a href="./home">Home</a></li>
	</ul>
	
	<table>
		<tr>
			<th>New Sale</th>

		</tr>
		<form action="./salesInsert" method="post">
			<tr>
				<td>Sold Date</td>
				<td>Day <input type="number" name="day"></td>
				<td>Month <input type="number" name="month"></td>
				<td>Year <input type="number" name="year"></td>
			</tr>

			<tr>
				<td>Sold Price</td>
				<td><input type="number" name="sold_price"></td>
			</tr>

			<tr>
				<td>Status Info</td>
				<td><input type="text" name="status_info"></td>
			</tr>

			<tr>

				<td><input type="submit" value="Submit"></td>
			</tr>
		</form>
	</table>

</body>
</html>
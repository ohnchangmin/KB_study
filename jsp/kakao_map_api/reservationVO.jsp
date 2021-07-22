<%@ page import= "reservation.ReservationDTO"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>create reservation</title>
</head>
<body>
<%
private ReservationDTO create_reservation()
{
String name = request.getParameter("reservation_name");
String tel = request.getParameter("reservation_tel");
int number = request.getParameter("reservation_number");
String store_name = request.getParameter("title");
String date = request.getParameter("reservation_date");
ReservationDTO dto = new ReservationDTO(name, tel, number, store_name, date);

return dto;
}

%>
</body>



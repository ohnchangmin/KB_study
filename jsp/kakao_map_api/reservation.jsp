<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
	<title>다음 지도 API</title>
</head>
<body>
<form>
예약자명: 	    <input type = "text" name = "reservation_name"><br>
예약자 연락처: 	<input type = "text" name = "reservation_tel"><br>
인원수: <select name = "reservation_number">
<option value = "1">1명</option>
<option value = "2">2명</option>
<option value = "3">3명</option>
<option value = "4">4명</option>
<option value = "5">5명</option>
<option value = "6">6명</option>
<option value = "7">7명</option>
</select>
<input type = "submit" value = "제출">
</form>
</body>
</html>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<Form input action = "./userJoinAction.jsp" method = "post"">
	<input type = "text" name="userID">
	<input type = "password" name = userPassword">
	<input type = "submit" value="ȸ������">
</Form>
<Form action="./useDB.jsp" method="post">
	<input type = "submit" value= "��ȸ">
</Form>
</body>
</html>
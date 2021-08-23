<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h1>list page 입니다.</h1>
<div>
<a href="insertform">insertform</a>
</div>
${a}
<c:forEach items="${a}" var="element">element = ${element}<br></c:forEach>
</body>
</html>
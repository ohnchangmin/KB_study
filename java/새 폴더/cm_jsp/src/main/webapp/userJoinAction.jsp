<%@ page import="user.UserDTO"%>
<%@ page import="user.UserDAO"%>
<%@ page import="java.io.PrintWriter"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<%request.setCharacterEncoding("EUC-KR");
UserDTO NewUser = new UserDTO();
if(request.getParameter("userID")!=null)
{
	NewUser.setUserID(request.getParameter("userID"));
}
if(request.getParameter("userPassword")!=null)
{
	NewUser.setUserPassword(request.getParameter("userPassword"));
}
if(NewUser.getUserID()==null || NewUser.getUserPassword() == null)
{
	PrintWriter script = response.getWriter();
	script.println("<script>");
	script.println("alert('입 력 이 안 된 게 있 다.')");
	script.println("</script>");
	script.close();
	return;
}
//ID와 비밀번호가 모두 있는 경우
UserDAO userDAO = new UserDAO();
int result = userDAO.join(NewUser.getUserID(), NewUser.getUserPassword());
if(result == 1)
{
	PrintWriter script = response.getWriter();
	script.println("<script>");
	script.println("alert('잘됐습니다.')");
	script.println("location.href='InsertUser.jsp");
	script.println("</script>");
	script.close();
}
%>


</body>
</html>
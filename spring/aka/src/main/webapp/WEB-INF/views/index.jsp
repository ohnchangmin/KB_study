<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" href="/aka/resources/index.css">
</head>
<body>
<form action="loginchk" method="post">
	<div id="root">
		<div class="container">
			<div class="left_panel">
				<img alt="" src="/aka/resources/images/main.jpg">
			</div>
			<div class="right_panel">
				<div class="right_panel_main">
					<div><h3>로그인</h3></div>
					<div><h5>ID</h5></div>
					<div><input type="text" name="id"></div>
					<div><h5>PASSWORD</h5></div>
					<div><input type="text" name="pw"></div>
					<div><input type="submit" value="로그인"></div>
				</div>			
			</div>
		</div>
	</div>
	</form>
</body>
</html>
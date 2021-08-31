<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" href="/aka/resources/index.css">
<script src="http://d3js.org/d3.v3.min.js" charset="utf-8"></script>
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<style>
svg {
	width: 320px;
	height: 240px;
	border: 1px solid black;
	margin-left: 10px;
}

.bar {
	fill: #E8D9FF;
}
</style>
</head>
<body>
	<form action="loginchk" method="post">
	<div>${sessionScope.dto.id}님 환영합니다.</div>
		<div id="root">
			<div class="container">
				<div class="left_panel" style="padding: 20px;">
					<h1>데이터에 따른 그래프 표시</h1>
					<svg id="myGraph"></svg>
					<div>
					<button type="button" id="testBtn">update</button>
					</div>
					<script src="/aka/resources/d3/sample01.js"></script>
				</div>
				<div class="right_panel">
					<div class="right_panel_main">piechart</div>
				</div>
			</div>
		</div>
	</form>
</body>
</html>
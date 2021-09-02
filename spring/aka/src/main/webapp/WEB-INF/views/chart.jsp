<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" href="/aka/resources/chart.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<script src="http://d3js.org/d3.v3.min.js" charset="utf-8"></script>
<style>
    svg{ 
	    width:320px; 
	    height:370px; 
	    border : 1px solid black;
	    margin-left: 20px;
    }
    .bar{
        fill:blue;
    }
</style>
</head>
<body>
<form action="loginchk" method="post">
<div>${sessionScope.dto.id}님 환영 합니다.</div>
<div id="root">
	<div class="container">
		<div class="left_panel" style="">
			<div>
				<h1>데이터에 따른 그래프 표시</h1>
				<svg id="myGraph1"></svg>
			</div>
			<div class="leftbtndiv">
				<button type="button" id="barbtn">update</button>
			</div>
<!-- 			<script src="/aka/resources/d3/bar.js"></script> -->
<script src="/aka/resources/d3/bar_json.js"></script>
		</div>
		<div class="right_panel">
			<div>
				<h1>데이터에 따른 그래프 표시</h1>
				<svg id="myGraph2"></svg>
			</div>
			<div class="rightbtndiv">
				<button type="button" id="piebtn">update</button>
			</div>
<!-- 			<script src="/aka/resources/d3/pie.js"></script> -->
		</div>
	</div>
</div>
</form>
</body>
</html>
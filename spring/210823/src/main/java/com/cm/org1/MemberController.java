package com.cm.org1;

import java.util.List;

import org.apache.ibatis.session.SqlSession;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class MemberController {

	/*
	 * mybatis 설정
	 * pom.xml 6가지 jar파일 가져오는거
	 * 1.mybatis, 2.mybatis-spring, 3.spring-jdbc, 4.dbcp, 5.mysql-conner, 6.cglib
	 * 
	 * servlet-conext.xml
	 * 3가지 bean 객체 설정
	 * 1.dbcp 2.sqlsessionfactory(xml파일을 읽어서 sql설정) 3.sqlseesion(sql구문 실행)
	 * 
	 * Controller requestmapping
	 * memberlist -> resultType 반환되는거
	 * memberinsert -> paramerterType 매개변수 설정하는 방식
	 * 
	 * MemberController -> MemberService -> MemberDao -> MemberDto -> member.xml
	 */

	@Autowired
	SqlSession sqlsession;
	
	@RequestMapping(value="memberlist")
	public String memberlist() {
		List<MemberDto> list = sqlsession.selectList("member.select");
		for(MemberDto dto : list) {
			System.out.println("dto = " + dto);
		}
		return "member/list";
	}
	
	@RequestMapping(value="memberinsert")
		public String memberinsert() {
		sqlsession.insert("member.insert");
		return "member/insert";
	}
	
}

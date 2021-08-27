package com.cm.org1;

import java.util.List;

import org.apache.ibatis.session.SqlSession;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class MemberController {

	/*
	 * mybatis 설정 pom.xml 6가지 jar파일 가져오는거 1.mybatis, 2.mybatis-spring,
	 * 3.spring-jdbc, 4.dbcp, 5.mysql-conner, 6.cglib
	 * 
	 * servlet-conext.xml 3가지 bean 객체 설정 1.dbcp 2.sqlsessionfactory(xml파일을 읽어서
	 * sql설정) 3.sqlseesion(sql구문 실행)
	 * 
	 * Controller requestmapping memberlist -> resultType 반환되는거 memberinsert ->
	 * paramerterType 매개변수 설정하는 방식
	 * 
	 * MemberController -> MemberService -> MemberDao -> MemberDto -> member.xml
	 */

	@Autowired
	SqlSession sqlsession;

	@RequestMapping(value = "memberlist")
	public String memberlist(Model model) {
		List<MemberDto> list = sqlsession.selectList("member.select");
		for (MemberDto dto : list) {
			System.out.println("dto = " + dto);
		}
		model.addAttribute("aa", "bb");
		model.addAttribute("alist", list);
		return "member/list";
	}

	/*
	 * request getParameter("id");
	 * 스프링에선 Stirng id, String pw
	 */
	
//	@RequestMapping(value = "memberinsert")
//	public String memberinsert(String id, String pw, String age, String gender, MemberDto dto) {
//		System.out.println("id= "+id);
//		System.out.println("pw= "+pw);
//		System.out.println("age= "+age);
//		System.out.println("gender= "+gender);
//		System.out.println("dto= "+dto);
//		sqlsession.insert("member.insert");
//		return "member/insert";
//	}
	
	@RequestMapping(value = "memberinsert")
	public String memberinsert(MemberDto dto) {
		System.out.println("dto= "+dto);
		sqlsession.insert("member.insert",dto);
		return "member/insert";
	}

	@RequestMapping(value = "memberinsertform")
	public String memberinsertform() {
		return "member/insertform";
	}
	
	@RequestMapping(value = "memberupdateform")
	public String memberupdateform(int idx, Model model) {
		System.out.println("idx= "+idx);
		MemberDto dto = sqlsession.selectOne("member.selectone",idx);
		System.out.println(dto);
		model.addAttribute("member", dto);
		return "member/updateform";
	}

	@RequestMapping(value = "memberupdate")
	public String memberupdate(MemberDto dto, Model model) {
		System.out.println("update=======\n"+dto);
		sqlsession.update("member.update",dto);
		return "redirect:memberlist"; //update성공하고나면 memberlist로 이동
	}
	
	@RequestMapping(value = "memberdelete")
	public String memberdelete(int idx) {
		System.out.println("idx= " + idx);
		sqlsession.delete("member.delete",idx);
		return "redirect:memberlist"; //update성공하고나면 memberlist로 이동
	}
}

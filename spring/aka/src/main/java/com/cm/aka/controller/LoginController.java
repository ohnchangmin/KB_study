package com.cm.aka.controller;

import javax.servlet.http.HttpSession;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.cm.aka.dao.MemberDao;
import com.cm.aka.dto.MemberDto;

/**
 * Handles requests for the application home page.
 */
@Controller
public class LoginController {

	private static final Logger logger = LoggerFactory.getLogger(LoginController.class);

	/**
	 * Simply selects the home view to render by returning its name.
	 */
	@Autowired
	MemberDao dao;

	@RequestMapping(value = "/loginchk", method = RequestMethod.POST)
	public String loginchk(MemberDto dto,HttpSession session) {
		/*
		 * login check mybatis sql log
		 */
		dto = dao.chklogin(dto);
		if (dto != null) {
			session.setAttribute("dto", dto);
			//session에다가 저장해야되고
			return "chart";
		} else {
			//로그인에 실패했습니다. 아이디 비밀번호를 확인하세요
			return "redirect:/?text=loginfail";
		}
	}
}

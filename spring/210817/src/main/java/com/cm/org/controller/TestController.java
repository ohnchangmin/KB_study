package com.cm.org.controller;

import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import com.cm.org.dao.TestDao;
import com.cm.org.dto.TestDto;

@Controller
public class TestController {
	
	@Autowired
	TestDao dao;
	
	
	/*TestController(requestMapping) ->
	 * 
	 */
	
	@RequestMapping(value="list")
	public String list(Model model) {
		List<TestDto> rvalue = dao.doList();
		model.addAttribute("a",rvalue);
		return "list";
	}
	/*
	 * insert?para1=555&para2=333 
	 */
	@RequestMapping
	public String insert(Model model, HttpServletRequest request, String para1, String para2) {
		String va1 = request.getParameter("para1");
		System.out.println(va1);
		System.out.println("para1= " + para1);
		System.out.println("para2= " + para2);
		dao.doInsert(para1, para2);
		return "insert";
	}
	
	@RequestMapping(value="insertform")
	public String insertform() {
		return "insertform";
	}

}

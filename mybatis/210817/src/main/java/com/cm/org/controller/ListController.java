package com.cm.org.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import com.cm.org.dao.TestDao;
import com.cm.org.dto.TestDto;

@Controller
public class ListController {
	
	@Autowired
	TestDao dao;
	
	@RequestMapping(value="list")
	public String list(Model model) {
		List<TestDto> rvalue = dao.doList();
		model.addAttribute("a",rvalue);
		return "list";
	}
	@RequestMapping
	public String insert(Model model) {
		dao.doInsert();
		return "insert";
	}

}

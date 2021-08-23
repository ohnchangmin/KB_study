package com.cm.org.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

import com.cm.org.DBM;

//RequestMapping 에서 들어오는걸 컨트롤
@Controller
public class AController {
	
	@Autowired
	DBM dbm;
	
	@RequestMapping(value = "/a")
	public String a() {
		System.out.println("Aa");
		return "a";
	}
}

package com.cm.org.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class BController {
	
	@RequestMapping(value = "/b")
	public String b() {
		System.out.println("Bb");
		return "b";
	}
}

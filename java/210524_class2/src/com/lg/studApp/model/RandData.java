package com.lg.studApp.model;

import java.util.Random;

public class RandData {
	
	String name[] = { "박효신", "한효주", "한지민", "이승기", "차은우", "송중기" };
	int age[] = { 41, 46, 39, 38, 26, 29 };
	char gender[] = { '남', '여' };
	String address[] = { "대구시 동구 신천 1동", "대구시 동구 신천2동", "대구시 동구 신천3동", 
			"대구시 동구 신천4동", "대구시 동구 신천5동" };
	
	Random r = new Random();
	public String getName() {
		return name[r.nextInt(6)];
	}
	
	public int getAge() {
		return age[r.nextInt(6)];
	}
	
	public char getGender() {
		return gender[r.nextInt(2)];
	}
	
	public String getAddress() {
		return address[r.nextInt(5)];
	}

}

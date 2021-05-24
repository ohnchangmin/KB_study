package com.lg.studApp.main;
import java.util.Random;

import com.lg.studApp.model.RandData;
import com.lg.studApp.model.Student;

public class studMain {

	public static void main(String[] args) {
		
//		String name[] = { "박효신", "한효주", "한지민", "이승기", "차은우", "송중기" };
//		int age[] = { 41, 46, 39, 38, 26, 29 };
//		char gender[] = { '남', '여' };
//		String address[] = { "대구시 동구 신천 1동", "대구시 동구 신천2동", "대구시 동구 신천3동", 
//				"대구시 동구 신천4동", "대구시 동구 신천5동" };


		RandData rd = new RandData();
		Student arr[] = new Student[10];
		Random r = new Random();

		for (int i = 0; i < arr.length; i++) {

			arr[i] = new Student(
					rd.getName(), 
					rd.getAge(), 
					rd.getGender(), 
					rd.getAddress());
			
			arr[i].showStInfo();
			//System.out.println(arr[i]);
		}
		
		//새로운 객체를 생성
		//arr[9] = new Student("전우치", 24, '남', "조선 한양인근 두메산골");
		//디자인패턴 - 싱글톤: 이미 만들어진 
		//이미 만들어진 객체에 셋터를 통해 설정
		arr[9].setName("전우치");
		arr[9].setAge(24);
		arr[9].setGender('남');
		arr[9].setAddress("조선 한양인근 두메산골");
		arr[9].showStInfo();
				
	}
}

package org20210809;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class AnnoMain {	
	public static void main(String[] args) {
		/*
		 * AnnoMain -> 메인함수
		 * Annotaion - 객체담는 통
		 * A 객체 담는 통안에 들어갈 클래스
		 * B 객체 담는 통안에 들어갈 클래스
		 */
		AnnotationConfigApplicationContext acac = new AnnotationConfigApplicationContext(AnnoConf.class);
		
		//싱글톤
		A a = acac.getBean(A.class);
		A a2 = acac.getBean(A.class);
		B b = acac.getBean(B.class);
		
		System.out.println(a);
		System.out.println(b);
		
		acac.close();
	}
}

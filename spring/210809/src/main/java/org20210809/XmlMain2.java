package org20210809;

import org.springframework.context.support.GenericXmlApplicationContext;

/*
 * xml 방식으로 DI
 * 생성자 방식으로 DI
 * set 방식으로 DI
 */

public class XmlMain2 {
	public static void main(String[] args) {
		GenericXmlApplicationContext gxac = new GenericXmlApplicationContext("classpath:XmlConf2.xml");

//싱글톤
		A a1 = gxac.getBean(A.class);
		A a2 = gxac.getBean(A.class);
		B b = gxac.getBean(B.class);

		System.out.println(a1);
		System.out.println(a2);
		System.out.println(b);
		
		System.out.println(a1.getAa());
		a1.setAa(200);
		System.out.println(a2.getAa());
		
		System.out.println(b.getA().getAa());
		
		gxac.close();
	}
}

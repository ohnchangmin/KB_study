package org1;

import org.springframework.context.support.GenericXmlApplicationContext;

public class MainXml {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		GenericXmlApplicationContext gxac = new GenericXmlApplicationContext("classpath:xmlConf.xml");
		MemberService ms = gxac.getBean(MemberService.class);
		ms.insert("홍길동", 331);
		ms.insert("전우치", 483);
		ms.dolist();
		
		gxac.close();

	}

}

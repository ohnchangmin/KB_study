package org20210809;

public class B {

	private A a;

	//생성자 만들기: Alt + Shift + r -> o
	public B() {
		
	}
	
	public B(A a) {
		super();
		this.a = a;
	}

	public A getA() {
		return a;
	}

	public void setA(A a) {
		this.a = a;
	}

	
}

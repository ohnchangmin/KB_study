package com.cm.carApp.customer;

public class Customer {
	private String name;
	private String tel;
	private String address;
	
	public Customer(String name, String tel, String address) {
		super();
		this.name = name;
		this.tel = tel;
		this.address = address;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getTel() {
		return tel;
	}

	public void setTel(String tel) {
		this.tel = tel;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}
	
	public void printCustomerInfo() {
		System.out.println("����: " + name);
		System.out.println("��ȭ��ȣ: " + tel);
		System.out.println("�ּ�: " + address);
	}

}

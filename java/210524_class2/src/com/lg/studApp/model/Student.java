package com.lg.studApp.model;

//한명(하나)에 대한 정보!! - 클래스 하나로 여러개 생성하면 돼
public class Student {
	private String name;
	private int age;
	private char gender; 
	private String address;
	
	public Student(String name, int age, char gender, String address) {
		super();
		this.name = name;
		this.age = age;
		this.gender = gender;
		this.address = address;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	@Override
	public String toString() {
		String str = "이름: " + name + "\n";
		str += "성별: " + gender + "\n";
		str += "나이: " + age + "\n";
		str += "주소: " + address + "\n";
		return str;
	}
	
	public void showStInfo() {
		System.out.println("이름: " + name);
		System.out.println("성별: " + gender);
		System.out.println("나이: " + age);
		System.out.println("주소: " + address);
		System.out.println("-------------------------------");
	}
}



package com.lg.studApp.model;

import java.util.Random;

public class RandData {
	
	String name[] = { "��ȿ��", "��ȿ��", "������", "�̽±�", "������", "���߱�" };
	int age[] = { 41, 46, 39, 38, 26, 29 };
	char gender[] = { '��', '��' };
	String address[] = { "�뱸�� ���� ��õ 1��", "�뱸�� ���� ��õ2��", "�뱸�� ���� ��õ3��", 
			"�뱸�� ���� ��õ4��", "�뱸�� ���� ��õ5��" };
	
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

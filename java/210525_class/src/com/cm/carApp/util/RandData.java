package com.cm.carApp.util;

import java.util.Random;

public class RandData {
	
	Random r = new Random();
	
	String name[] = {"ȫ�浿", "��浿", "�ڱ浿", "�̱浿", "�ֱ浿"};
	String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978",
			"010-7890-2134"};
	String address[] = {"�뱸�� ���� �ž�4��", "����� ���� �ž� 4��", "�λ�� ���� �ž�4��",
			"��õ�� ���� �ž�4��", "���ֽ� ���� �ž�4��"};
	String model[] = {"SM6", "�Ÿ", "��Ÿ��", "K7", "�׷���"};
	String color[] = {"��", "����", "���", "ȸ��", "����"};
	int year[] = {2016, 2017, 2016, 2017, 2016};
	String company[] = {"����Ｚ", "����", "����", "���", "����"};
	
	public String getName() {
		return name[r.nextInt(5)];
	}
	public String getTel() {
		return tel[r.nextInt(5)];
	}
	public String getAddress() {
		return address[r.nextInt(5)];
	}
	public String getModel() {
		return model[r.nextInt(5)];
	}
	public String getColor() {
		return color[r.nextInt(5)];
	}
	public int getYear() {
		return year[r.nextInt(5)];
	}
	public String getCompany() {
		return company[r.nextInt(5)];
	}
	
	

}

package com.cm.centerApp.utill;

import java.util.Random;

public class RandData {
	
	Random r = new Random();
	
	String name[] = {"������", "��ȿ��", "�ڼ���", "������", "��ȿ��"};
	String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978",
			"010-7890-2134"};
	boolean mCard[] = {true, false};
	String birthday[] = {"1994�� 06�� 15��", "1966�� 12�� 17��", "1961�� 01�� 09��", "1994�� 06�� 15��",
			"1978�� 04�� 04��"}; 
	String email[] = {"hong1@gmail.com", "hong2@gmail.com", "hong3@gmail.com",
			"hong4@gmail.com", "hong5@gmail.com"};
	String model[] = {"SM6", "�Ÿ", "��Ÿ��", "K7", "�׷���"};
	String year[] = {"2016���", "2017���", "2015���", "2018���", "2019���"};
	String cause[] = {"�������� ��ü", "Ÿ�̾� ��ü", "������ ��ü", "���������� ����", "���������� ��ü"};
	int dateIn[] = {20210520, 20210521, 20210522, 20210523, 20210524};
	int dateOut[] = {20210620, 20210621, 20210622, 20210623, 20210624};
	int price[] = {20000, 30000, 40000, 50000, 60000};
	
	public String getName() {
		return name[r.nextInt(5)];
	}
	public String getTel() {
		return tel[r.nextInt(5)];
	}
	public boolean getMCard() {
		return mCard[r.nextInt(2)];
	}
	public String getBirthday() {
		return birthday[r.nextInt(5)];
	}
	public String getEmail() {
		return email[r.nextInt(5)];
	}
	public String getModel() {
		return model[r.nextInt(5)];
	}
	public String getYear() {
		return year[r.nextInt(5)];
	}
	public String getCause() {
		return cause[r.nextInt(5)];
	}
	public int getDateIn() {
		return dateIn[r.nextInt(5)];
	}
	public int getDateOut() {
		return dateOut[r.nextInt(5)];
	}
	public int getPrice() {
		return price[r.nextInt(5)];
	}
}
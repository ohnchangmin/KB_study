package com.lg.studApp.main;
import java.util.Random;

import com.lg.studApp.model.RandData;
import com.lg.studApp.model.Student;

public class studMain {

	public static void main(String[] args) {
		
//		String name[] = { "��ȿ��", "��ȿ��", "������", "�̽±�", "������", "���߱�" };
//		int age[] = { 41, 46, 39, 38, 26, 29 };
//		char gender[] = { '��', '��' };
//		String address[] = { "�뱸�� ���� ��õ 1��", "�뱸�� ���� ��õ2��", "�뱸�� ���� ��õ3��", 
//				"�뱸�� ���� ��õ4��", "�뱸�� ���� ��õ5��" };


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
		
		//���ο� ��ü�� ����
		//arr[9] = new Student("����ġ", 24, '��', "���� �Ѿ��α� �θ޻��");
		//���������� - �̱���: �̹� ������� 
		//�̹� ������� ��ü�� ���͸� ���� ����
		arr[9].setName("����ġ");
		arr[9].setAge(24);
		arr[9].setGender('��');
		arr[9].setAddress("���� �Ѿ��α� �θ޻��");
		arr[9].showStInfo();
				
	}
}

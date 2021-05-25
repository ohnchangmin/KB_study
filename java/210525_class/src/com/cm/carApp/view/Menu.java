package com.cm.carApp.view;

import java.util.Scanner;

public class Menu {
	public static final int MAIN_MENU_VIEW = 1;
	public static final int MAIN_MENU_RAND_INS = 2;
	public static final int MAIN_MENU_INS = 3;
	public static final int MAIN_MENU_EXIT = 4;

	Scanner sc = new Scanner(System.in);

	public int mainMenu() {
		System.out.println("--------------------------");
		System.out.println("�߰��� �Ÿ� ���� ���α׷� v1.0");
		System.out.println("--------------------------");
		System.out.println("1.�߰��� �Ÿ� ��Ȳ ����");
		System.out.println("2.�߰��� �Ÿ� ���� �ڷ� �߰�");
		System.out.println("3.�߰��� �Ÿ� ���� �ڷ� �߰�");
		System.out.println("4.���α׷� ����");
		System.out.println("--------------------------");
		return sc.nextInt();

	}

	public int getRandCnt() {
		System.out.println("--------------------------");
		System.out.println("�����ϰ� ������ ���� �Է� ȭ��");
		System.out.println("--------------------------");
		System.out.println("������ �Է��ϼ���: ");
		return sc.nextInt();
	}
	
	public String getName() {
		System.out.println("�̸��� �Է��ϼ���: ");
		return sc.next();
	}
	
	public String getTel() {
		System.out.println("��ȣ �Է��ϼ���: ");
		return sc.next();
	}
	
	public String getAddress() {
		System.out.println("�ּҸ� �Է��ϼ���: ");
		return sc.nextLine();
	}
	
	public int getYear() {
		System.out.println("������ �Է��ϼ���: ");
		return sc.nextInt();
	}
	
	public String getModel() {
		System.out.println("���� �Է��ϼ���: ");
		return sc.next();
	}
	
	public String getColor() {
		System.out.println("������ �Է��ϼ���: ");
		return sc.next();
	}
	
	public String getCompany() {
		System.out.println("�����縦 �Է��ϼ���: ");
		return sc.next();
	}
	
}
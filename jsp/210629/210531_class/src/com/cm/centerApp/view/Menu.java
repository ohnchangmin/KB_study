package com.cm.centerApp.view;

import java.util.Scanner;
import com.cm.centerApp.model.Car;
import com.cm.centerApp.model.CarModify;
import com.cm.centerApp.model.Customer;

public class Menu {
	public static final int MAIN_MENU_ADD = 1;
	public static final int MAIN_MENU_VIEW = 2;
	public static final int MAIN_MENU_ADMIN = 3;
	public static final int MAIN_MENU_EXIT = 4;

	public static final int SUB_ADD_RAND = 1;
	public static final int SUB_ADD_INS = 2;
	public static final int SUB_ADD_EXIT = 3;
	
	public static final int ADMIN_MENU_SALE = 1;
	public static final int ADMIN_MENU_REPAIR = 2;
	public static final int ADMIN_MENU_EXIT = 3;
	

	Scanner sc = new Scanner(System.in);

	public int mainMenu() {
		System.out.println("----------------------");
		System.out.println("ī���� ���� ���α׷� v1.0");
		System.out.println("----------------------");
		System.out.println("1. ������ ���");
		System.out.println("2. ������ ��ȸ");
		System.out.println("3. ������ ���");
		System.out.println("4. ���α׷� ����");
		System.out.println("----------------------");
		System.out.println("���� �޴� ����");
		return sc.nextInt();
	}

	public int subMenu() {
		System.out.println("----------------------");
		System.out.println("###������ ��� ȭ��###");
		System.out.println("----------------------");
		System.out.println("1.���������� ���");
		System.out.println("2.���������� �����Է�");
		System.out.println("3.���θ޴��� ���ư���");
		System.out.println("----------------------");
		System.out.println("�޴� ����: ");
		return sc.nextInt();

	}

	public Customer addManual() {
		System.out.println("----------------------");
		System.out.println("###������ ��� ȭ��###");
		System.out.println("----------------------");
		System.out.println("����: ");
		String name = sc.next();
		System.out.println("����ó: ");
		String tel = sc.next();
		System.out.println("�����(Y:True N:False): ");
		boolean mCard = sc.nextBoolean();
		System.out.println("����: ");
		String birthday = sc.next();
		System.out.println("�̸���: ");
		String email = sc.next();
		System.out.println("������(K7, �׷���): ");
		String model = sc.next();
		System.out.println("����: ");
		String year = sc.next();
		System.out.println("��������: ");
		String cause = sc.next();
		System.out.println("������¥: ");
		int dateIn = sc.nextInt();
		System.out.println("����������: ");
		int dateOut = sc.nextInt();
		System.out.println("������: ");
		int price = sc.nextInt();
		System.out.println("���� ����(True/False): ");
		boolean repair = sc.nextBoolean();

		return new Customer(name, tel, mCard, birthday, email, new Car(model, year),
				new CarModify(cause, dateIn, dateOut, price, repair));
	}

	public int getCountRand() {
		System.out.println("���� ������ �ڷ��� �� �Է�: ");
		return sc.nextInt();
	}

	public int countRand() {
		System.out.println("���� ������ �ڷ��� �� �Է�: ");
		sc.nextInt();
		return sc.nextInt();
	}

	public String[] loginAdmin() {
		System.out.println("#####################");
		System.out.println("#####������ �α���######");
		System.out.println("#####################");
		System.out.println("ID: ");
		String id = sc.next();
		System.out.println("PASSWD: ");
		String passwd = sc.next();
		String info[] = {id, passwd};		
		return info;
	}

	public int adminMenu() {
		System.out.println("----------------------");
		System.out.println("#### ������ ��� ####");
		System.out.println("----------------------");
		System.out.println("1.���� �����հ�");
		System.out.println("2.�������� ��������");
		System.out.println("3.���� �޴��� �̵�");
		System.out.println("----------------------");
		System.out.println("�޴� ����: ");
		return sc.nextInt();
	}
}

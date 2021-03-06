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
		System.out.println("카센터 관리 프로그램 v1.0");
		System.out.println("----------------------");
		System.out.println("1. 고객정보 등록");
		System.out.println("2. 고객정보 조회");
		System.out.println("3. 관리자 모드");
		System.out.println("4. 프로그램 종료");
		System.out.println("----------------------");
		System.out.println("메인 메뉴 선택");
		return sc.nextInt();
	}

	public int subMenu() {
		System.out.println("----------------------");
		System.out.println("###고객정보 등록 화면###");
		System.out.println("----------------------");
		System.out.println("1.랜덤고객정보 등록");
		System.out.println("2.랜덤고객정보 직접입력");
		System.out.println("3.메인메뉴로 돌아가기");
		System.out.println("----------------------");
		System.out.println("메뉴 선택: ");
		return sc.nextInt();

	}

	public Customer addManual() {
		System.out.println("----------------------");
		System.out.println("###고객정보 등록 화면###");
		System.out.println("----------------------");
		System.out.println("고객명: ");
		String name = sc.next();
		System.out.println("연락처: ");
		String tel = sc.next();
		System.out.println("멤버쉽(Y:True N:False): ");
		boolean mCard = sc.nextBoolean();
		System.out.println("생일: ");
		String birthday = sc.next();
		System.out.println("이메일: ");
		String email = sc.next();
		System.out.println("차량모델(K7, 그랜져): ");
		String model = sc.next();
		System.out.println("연식: ");
		String year = sc.next();
		System.out.println("수리내역: ");
		String cause = sc.next();
		System.out.println("접수날짜: ");
		int dateIn = sc.nextInt();
		System.out.println("수리예정일: ");
		int dateOut = sc.nextInt();
		System.out.println("수리비: ");
		int price = sc.nextInt();
		System.out.println("수리 여부(True/False): ");
		boolean repair = sc.nextBoolean();

		return new Customer(name, tel, mCard, birthday, email, new Car(model, year),
				new CarModify(cause, dateIn, dateOut, price, repair));
	}

	public int getCountRand() {
		System.out.println("랜덤 생성할 자료의 수 입력: ");
		return sc.nextInt();
	}

	public int countRand() {
		System.out.println("랜덤 생성할 자료의 수 입력: ");
		sc.nextInt();
		return sc.nextInt();
	}

	public String[] loginAdmin() {
		System.out.println("#####################");
		System.out.println("#####관리자 로그인######");
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
		System.out.println("#### 관리자 모드 ####");
		System.out.println("----------------------");
		System.out.println("1.일일 매출합계");
		System.out.println("2.차량수리 내역보기");
		System.out.println("3.메인 메뉴로 이동");
		System.out.println("----------------------");
		System.out.println("메뉴 선택: ");
		return sc.nextInt();
	}
}

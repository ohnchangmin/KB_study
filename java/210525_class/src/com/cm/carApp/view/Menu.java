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
		System.out.println("중고차 매매 관리 프로그램 v1.0");
		System.out.println("--------------------------");
		System.out.println("1.중고차 매매 현황 보기");
		System.out.println("2.중고차 매매 랜덤 자료 추가");
		System.out.println("3.중고차 매매 수동 자료 추가");
		System.out.println("4.프로그램 종료");
		System.out.println("--------------------------");
		return sc.nextInt();

	}

	public int getRandCnt() {
		System.out.println("--------------------------");
		System.out.println("랜덤하게 생성할 개수 입력 화면");
		System.out.println("--------------------------");
		System.out.println("개수를 입력하세요: ");
		return sc.nextInt();
	}
	
	public String getName() {
		System.out.println("이름을 입력하세요: ");
		return sc.next();
	}
	
	public String getTel() {
		System.out.println("번호 입력하세요: ");
		return sc.next();
	}
	
	public String getAddress() {
		System.out.println("주소를 입력하세요: ");
		return sc.nextLine();
	}
	
	public int getYear() {
		System.out.println("연식을 입력하세요: ");
		return sc.nextInt();
	}
	
	public String getModel() {
		System.out.println("모델을 입력하세요: ");
		return sc.next();
	}
	
	public String getColor() {
		System.out.println("색상을 입력하세요: ");
		return sc.next();
	}
	
	public String getCompany() {
		System.out.println("제조사를 입력하세요: ");
		return sc.next();
	}
	
}
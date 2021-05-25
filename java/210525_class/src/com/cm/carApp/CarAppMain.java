package com.cm.carApp;

import com.cm.carApp.handler.CarSellMgr;
import com.cm.carApp.view.Menu;

public class CarAppMain {
	public static void main(String[] args) {

		Menu m = new Menu();
		CarSellMgr cs = new CarSellMgr();
		while (true) {
			switch (m.mainMenu()) {
			case Menu.MAIN_MENU_VIEW:
				cs.showSellInfo();
				// System.out.println("중고차 매매 현황 보기");
				break;
			case Menu.MAIN_MENU_RAND_INS:
				cs.randInsData(m.getRandCnt());
				// System.out.println("중고차 매매 랜덤 자료 추가");
				break;
			case Menu.MAIN_MENU_INS:
				cs.insData();

				// System.out.println("중고차 매매 수동 자료 추가");
				break;
			case Menu.MAIN_MENU_EXIT:
				cs.mainExit();
				// System.out.println("프로그램 종료");
				System.exit(0);
			default:
				System.out.println("올바른 메뉴를 선택하세요");
			}
		}
	}
}

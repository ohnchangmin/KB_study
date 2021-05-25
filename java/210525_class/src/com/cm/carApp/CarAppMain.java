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
				// System.out.println("�߰��� �Ÿ� ��Ȳ ����");
				break;
			case Menu.MAIN_MENU_RAND_INS:
				cs.randInsData(m.getRandCnt());
				// System.out.println("�߰��� �Ÿ� ���� �ڷ� �߰�");
				break;
			case Menu.MAIN_MENU_INS:
				cs.insData();

				// System.out.println("�߰��� �Ÿ� ���� �ڷ� �߰�");
				break;
			case Menu.MAIN_MENU_EXIT:
				cs.mainExit();
				// System.out.println("���α׷� ����");
				System.exit(0);
			default:
				System.out.println("�ùٸ� �޴��� �����ϼ���");
			}
		}
	}
}

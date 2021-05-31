package com.cm.centerApp;

import java.util.Scanner;

import com.cm.centerApp.Controller.CarController;
import com.cm.centerApp.model.Car;
import com.cm.centerApp.model.CarModify;
import com.cm.centerApp.model.Customer;
import com.cm.centerApp.utill.RandData;
import com.cm.centerApp.view.Menu;

public class CenterMain {

	public static void main(String[] args) {
		Menu m = new Menu();
		RandData rand = new RandData();
		CarController con = new CarController();

		while (true) {

			switch (m.mainMenu()) {
			case Menu.MAIN_MENU_ADD:
				//switch 쓰니까 break로 못빠져 나오니까 if로 쓰면 break가 먹힘
				//true를 변수로 두고 true false를 바꿔주는 방법
				while (true) {
					switch (m.subMenu()) {
					case Menu.SUB_ADD_RAND:
						System.out.println("고객정보 랜덤입력");
						con.addRandCustData(new Customer(
								rand.getName(),
								rand.getTel(),
								rand.getMCard(),
								rand.getBirthday(),
								rand.getEmail(),
								new Car(rand.getModel(),
										rand.getYear()),
								new CarModify(rand.getCause(),
										rand.getDateIn(),
										rand.getDateOut(),
										rand.getPrice())));
						continue;

					case Menu.SUB_ADD_INS:
						System.out.println("고객정보 수동입력");
						m.addManual();
						con.addCustData(m.addManual());
						continue;

					case Menu.SUB_ADD_EXIT:
						break;
					}
					break;
				}

			case Menu.MAIN_MENU_VIEW:
				con.viewCustData();
				
				break;
			case Menu.MAIN_MENU_ADMIN:
				System.out.println("관리자 모드");
				break;
			case Menu.MAIN_MENU_EXIT:
				System.out.println("### 프로그램 종료 ###");
				System.exit(0);
			}
		}

	}

}

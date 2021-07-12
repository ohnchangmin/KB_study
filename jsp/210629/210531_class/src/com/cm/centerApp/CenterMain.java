package com.cm.centerApp;

import com.cm.centerApp.Controller.CarController;
import com.cm.centerApp.utill.RandData;
import com.cm.centerApp.view.Menu;

public class CenterMain {

	public static void main(String[] args) {
		Menu m = new Menu();
		CarController con = new CarController();
		RandData rand = new RandData();

		while (true) {

			switch (m.mainMenu()) {
			case Menu.MAIN_MENU_ADD:				
				con.doAddWork(m, rand);			
				break;

			case Menu.MAIN_MENU_VIEW:
				con.viewCustData();
				break;
			case Menu.MAIN_MENU_ADMIN:
				if (con.doAdminLogin(m)==true) {
				con.doAdminWork(m);
				}
				break;
				
			case Menu.MAIN_MENU_EXIT:
				System.out.println("### 프로그램 종료 ###");
				System.exit(0);
			}
		}

	}

}

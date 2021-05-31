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
				//switch ���ϱ� break�� ������ �����ϱ� if�� ���� break�� ����
				//true�� ������ �ΰ� true false�� �ٲ��ִ� ���
				while (true) {
					switch (m.subMenu()) {
					case Menu.SUB_ADD_RAND:
						System.out.println("������ �����Է�");
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
						System.out.println("������ �����Է�");
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
				System.out.println("������ ���");
				break;
			case Menu.MAIN_MENU_EXIT:
				System.out.println("### ���α׷� ���� ###");
				System.exit(0);
			}
		}

	}

}

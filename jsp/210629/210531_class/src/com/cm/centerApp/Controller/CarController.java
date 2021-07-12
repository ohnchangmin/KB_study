package com.cm.centerApp.Controller;

import java.util.ArrayList;

import com.cm.centerApp.model.Car;
import com.cm.centerApp.model.CarModify;
import com.cm.centerApp.model.Customer;
import com.cm.centerApp.utill.Admin;
import com.cm.centerApp.utill.CommUtil;
import com.cm.centerApp.utill.RandData;
import com.cm.centerApp.view.Menu;

//MVC디자인 모델 --> 웹 - JSP

public class CarController {
	ArrayList<Customer> custList = new ArrayList<Customer>();

	public void addRandCustData(Customer cust) {
		custList.add(cust);
	}

	public void addRandCustData(int size, RandData rand) {
		for (int i = 0; i < size; i++)
			custList.add(new Customer(rand.getName(), rand.getTel(), rand.getMCard(), rand.getBirthday(),
					rand.getEmail(), new Car(rand.getModel(), rand.getYear()), new CarModify(rand.getCause(),
							rand.getDateIn(), rand.getDateOut(), rand.getPrice(), rand.getRepair())));
	}

	public void addCustData(Customer cust) {
		custList.add(cust);
	}

	public void viewCustData() {
		for (int i = 0; i < custList.size(); i++) {
			System.out.println(custList.get(i).toString());
		}
	}

	public void doAddWork(Menu m, RandData rand) {
		while (true) {
			switch (m.subMenu()) {
			case Menu.SUB_ADD_RAND:
				addRandCustData(m.getCountRand(), rand);

				continue;

			case Menu.SUB_ADD_INS:
				addCustData(m.addManual());
				continue;

			case Menu.SUB_ADD_EXIT:
				break;
			}
			break;
		}

	}

	public boolean doAdminLogin(Menu m) {
		while (true) {
			String info[] = m.loginAdmin();
			if (info[0].equals(Admin.ADMIN_ID) == false) {
				System.out.println("잘못된 아이디입니다.");
				continue;
			} else if (info[1].equals(Admin.ADMIN_PASSWD) == false) {
				System.out.println("잘못된 비밀번호입니다.");
				continue;
			} else
				return true;
		}

	}

	public void doAdminWork(Menu m) {
		while (true) {
			int menu = m.adminMenu();
			if (menu == Menu.ADMIN_MENU_SALE) {
				System.out.println("일일 매출액: " + dayOfSale());

			} else if (menu == Menu.ADMIN_MENU_REPAIR) {
				showFixList();
			}

			else if (menu == Menu.ADMIN_MENU_EXIT) {
				System.out.println("메인 메뉴로 이동");
				break;
			}
			
			else {
				System.out.println("잘못된 입력입니다! 다시 입력해주세요.");
			}
		}

	}

	public String dayOfSale() {
		int sum = 0;
		for (int i = 0; i < custList.size(); i++) {
			sum += custList.get(i).getCarModify().getPrice();
		}
		return CommUtil.getKorMoney(sum);
	}

	public void showFixList() {
		// 이름, 전화번호, 차종, 수리완료 여부, 수리비
		for (int i = 0; i < custList.size(); i++) {
			System.out.println("고객명: " + custList.get(i).getName() + " " + "전화번호: " + custList.get(i).getTel() + " "
					+ "차량모델: " + custList.get(i).getCar().getModel() + " " + "수리완료 여부: "
					+ custList.get(i).getCarModify().getRepair() + " " + "수리비: "
					+ CommUtil.getKorMoney(custList.get(i).getCarModify().getPrice()));
		}
	}
}

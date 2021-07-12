package com.cm.centerApp.Controller;

import java.util.ArrayList;

import com.cm.centerApp.model.Car;
import com.cm.centerApp.model.CarModify;
import com.cm.centerApp.model.Customer;
import com.cm.centerApp.utill.Admin;
import com.cm.centerApp.utill.CommUtil;
import com.cm.centerApp.utill.RandData;
import com.cm.centerApp.view.Menu;

//MVC������ �� --> �� - JSP

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
				System.out.println("�߸��� ���̵��Դϴ�.");
				continue;
			} else if (info[1].equals(Admin.ADMIN_PASSWD) == false) {
				System.out.println("�߸��� ��й�ȣ�Դϴ�.");
				continue;
			} else
				return true;
		}

	}

	public void doAdminWork(Menu m) {
		while (true) {
			int menu = m.adminMenu();
			if (menu == Menu.ADMIN_MENU_SALE) {
				System.out.println("���� �����: " + dayOfSale());

			} else if (menu == Menu.ADMIN_MENU_REPAIR) {
				showFixList();
			}

			else if (menu == Menu.ADMIN_MENU_EXIT) {
				System.out.println("���� �޴��� �̵�");
				break;
			}
			
			else {
				System.out.println("�߸��� �Է��Դϴ�! �ٽ� �Է����ּ���.");
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
		// �̸�, ��ȭ��ȣ, ����, �����Ϸ� ����, ������
		for (int i = 0; i < custList.size(); i++) {
			System.out.println("����: " + custList.get(i).getName() + " " + "��ȭ��ȣ: " + custList.get(i).getTel() + " "
					+ "������: " + custList.get(i).getCar().getModel() + " " + "�����Ϸ� ����: "
					+ custList.get(i).getCarModify().getRepair() + " " + "������: "
					+ CommUtil.getKorMoney(custList.get(i).getCarModify().getPrice()));
		}
	}
}

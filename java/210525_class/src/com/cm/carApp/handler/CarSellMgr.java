package com.cm.carApp.handler;

import java.util.ArrayList;
import java.util.Scanner;

import com.cm.carApp.car.Car;
import com.cm.carApp.customer.Customer;
import com.cm.carApp.util.RandData;
import com.cm.carApp.view.Menu;

public class CarSellMgr {
	ArrayList<Customer> cuList = new ArrayList<Customer>();
	RandData rd = new RandData();
	Menu m = new Menu();

	public void showSellInfo() {
		for (Customer cu : cuList) {
			cu.printCustomerInfo();
		}

//		for (int i=0; i<cuList.size(); i++) {
//			cuList.get(i).printCustomerInfo();
//		}
	}

	public void randInsData() {
		System.out.println("추가할 자료의 수를 입력하세요: ");
		cuList.add(new Customer(rd.getName(), rd.getTel(), rd.getAddress(),
				new Car(rd.getModel(), rd.getColor(), rd.getYear(), rd.getCompany())));
	}

	public void randInsData(int n) {
		for (int i = 0; i < n; i++) {
			cuList.add(new Customer(rd.getName(), rd.getTel(), rd.getAddress(),
					new Car(rd.getModel(), rd.getColor(), rd.getYear(), rd.getCompany())));
		}
	}

	public void insData() {
		cuList.add(new Customer(m.getName(), m.getTel(), m.getAddress(), new Car(m.getModel(), m.getColor(),
				m.getYear(), m.getCompany())));

	}

	public void mainExit() {

	}

}

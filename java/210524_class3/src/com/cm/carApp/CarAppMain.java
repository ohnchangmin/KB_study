package com.cm.carApp;

import java.util.ArrayList;

import com.cm.carApp.car.Car;
import com.cm.carApp.customer.Customer;
import com.cm.carApp.util.RandData;

public class CarAppMain {

	public static void main(String[] args) {
		Customer cu[] = new Customer[10];
		//제네릭 + 컬렉션 클래스
		ArrayList<Customer> arrList = new ArrayList<Customer>();
		RandData rd = new RandData();
		for (int i = 0; i < cu.length; i++) {
			cu[i] = new Customer(rd.getName(), rd.getTel(), rd.getAddress(),
					new Car(rd.getModel(), rd.getColor(), rd.getYear(), rd.getCompany()));

			cu[i].printCustomerInfo();
			arrList.add(cu[i]);
		}
		
		//어레이리스트 출력
		System.out.println("###########################");
		System.out.println("ArrayList 고객 정보");
		System.out.println("###########################");
		for(int i=0; i<arrList.size(); i++) {
			Customer cuList = arrList.get(i);
			cuList.printCustomerInfo();
			arrList.get(i).printCustomerInfo();
		}

	}
}

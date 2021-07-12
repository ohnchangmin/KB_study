package com.cm.centerApp.model;

import com.cm.centerApp.utill.CommUtil;

public class CarModify {
	private String cause; // ���� ����
	private int dateIn; // ���� ��¥
	private int dateOut; // �Ϸ� ��¥
	private int price; // �ݾ�
	private boolean repair;

	public CarModify(String cause, int dateIn, int dateOut, int price) {
		super();
		this.cause = cause;
		this.dateIn = dateIn;
		this.dateOut = dateOut;
		this.price = price;
	}

	public CarModify(String cause, int dateIn, int dateOut, int price, boolean repair) {
		super();
		this.cause = cause;
		this.dateIn = dateIn;
		this.dateOut = dateOut;
		this.price = price;
		this.repair = repair;
	}

	public String getCause() {
		return cause;
	}

	public void setCause(String cause) {
		this.cause = cause;
	}

	public int getDateIn() {
		return dateIn;
	}

	public void setDateIn(int dateIn) {
		this.dateIn = dateIn;
	}

	public int getDateOut() {
		return dateOut;
	}

	public void setDateOut(int dateOut) {
		this.dateOut = dateOut;
	}

	public int getPrice() {
		return price;
	}

	public void setPrice(int price) {
		this.price = price;
	}		

	public boolean getRepair() {
		return repair;
	}

	public void setRepair(boolean repair) {
		this.repair = repair;
	}
	
	

	@Override
	public String toString() {
		String str = "��������: " + cause + "\n";
		str += "������¥: " + dateIn + "\n";
		str += "�����Ϸᳯ¥: " + dateOut + "\n";
		str += "������: " + CommUtil.getKorMoney(price) + "\n";
		str += "������������: " + repair + "\n";
		return str;
	}

}

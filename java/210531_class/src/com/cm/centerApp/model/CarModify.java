package com.cm.centerApp.model;

public class CarModify {
	private String cause; 	//���� ����
	private int dateIn; 	//���� ��¥
	private int dateOut; //�Ϸ� ��¥
	private int price;		//�ݾ�
	
	public CarModify(String cause, int dateIn, int dateOut, int price) {
		super();
		this.cause = cause;
		this.dateIn = dateIn;
		this.dateOut = dateOut;
		this.price = price;
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

	@Override
	public String toString() {
		String str = "��������: " + cause + "\n";
		str += "������¥: " + dateIn + "\n";
		str += "�����Ϸᳯ¥: " + dateOut + "\n";
		str += "������: " + price + "\n";
		return str;
	}
	
	
	
	
}

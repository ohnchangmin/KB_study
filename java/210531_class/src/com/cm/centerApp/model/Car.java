package com.cm.centerApp.model;

public class Car {
	private String model; // 차량 모델
	private String year; // 연식

	public Car(String model, String year) {
		super();
		this.model = model;
		this.year = year;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getYear() {
		return year;
	}

	public void setYear(String year) {
		this.year = year;
	}

	@Override
	public String toString() {
		String str = "수리차량: " + model + "\n";
		str += "연식: " + year + "\n";
		return str;
	}
}

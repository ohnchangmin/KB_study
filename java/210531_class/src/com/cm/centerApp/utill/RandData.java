package com.cm.centerApp.utill;

import java.util.Random;

public class RandData {
	
	Random r = new Random();
	
	String name[] = {"아이유", "박효신", "박서준", "한지민", "한효주"};
	String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978",
			"010-7890-2134"};
	boolean mCard[] = {true, false};
	String birthday[] = {"1994년 06월 15일", "1966년 12월 17일", "1961년 01월 09일", "1994년 06월 15일",
			"1978년 04월 04일"}; 
	String email[] = {"hong1@gmail.com", "hong2@gmail.com", "hong3@gmail.com",
			"hong4@gmail.com", "hong5@gmail.com"};
	String model[] = {"SM6", "쏘나타", "싼타페", "K7", "그랜져"};
	String year[] = {"2016년식", "2017년식", "2015년식", "2018년식", "2019년식"};
	String cause[] = {"엔진오일 교체", "타이어 교체", "와이퍼 교체", "에어컨가스 충전", "에어컨필터 교체"};
	int dateIn[] = {20210520, 20210521, 20210522, 20210523, 20210524};
	int dateOut[] = {20210620, 20210621, 20210622, 20210623, 20210624};
	int price[] = {20000, 30000, 40000, 50000, 60000};
	
	public String getName() {
		return name[r.nextInt(5)];
	}
	public String getTel() {
		return tel[r.nextInt(5)];
	}
	public boolean getMCard() {
		return mCard[r.nextInt(2)];
	}
	public String getBirthday() {
		return birthday[r.nextInt(5)];
	}
	public String getEmail() {
		return email[r.nextInt(5)];
	}
	public String getModel() {
		return model[r.nextInt(5)];
	}
	public String getYear() {
		return year[r.nextInt(5)];
	}
	public String getCause() {
		return cause[r.nextInt(5)];
	}
	public int getDateIn() {
		return dateIn[r.nextInt(5)];
	}
	public int getDateOut() {
		return dateOut[r.nextInt(5)];
	}
	public int getPrice() {
		return price[r.nextInt(5)];
	}
}
package com.cm.centerApp.utill;


public class CommUtil {
	public static String getKorMoney(int money) {
		DeciamlFormat dc = new DecimalFormat("###,###,###,###");
		return "��" + dc.format(money) + "��";
	}

}

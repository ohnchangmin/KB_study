package com.cm.centerApp.utill;

import java.text.DecimalFormat;

public class CommUtil {
	public static String getKorMoney(int money) {
		DecimalFormat dc = new DecimalFormat("###,###,###,###");
		return "��" + dc.format(money) + "��";
	}

}

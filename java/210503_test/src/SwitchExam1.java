import java.util.Scanner;

public class SwitchExam1 {

	public static void main(String[] args) {
		//--------------------------
		//식당메뉴 자동 주문 프로그램 v1.0
		//--------------------------
		//원하는 식사를 선택하세요
		//1.김치찌개: 5000원
		//2.된장찌개: 5000원
		//3.칼국수: 5000원
		//4.잔치국수: 4000원
		//5.비빔밥: 5000원
		//--------------------------
		//메뉴 선택:
		
		//[출력형태]
		//비빔밥을 주문했습니다.
	

	
	System.out.println("--------------------------");
	System.out.println("식당메뉴 자동 주문 프로그램 v1.0");
	System.out.println("--------------------------");
	System.out.println("원하는 식사를 선택하세요");
	System.out.println("1.김치찌개: 5000원");
	System.out.println("2.된장찌개: 5000원");
	System.out.println("3.칼국수: 5000원");
	System.out.println("4.잔치국수: 4000원");
	System.out.println("5.비빔밥: 5000원");
	
	Scanner sc = new Scanner(System.in);
	
	System.out.println("메뉴를 선택하세요: ");
	int menu = sc.nextInt();
	sc.close();
	
	switch(menu) {
	case 1:
		System.out.println("김치찌개를 선택했습니다.");
		break;
	case 2:
		System.out.println("된장찌개를 선택했습니다.");
		break;
	case 3:
		System.out.println("칼국수를 선택했습니다.");
		break;
	case 4:
		System.out.println("잔치국수를 선택했습니다.");
		break;
	case 5:
		System.out.println("비빔밥을 선택했습니다.");
		break;
		}
	}
}

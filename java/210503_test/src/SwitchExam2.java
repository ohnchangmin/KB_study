import java.util.Scanner;

public class SwitchExam2 {

	public static void main(String[] args) {
		//----------------------
		//음료 자판기 프로그램 v1.0
		//----------------------
		//원하는 음료를 메뉴에서 선택하세요.
		//1. 아몬드브리즈		:1500원
		//2. 빙그레 바나나 우유	:1200원
		//3. 덴마크 드링크		:1800원
		//4. 아메리카노			:1700원
		//5. 코카콜라 			:800원
		//----------------------
		//음료를 선택하세요:4
		//아몬드브리즈를 선택하였습니다.
		//----------------------
		//금액을 투입하세요: 2000
		//아몬드브리즈를 구매했습니다.
		//거스름돈 500원을 받으세요
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("-------------------------------");
		System.out.println("음료 자판기 프로그램 v1.0");
		System.out.println("-------------------------------");
		System.out.println("원하는 음료를 메뉴에서 선택하세요.");
		System.out.println("1. 아몬드브리즈:		1500원");
		System.out.println("2. 빙그레 바나나 우유:	1200원");
		System.out.println("3. 덴마크 드링크:		1800원");
		System.out.println("4. 아메리카노:		1700원");
		System.out.println("5. 코카콜라:		 800원");
		System.out.println("음료를 선택하세요: ");
		int menu = sc.nextInt();
		
		switch(menu) {
		case 1:
			System.out.println("아몬드브리즈를 선택하였습니다.");
			System.out.println("금액을 투입하세요: ");
			int price = sc.nextInt();
			int change = price - 1500;
			System.out.println("아몬드브리즈를 구매했습니다.");
			System.out.println("거스름돈 " + change + "를 받으세요.");
			break;
			
		case 2:
			System.out.println("빙그레 바나나 우유를 선택하였습니다.");
			System.out.println("금액을 투입하세요: ");
			price = sc.nextInt();
			change = price - 1200;
			System.out.println("빙그레 바나나 우유를 구매했습니다.");
			System.out.println("거스름돈 " + change + "를 받으세요.");
			break;
			
		case 3:
			System.out.println("덴마크 드링크를 선택하였습니다.");
			System.out.println("금액을 투입하세요: ");
			price = sc.nextInt();
			change = price - 1800;
			System.out.println("덴마크 드링크를 구매했습니다.");
			System.out.println("거스름돈 " + change + "를 받으세요.");
			break;
			
		case 4:
			System.out.println("아메리카노를 선택하였습니다.");
			System.out.println("금액을 투입하세요: ");
			price = sc.nextInt();
			change = price - 1700;
			System.out.println("아메리카노를 구매했습니다.");
			System.out.println("거스름돈 " + change + "를 받으세요.");
			break;
			
		case 5:
			System.out.println("코카콜라를 선택하였습니다.");
			System.out.println("금액을 투입하세요: ");
			price = sc.nextInt();
			change = price - 800;
			System.out.println("코카콜라를 구매했습니다.");
			System.out.println("거스름돈 " + change + "를 받으세요.");
			break;
		}
		
		sc.close();
		
		

	}

}

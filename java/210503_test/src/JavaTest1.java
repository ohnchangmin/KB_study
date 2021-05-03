import java.util.Scanner;

public class JavaTest1 {

	public static void main(String[] args) {

		//주석 /* */
		//자바 기본 출력
//		System.out.println("111");
//		System.out.print("222" + "\n");
//		System.out.println("333");
//		System.out.printf("%d\n", 100);
		
		//입력
		Scanner sc = new Scanner(System.in);
//		System.out.print("나이 입력: ");
//		int age = sc.nextInt();
//		System.out.println("이름 입력: ");
//		String name = sc.next();
//		
//		System.out.println("이름: " + name);
//		System.out.println("나이: " + age);
//		sc.close();
		
		//국어, 영어, 수학 점수를 입력 받고
		//총점과 평균을 구하는 프로그램 작성
		
//		System.out.println("국어 점수 입력: ");
//		int kor = sc.nextInt();
//		System.out.println("영어 점수 입력: ");
//		int eng = sc.nextInt();
//		System.out.println("수학 점수 입력: ");
//		int math = sc.nextInt();
//
//		int total = kor + eng + math;
//		System.out.println("총점: " + total);
//		System.out.println("평균: " + total/3.0);
		
		//동전은 각각 500, 100, 50, 10원 사용
		//특정 금액 입력 ex)1260
		//----------------------------
		//동전 교환 프로그램 v1.0
		//----------------------------
		//오백원 개수: 2개
		//백원 개수: 2개
		//오십원 개수: 1개
		//십원 개수: 1개
		
		System.out.println("금액을 입력해주세요: ");
		int price = sc.nextInt();
		int num500 = price / 500;
		int num100 = (price - (500*num500))/100;
		int num50 = (price - (500*num500) - (100*num100)) / 50;
		int num10 = (price - (500*num500) - (100*num100) - (50*num50)) / 10;
		
		System.out.println("----------------------------");
		System.out.println("동전 교환 프로그램 v1.0");
		System.out.println("----------------------------");
		
		System.out.println("오백원 개수: "+num500);
		System.out.println("백원 개수: " +num100);
		System.out.println("오십원 개수: "+num50);
		System.out.println("십원 개수: "+num10);
		
		sc.close();
	}

}

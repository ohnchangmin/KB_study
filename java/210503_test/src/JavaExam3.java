import java.util.Scanner;

public class JavaExam3 {

	public static void main(String[] args) {
		//---------------------------------
		//학점 관리 프로그램 v1.0
		//---------------------------------
		//100~90 : A학점
		//89~80: B학점
		//79~70: C학점
		//69~60: D학점
		//59~0: F학점
		//-------------------
		//국어 점수 입력
		//수학 점수 입력
		//영어 점수 입력
		
		//[출력형태]
		//총점:278, 평균:90, 학점:A학점
		
		
		Scanner sc = new Scanner(System.in);
		System.out.println("-----------------------------");
		System.out.println("학점 관리 프로그램 v1.0");
		System.out.println("-----------------------------");
		System.out.println("90~100: 	A학점");
		System.out.println(" 80~89: 	B학점");
		System.out.println(" 70~79: 	C학점");
		System.out.println(" 60~69: 	D학점");
		System.out.println("  0~59: 	F학점");
		
		System.out.println("국어 점수 입력: ");
		int kor = sc.nextInt();
		System.out.println("영어 점수 입력: ");
		int eng = sc.nextInt();
		System.out.println("수학 점수 입력: ");
		int math = sc.nextInt();
		
		int total = kor + eng + math;
		double ave = total / 3.0;
		
		sc.close();
		
		if (ave>=90) {
			System.out.println("총점: " + total + "\t" + "평균: " + ave + "\t" + "학점: A학점");
		}
		else if(ave>=80) {
			System.out.println("총점: " + total + "\t" + "평균: " + ave + "\t" + "학점: B학점");
		}
		else if(ave>=70) {
			System.out.println("총점: " + total + "\t" + "평균: " + ave + "\t" + "학점: C학점");
		}
		else if(ave>=60) {
			System.out.println("총점: " + total + "\t" + "평균: " + ave + "\t" + "학점: D학점");
		}
		else {
			System.out.println("총점: " + total + "\t" + "평균: " + ave + "\t" + "학점: F학점");
		}
	}
}

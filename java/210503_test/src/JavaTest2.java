import java.util.Scanner;

public class JavaTest2 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		System.out.print("점수 입력(0~100): ");
		int score = sc.nextInt();
		System.out.println("학년 입력(1~4): ");
		int year = sc.nextInt();
		sc.close();
		
		if(score >= 60) {
			if(year != 4) {
				System.out.println("합격");
				}
			else if(score>=70) {
				System.out.println("합격");
				}
			else {
				System.out.println("불합격");	
			}
		}
		else {
			System.out.println("불합격");
		}
		
	}

}

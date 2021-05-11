import java.util.Scanner;

public class Method2 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("첫번째 항 입력: ");
		int num1 = sc.nextInt();
		System.out.print("두번째 항 입력: ");
		int num2 = sc.nextInt();
		System.out.print("연산자 입력(+,-,*,/): ");
		String op = sc.next();
		
		sc.close();

		calcul(num1, num2, op);
	}

	// 간단한 사칙연산 계산기
	public static void calcul(int num1, int num2, String op) {
		switch (op) {
		case ("+"):
			System.out.println(num1 + num2);
			break;

		case ("-"):
			System.out.println(num1 - num2);
			break;

		case ("*"):
			System.out.println(num1 * num2);
			break;

		case ("/"):
			System.out.println(num1 / num2);
			break;
		}

	}

}

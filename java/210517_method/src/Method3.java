import java.util.Scanner;

public class Method3 {

	public static void main(String[] args) {
		System.out.println("���丮�� ���� �Է�: ");
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		sc.close();
		System.out.println(fact(n));

	}

	public static int fact(int n) {
		if (n <= 1) {
			return 1;
		}

		else {
			return n * fact(n - 1);
		}
	}

}

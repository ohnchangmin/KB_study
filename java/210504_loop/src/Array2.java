import java.util.Scanner;

public class Array2 {

	public static void main(String[] args) {
		//1. 입력받는 값의 범위 1~65535
		//2. int 배열크기 16으로 사용하여 각각의 공간에
		//   이진수 0,1 저장
		//3. 10진수를 2진수로 변경하여 2번 배열에 저장하여 출력
		//4. 8을 입력하면 00001000을 출력
		//   255를 입력하면 11111111 출력
		//   256을 입력하면 00000001 00000000 출력

		Scanner sc = new Scanner(System.in);
		System.out.println("숫자를 입력하세요: ");		
		int num = sc.nextInt();	
		sc.close();

		int arr[] = new int[16];	
		for (int i=15; i>=0; i--) {
			arr[i] = num%2;
			num = num/2;
		}

		for (int i=0; i<arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
	}	
}


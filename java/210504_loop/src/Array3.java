import java.util.Random;

public class Array3 {

	public static void main(String[] args) {

		Random r = new Random();

		//1~45까지 난수 생성
		int arr[] = new int[6];
		for (int i=0; i<arr.length; i++) {
			arr[i] = r.nextInt(45)+1;
		}

		//중복 제거
		for (int i =0; i<arr.length; i++) {
			for (int j=0; j<arr.length; j++) {
				if(i == j) {
					break;
				}
				else if(arr[i] == arr[j]) {
					arr[j] = r.nextInt(45)+1;
				}
			}
		}

		//출력
		System.out.println("-----------------------------");
		System.out.println("간단한 로또 프로그램 v1.0");
		System.out.println("-----------------------------");
		for(int i=0; i<arr.length; i++) {
			System.out.print(arr[i] + " ");
		}

	}

}

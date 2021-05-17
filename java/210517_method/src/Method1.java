import java.util.Random;

public class Method1 {

	public static void main(String[] args) {
		int arr [] = new int [10];  //new는 메모리적이 관점으로는 공간을 확보, 객체지향적 관점으로는 객체를 하나 생성
		Random r = new Random();
		
		for (int i = 0; i<arr.length; i++) {
			arr[i] = r.nextInt(100) + 1;
		}
		
		check(arr);
	
	}	
		
	public static void check(int arr[]) {
		for (int i = 0; i<arr.length; i++) {
			if (arr[i] % 2 == 0) {
				System.out.print("짝수" + " ");
			}
			
			else {
				System.out.print("홀수" + " ");
			}
		}
		
	}
	
	

	

}

import java.util.Random;

public class Method1 {

	public static void main(String[] args) {
		int arr [] = new int [10];  //new�� �޸����� �������δ� ������ Ȯ��, ��ü������ �������δ� ��ü�� �ϳ� ����
		Random r = new Random();
		
		for (int i = 0; i<arr.length; i++) {
			arr[i] = r.nextInt(100) + 1;
		}
		
		check(arr);
	
	}	
		
	public static void check(int arr[]) {
		for (int i = 0; i<arr.length; i++) {
			if (arr[i] % 2 == 0) {
				System.out.print("¦��" + " ");
			}
			
			else {
				System.out.print("Ȧ��" + " ");
			}
		}
		
	}
	
	

	

}

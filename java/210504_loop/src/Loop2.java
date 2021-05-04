
public class Loop2 {

	public static void main(String[] args) {
		//이중루프 = 2차원 배열, 정렬(비교)

		for (int i=1; i<=9; i++) {           //기준이되는(변하지 않는)
			for(int j=2; j<=9; j++) {
				System.out.printf("%dx%d=%d \t", j, i, i*j);
			}
			System.out.println();
		}

	}
}

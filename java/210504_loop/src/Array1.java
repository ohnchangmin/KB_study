
public class Array1 {

	public static void main(String[] args) {
		int[] num = {10, 20, 30, 40, 50};	
		int num2[] = {10, 20};
		int num3[] = new int[10];

		for (int i=0; i<num3.length; i++) {
			num3[i] = 10;
		}

		int arr1[][] = new int[2][3];
		for (int i=0; i<arr1.length; i++) {
			for (int j=0; j<arr1[i].length; j++) {

			}
		}



		//2차원 배열
		int[][] arr2 = {
				{1,2}, {4}, {7,8,9,10}
		};

		for(int[] i : arr2) {
			for ( int j : i) {
				System.out.print(j + " ");
			}
			System.out.println();
		}

		System.out.println("================================");
		System.out.println("arr2.length: " + arr2.length);

		for (int i=0; i<arr2.length; i++) {
			for (int j=0; j<arr2[i].length; j++) {
				System.out.print(arr2[i][j] + " ");
			}
			System.out.println();
		}

		System.out.println("=============================");



		//3차원 배열
		int arr3[][][] = {
				{{1,2,3}, {3,4,5}},
				{{5,6,7}, {6,7,8}},					
		};



		for (int i = 0; i<arr3.length; i++) {
			for(int j=0; j<arr3[i].length; j++) {
				for (int k=0; k<arr3[i][j].length; k++) {
					System.out.print(arr3[i][j][k] +" ");
				}
				System.out.println();
			}
			System.out.println();
		}
		System.out.println("=============================");

		for(int[][] i : arr3) {
			for (int[] j : i) {
				for (int k : j) {
					System.out.print(k + " ");
				}
				System.out.println();
			}
			System.out.println();		
		}

	}

}

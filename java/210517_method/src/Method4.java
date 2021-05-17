import java.util.Random;

public class Method4 {

	public static void main(String[] args) {

		int[][] arr = getScore();
		int sum = 0;
		for (int[] i : arr) {
			for (int j : i) {
				System.out.print(j + " ");
				sum += j;
			}
			System.out.print("총점: " + sum + " ");
			System.out.print("평균: " + (sum/3) + " ");
			grade(sum/3);
			System.out.println();
			sum = 0;
		}

	}

	public static int[][] getScore() {
		Random r = new Random();
		int[][] score = new int[5][3];
		for (int i = 0; i < score.length; i++) {
			for (int j = 0; j < score[i].length; j++) {
				score[i][j] = r.nextInt(100) + 1;
			}
		}
		return score;
	}
	
	public static void grade(int sum) {
		if (sum >= 90) {
			System.out.println("A학점");
		}
		
		else if (sum >= 80) {
			System.out.println("B학점");
		}
		
		else if (sum >= 70) {
			System.out.println("C학점");
		}
		
		else if (sum >= 60) {
			System.out.println("D학점");
		}
		
		else if (sum >= 50) {
			System.out.println("E학점");
		}
		
		else {
			System.out.println("F학점");
		}
		
	}

}

import java.util.Random;

public class Method2 {

	public static void main(String[] args) {
		int[] arr = lotto();
		for(int n : arr)
		System.out.print(n + " ");
	}

	public static int[] lotto() {
		Random r = new Random();
		int[] lottoArr = new int[6];
		for (int i = 0; i < lottoArr.length; i++) {
			int num = r.nextInt(45) + 1;
			lottoArr[i] = num;
				for (int j = 0; j < i; j++) {
					if (num == lottoArr[j]) {
						i--;
						break;
					}
				}
			}
		return lottoArr;
		}
	}


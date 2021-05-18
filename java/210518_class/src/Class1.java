import java.util.Random;

public class Class1 {

	public static void main(String[] args) {
		// StudentScore는 결국 타입
		
		String name[] = { "아이유", "박효신", "김범수", "임재범", "유재석" };
		int score[] = { 20, 40, 60, 80, 100 };
		Random r = new Random();

		// 클래스변수
		System.out.println("------------------------------");
		System.out.println("학교: " + StudentScore.SCHOOL);
		System.out.println("------------------------------");
		
		// 객체 생성이 안 돼 = 생성자가 없어서
		//class 타입을 가지는 배열
		StudentScore arr[] = new StudentScore[5];

		for (int i = 0; i < arr.length; i++) {
			System.out.println("번호: " + (i + 1));
			arr[i] = new StudentScore(
					name[r.nextInt(5)], 
					score[r.nextInt(5)], 
					score[r.nextInt(5)],
					score[r.nextInt(5)]);
		}
	}
}
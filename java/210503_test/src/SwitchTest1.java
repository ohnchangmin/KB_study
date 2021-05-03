import java.util.Random;

public class SwitchTest1 {

	public static void main(String[] args){
//		0~3 랜덤 숫자 발생
//		int time = (int)(Math.random()*4);		
//		System.out.println(time);
		
		Random r = new Random();
		int time = r.nextInt(4)+8;
		System.out.println(time);
		
		switch (time) {
		case 8:
			System.out.println("등교");
			break;
			
		case 9:
			System.out.println("수업시작");
			break;
			
		case 10:
			System.out.println("간식시간");
			break;
			
		default:
			System.out.println("외출");
			break;
		}

	}

}

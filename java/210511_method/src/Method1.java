public class Method1 {

	public static void main(String[] args) {
		// void 존재하면 실행후 종료
		// 1. void method1() : 매개변수X
		// 2. void method2(매개변수...) : 매개변수O

		// 타입이 존재하면 반드시 return 필요
		// 3. 타입 method3() : 타입과 일치하는 return 값 필요
		// 4. 타입 method4(매개변수...) : return필요, 매개변수 O

		// 5. 재귀함수
		
		//메쏘드 호출(사용)
		method1();
		showName();
		showAge();
		showName("홍길동");
		showName("온창민", 28);
		showName(3781);

	}

	// 메쏘드 정의
	public static void method1() {
		for (int i = 0; i < 5; i++) {
			System.out.println("method1() 호출");
		}
		//메소드에서도 메소드 호출가능
		showName();
	}

	
	public static void showName() {
		String name = "홍길동";
		System.out.println(name);
	}
	
	public static void showAge() {
		System.out.println("100");
	}
	
	//객체지향의 특징: 오버로딩(중복정의)
	//단 매개변수 타입이 달라야 함 or 매개변수 개수가 달라야 함
	public static void showName(String name) {
		System.out.println(name);
	}
	
	public static void showName(String name, int age) {
		System.out.println("이름: " + name + ", 나이: " + age);
	}
	
	public static void showName(int age) {
		System.out.println("이름: 전우치" + ", 나이: " + age);
	}
}

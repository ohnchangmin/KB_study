
public class Method3 {

	public static void main(String[] args) {
		//타입 메쏘드이름()
		
		System.out.println("나이: " + getAge());
		System.out.println("이름: " + getName());
		System.out.println("나이: " + getAge(30));
		System.out.println("이름: " + getName("홍"));

	}

	
	public static int getAge() {
		int age = 200;
		return age;
	}
	
	public static String getName() {
		return "홍길동";
	}
	
	public static int getAge(int age) {
		return age + 100;
	}
	
	public static String getName(String lastName) {
		return lastName + "길동";
	}
	

}


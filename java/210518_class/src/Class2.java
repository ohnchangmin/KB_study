
public class Class2 {

	public static void main(String[] args) {
		// 인스터스 생성
		// car라는 변수가 만들어진 인스턴스의 주소를 알고있음
		// 그런데 private로 만들어져있어서 변수가 안보여
		// 그래서 접근할 수 있는 셋터와 겟터가 필요해

		Car car = new Car();
//		car.setModel("A6");
//		car.setBrand("Audi");
//		car.setColor("블랙");
//		car.setPrice(8000);
		
		car.showCarInfo();
		//System.out.println(car.toString());
		
		//차를 여러대 뽑았어 - 객체를 여러개 만들었어
		Car car2 = new Car();
		Car car3 = new Car();
		Car car4 = new Car("현대", "블랙", "EQ900", 8000);
		car4.showCarInfo();

	}

}

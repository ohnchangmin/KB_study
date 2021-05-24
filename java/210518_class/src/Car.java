//데이터 클래스 or 모델 클래스
public class Car {
	//상수변수 - 값이 더 이상 변경되지 않기 때문에 public을 사용하기도 함
	public static final String DEALERSHIP = "동대구 영업소";
	
	//추상화: 이 클래스에 정말 필요한 정보들을 캐치해서 뽑아내는 것
	private String brand;
	private String color;
	private String model;
	private int price;
	
	public String getBrand() {
		return brand;
	}

	public void setBrand(String brand) {
		this.brand = brand;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public int getPrice() {
		return price;
	}

	public void setPrice(int price) {
		this.price = price;
	}
	
	//오버로딩: 중복정의
	//오버라이딩: 재정의(부모꺼 대신 내꺼 쓸거야)
	//@어노테이션: 컴파일러에게 어떤 역할을 한다는 걸 알려줌
	@Override
	public String toString() {
		String str = "모델: " + model + "\n";
		str += "색상: " + color + "\n";
		str += "가격: " + price + "\n";
		str += "제조사: " + brand + "\n";
		str += "대리점: " + DEALERSHIP + "\n";
		return str;
	}

	public Car(){
		brand = "기아";
		color = "블랙";
		model = "K7";
		price = 4000;
	}
	
	
	//오버로딩
	public Car(String brand, String color, String model, int price) {
		super();
		this.brand = brand;
		this.color = color;
		this.model = model;
		this.price = price;
	}
	
	public void showCarInfo() {
		System.out.println("브랜드: 	" + brand);
		System.out.println("색상: 	" + color);
		System.out.println("모델: 	" + model);
		System.out.println("가격: 	" + price);
		System.out.println("대리점: 	" + DEALERSHIP);
		System.out.println();
	}


}

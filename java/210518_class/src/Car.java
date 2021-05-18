
public class Car {
	
	public static final String DEALERSHIP = "동대구 영업소";
	
	private String brand;
	private String color;
	private String model;
	private int price;
	
	public Car(){
		brand = "기아";
		color = "블랙";
		model = "K7";
		price = 4000;
		showInfo();
	}
	
	public Car(String brand, String color, String model, int price) {
		this.brand = brand;
		this.color = color;
		this.model = model;
		this.price = price;		
		showInfo();
	}
	
	public void showInfo() {
		System.out.println("브랜드: 	" + brand);
		System.out.println("색상: 	" + color);
		System.out.println("모델: 	" + model);
		System.out.println("가격: 	" + price);
		System.out.println("대리점: 	" + DEALERSHIP);	
	}


}

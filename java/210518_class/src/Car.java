
public class Car {
	
	public static final String DEALERSHIP = "���뱸 ������";
	
	private String brand;
	private String color;
	private String model;
	private int price;
	
	public Car(){
		brand = "���";
		color = "��";
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
		System.out.println("�귣��: 	" + brand);
		System.out.println("����: 	" + color);
		System.out.println("��: 	" + model);
		System.out.println("����: 	" + price);
		System.out.println("�븮��: 	" + DEALERSHIP);	
	}


}

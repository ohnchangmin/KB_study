//������ Ŭ���� or �� Ŭ����
public class Car {
	//������� - ���� �� �̻� ������� �ʱ� ������ public�� ����ϱ⵵ ��
	public static final String DEALERSHIP = "���뱸 ������";
	
	//�߻�ȭ: �� Ŭ������ ���� �ʿ��� �������� ĳġ�ؼ� �̾Ƴ��� ��
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
	
	//�����ε�: �ߺ�����
	//�������̵�: ������(�θ� ��� ���� ���ž�)
	//@������̼�: �����Ϸ����� � ������ �Ѵٴ� �� �˷���
	@Override
	public String toString() {
		String str = "��: " + model + "\n";
		str += "����: " + color + "\n";
		str += "����: " + price + "\n";
		str += "������: " + brand + "\n";
		str += "�븮��: " + DEALERSHIP + "\n";
		return str;
	}

	public Car(){
		brand = "���";
		color = "��";
		model = "K7";
		price = 4000;
	}
	
	
	//�����ε�
	public Car(String brand, String color, String model, int price) {
		super();
		this.brand = brand;
		this.color = color;
		this.model = model;
		this.price = price;
	}
	
	public void showCarInfo() {
		System.out.println("�귣��: 	" + brand);
		System.out.println("����: 	" + color);
		System.out.println("��: 	" + model);
		System.out.println("����: 	" + price);
		System.out.println("�븮��: 	" + DEALERSHIP);
		System.out.println();
	}


}

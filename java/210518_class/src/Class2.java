
public class Class2 {

	public static void main(String[] args) {
		// �ν��ͽ� ����
		// car��� ������ ������� �ν��Ͻ��� �ּҸ� �˰�����
		// �׷��� private�� ��������־ ������ �Ⱥ���
		// �׷��� ������ �� �ִ� ���Ϳ� ���Ͱ� �ʿ���

		Car car = new Car();
//		car.setModel("A6");
//		car.setBrand("Audi");
//		car.setColor("��");
//		car.setPrice(8000);
		
		car.showCarInfo();
		//System.out.println(car.toString());
		
		//���� ������ �̾Ҿ� - ��ü�� ������ �������
		Car car2 = new Car();
		Car car3 = new Car();
		Car car4 = new Car("����", "��", "EQ900", 8000);
		car4.showCarInfo();

	}

}

import java.util.Random;

public class Class1 {

	public static void main(String[] args) {
		// StudentScore�� �ᱹ Ÿ��
		
		String name[] = { "������", "��ȿ��", "�����", "�����", "���缮" };
		int score[] = { 20, 40, 60, 80, 100 };
		Random r = new Random();

		// Ŭ��������
		System.out.println("------------------------------");
		System.out.println("�б�: " + StudentScore.SCHOOL);
		System.out.println("------------------------------");
		
		// ��ü ������ �� �� = �����ڰ� ���
		//class Ÿ���� ������ �迭
		StudentScore arr[] = new StudentScore[5];

		for (int i = 0; i < arr.length; i++) {
			System.out.println("��ȣ: " + (i + 1));
			arr[i] = new StudentScore(
					name[r.nextInt(5)], 
					score[r.nextInt(5)], 
					score[r.nextInt(5)],
					score[r.nextInt(5)]);
		}
	}
}
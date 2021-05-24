//������ �������� �� �ʿ䰡 ����
//�ܺο� Ŭ������ ����� ��� public����� ��
public class StudentScore {
	//����������:
	//public:	�ܺ� ��𼭵� ����
	//private:	Ŭ���� ���ο����� ����
	//protected:��ӹ��� Ŭ���������� ����
	//default:	���� ��Ű�� ���ο��� ����
	private String name;
	private int kor;
	private int math;
	private int eng;
	private int sum;
	private int avg;
	private char grade;
    
	//�������(final) : ���α׷��� ����� ������ ������ ����-���� �����̸��� �빮�ڷ� ��
	static public final String SCHOOL = "�ѱ����б�";
	
	//�⺻ ������: ������ �ʾƵ� �����Ϸ��� �˾Ƽ� �������(�Ű������� ���� ������)
	//�ϳ� �̻� ����ϸ� �����Ϸ��� ����� �����ڸ� �����
	//������? �ν��Ͻ� �������� �������� �ʱ�ȭ �ϴ� ����
	public StudentScore() {
		name= "��Ż�";
		kor = 100;
		eng = 100;
		math = 100;
		makeSum();
		makeAvg();
		makeGrade();
	}
	
	//������ �����ε�(�ߺ�����)
	public StudentScore(String name, int kor, int math, int eng) {
		super();
		this.name = name;
		this.kor = kor;
		this.math = math;
		this.eng = eng;
		
		makeSum();
		makeAvg();
		makeGrade();
		showInfo();
	}

	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getKor() {
		return kor;
	}
	public void setKor(int kor) {
		this.kor = kor;
	}
	public int getMath() {
		return math;
	}
	public void setMath(int math) {
		this.math = math;
	}
	public int getEng() {
		return eng;
	}
	public void setEng(int eng) {
		this.eng = eng;
	}
	public int getSum() {
		return sum;
	}
	public void setSum(int sum) {
		this.sum = sum;
	}
	public int getAvg() {
		return avg;
	}
	public void setAvg(int avg) {
		this.avg = avg;
	}
	public char getGrade() {
		return grade;
	}
	public void setGrade(char grade) {
		this.grade = grade;
	}
	
	public void showInfo() {		
		System.out.println("�̸�: " + name);
		System.out.println("����: " + kor);
		System.out.println("����: " + eng);
		System.out.println("����: " + math);
		System.out.println("����: " + sum);
		System.out.println("���: " + avg);
		System.out.println("����: " + grade);
		System.out.println("---------------------------");
	}
	
	
	public void makeSum() {
		sum = kor + eng + math;
	}
	
	public void makeAvg() {
		avg = sum/3;
	}
	
	public void makeGrade() {
		if (avg >= 90 && avg <= 100) {
			grade = 'A';
		}
		
		else if(avg >=80 && avg <=89) {
			grade = 'B';
		}
		
		else if(avg >=70 && avg <=79) {
			grade = 'C';
		}
			
		else if(avg >= 60 && avg <=69) {
			grade = 'D';
		}
		
		else if(avg >=50 && avg <=59) {
			grade = 'E';
		}
		
		else {
			grade = 'F';
		}
		
		
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	//ĸ��ȭ: �ƹ������� ������ �� ���� ���� ���ϰ� �ϰ� �żҵ�� �����ϰ� �ؾ���
	
	//���������� ������ �����Ѵ��ؼ�
	//����
//	public void setName(String name) {
//		//this = ��ü�� ���� ��ġ (�ڵ����� ����)
//		this.name = name;				
//	}
//	
//	public void setKor(int kor) {
//		this.kor = kor;
//	}
//	
//	//����
//	public String getName() {
//		//this�� ���� ���� �̸��� �ν��Ͻ� ����, �Ű������� �浹���������� ������ �ʾƵ� �����Ϸ��� �ڵ����� �ν�
//		return name;
//	}
//	
//	public int getKor() {
//		return kor;
//	}
}

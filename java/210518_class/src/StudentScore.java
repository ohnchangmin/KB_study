//설계의 관점으로 볼 필요가 있음
//외부에 클래스를 만드는 경우 public써줘야 함
public class StudentScore {
	//접근지정자:
	//public:	외부 어디서든 접근
	//private:	클래스 내부에서만 접근
	//protected:상속받은 클래스에서만 접근
	//default:	같은 패키지 내부에서 접근
	private String name;
	private int kor;
	private int math;
	private int eng;
	private int sum;
	private int avg;
	private char grade;
    
	//상수변수(final) : 프로그램이 종료될 때까지 변하지 않음-보통 변수이름은 대문자로 함
	static public final String SCHOOL = "한국중학교";
	
	//기본 생성자: 만들지 않아도 컴파일러가 알아서 만들어줌(매개변수가 없는 생성자)
	//하나 이상 명시하면 컴파일러가 명시한 생성자를 사용함
	//역할은? 인스턴스 변수들의 정보들을 초기화 하는 역할
	public StudentScore() {
		name= "김신사";
		kor = 100;
		eng = 100;
		math = 100;
		makeSum();
		makeAvg();
		makeGrade();
	}
	
	//생성자 오버로딩(중복정의)
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
		System.out.println("이름: " + name);
		System.out.println("국어: " + kor);
		System.out.println("영어: " + eng);
		System.out.println("수학: " + math);
		System.out.println("총점: " + sum);
		System.out.println("평균: " + avg);
		System.out.println("학점: " + grade);
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
	
	
	
	
	
	
	
	
	
	
	
	
	
	//캡슐화: 아무때서나 변수를 막 갖다 쓰지 못하게 하고 매소드로 접근하게 해야함
	
	//직관적으로 정보를 셋팅한다해서
	//셋터
//	public void setName(String name) {
//		//this = 객체의 시작 위치 (자동으로 관리)
//		this.name = name;				
//	}
//	
//	public void setKor(int kor) {
//		this.kor = kor;
//	}
//	
//	//겟터
//	public String getName() {
//		//this가 붙은 변수 이름을 인스턴스 변수, 매개변수랑 충돌하지않으면 붙이지 않아도 컴파일러가 자동으로 인식
//		return name;
//	}
//	
//	public int getKor() {
//		return kor;
//	}
}

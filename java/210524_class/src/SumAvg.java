
public class SumAvg {
	int sum;
	int avg;
	int[] arr;
	
	public SumAvg(int[] arr) {
		this.arr = arr;	
		for(int i : arr) {
			sum += i;
		}
		avg = sum / arr.length;
		
		System.out.println("��:" + sum);
		System.out.println("���:" + avg);
	}
	
	public int getSum() {
		return sum;
	}
	
	public int getAvg() {
		return avg;
	}
}

using System;

class Int{
	public static void divide(int a, int b){
		int diff = 0;
		try{
			diff = a / b;
		}
		catch (System.Exception){
			Console.WriteLine("Cannot divide by zero");
		}
		finally{
			Console.WriteLine("{0} / {1} = {2}", a, b, diff);
		}
	}
}

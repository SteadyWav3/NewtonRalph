// C# program for implementation of  

// Newton Raphson Method for solving  

// equations

using System; 

namespace newtonRaphson {
	public class newtonRaphsonCalc { 
	
	      
	
	    const double EPSILON = 0.001;
	    static double x0;
	    static double a;
		static double b;
	
	      
		static double find_x0()
		{
			return  (a+b)/2;
		}
	
	    // The function is x^3 - x^2 + 2 
	
	    static double func(double x) 
	
	    { 
	
	        return x * x - 61; 
	
	    } 
	
	      
	
	    // Derivative of the above function  
	
	    // which is x*x - 61
	
	    static double derivFunc(double x) 
	
	    { 
	
	        return 2 * x; 
	
	    } 
	
	      
	
	    // Function to find the root 
	
	    static void newtonRaphson(double x) 
	
	    { 
	    	
	    	  
	        double[] counter = new double[8];
	        
			// h = f(x) / f'(x)
		
	        double h = func(x) / derivFunc(x); 
	
	        while (Math.Abs(h) >= EPSILON) 
	
	        { 
	
	            h = func(x) / derivFunc(x); 
	
	      
	
	            // x(i+1) = x(i) - f(x) / f'(x)  
	            x = x - h; 
	            
	            for(int i = 0; i<1; i++){
	            	
	            	Console.WriteLine("X" + counter[i] + " = " + x);
	            	counter[i]++;
	            	
	            }
	
	        } 
	
	      
			// Output value of root after iteration
	        Console.WriteLine("The value of the" + " root is : " + x);
	        // Rounded up to 2 decimal place 
	        Console.WriteLine("The value of the" + " root rounded: " + Math.Round(x * 100.0) / 100.0);
	
	    } 
	
	      
	
	    // Driver code 
	
	    public static void Main () 
	
	    { 
	    	// Program welcome page
	    	Console.WriteLine(":::This Program will find root of (x²-61) using Newton-Ralpson method:::");
	    	Console.WriteLine("Input Your a and b value to get our starting point");
	    	Console.WriteLine("a: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("b: ");
			b = Convert.ToDouble(Console.ReadLine());
			x0 = newtonRaphsonCalc.find_x0();
			Console.WriteLine("Our Starting Point is: {0}", x0);
				
	        newtonRaphson(x0); 
	        Console.ReadKey();
	
	    } 
	
	} 
}
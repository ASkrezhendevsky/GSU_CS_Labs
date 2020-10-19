using System;
namespace lab2{
    public class Program{
        static void Main(string[] args){
            A myA = new A();
			B myB = new B();
			B otherB = new B(7);	
            Console.WriteLine("myA.c = "+myA.c); //c = a - b
			Console.WriteLine("myB.c = "+myB.c); //c = a - b
			Console.WriteLine("myB.c2 = "+myB.c2); //c = a - b + d + k, d = 0, k =0
			Console.WriteLine("otherB.c = "+otherB.c); //c = a - b
			Console.WriteLine("otherB.c2 = "+otherB.c2); //c = a - b + d + k, d = 7, k = 2 
        }
    }   

    class A{
        private float a = 2, b = 3;
        private bool state = false; 
        
        public A(){
			a = 2;
			b = 3;
			state = false;
        } 

        public bool State{
            set{
                state = value;
            }
        }
        public float c {
            get{
                if(state){
                    return a / b;
                }
                else
                {
                    return a - b;
                }
            }
        }
    }
    class B: A{
        private float d;

		public B():base(){}

		public B(float d){
			this.d = d;
		}

        public float c2 {
            get{
				if(d > 2){
					return base.c + d;				
				}
				else
				{
					return base.c - d;
				}
            }
        }
    }
}

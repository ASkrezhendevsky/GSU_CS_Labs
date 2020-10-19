using System;

namespace lab2{
    public class Program{
        static void Main(string[] args){
            A myA = new A();
			B myB = new B();
			B otherB = new B(7.7f);	
            Console.WriteLine("myA.С = "+myA.С);
			Console.WriteLine("myB.С = "+myB.С);
			Console.WriteLine("myB.C2 = "+myB.C2);
			Console.WriteLine("otherB.С = "+myB.С);
			Console.WriteLine("otherB.C2 = "+myB.C2);
        }
    }   

    class A{
        private float a = 2, b = 3;
        private bool state = false; 
        
        public A(){
			a = 0;
			b = 0;
			state = false;
        } 

        public bool State{
            set{
                state = value;
            }
        }
        public float С {
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
        float d;
		public B():base(){}
		public B(float d){
			this.d = d;
		}
        public float С2 {
            get{
				int k = 0;
				if(d > 2){
					k = 5;				
				}
            	return base.C + d + k;
            }
        }
    }
}

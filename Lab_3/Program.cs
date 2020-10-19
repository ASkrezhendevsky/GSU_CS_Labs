using System;
namespace lab3{
    public class Program{
        static void Main(string[] args){
			B myB = new B();	
            foreach(float element in myB.ar){
                Console.WriteLine(element);
            }
        }
    }   

    class A{
        public float a = 2, b = 3;
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
		public float[] ar;

		public B(float d){
			this.d = d;
		}

		public B():base(){
			ar = new float[(int)a];	
			for(int i = 0; i < ar.Length; i++){
				ar[i] = c2*i;			
			}
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

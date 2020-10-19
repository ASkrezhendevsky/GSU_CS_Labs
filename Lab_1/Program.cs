using System;

namespace lab1{

    class Program{
        static void Main(string[] args){
            A myA = new A();
            Console.WriteLine(myA.c);
        }
    }   

    class A{
        private float a = 2, b = 3;
        private bool state = false; 

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
}

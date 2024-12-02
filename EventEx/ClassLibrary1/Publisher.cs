using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public delegate void MyDelegateType(int a,int b);
    public class Publisher
    {

        //private delegate // we use property of this delegate in event 
        private MyDelegateType myDelegate;
         
        // step1 :  creating event :
        public event MyDelegateType myEvent
        {
            add  //whenever some class subscribe to myEvent then corresponding method is stored into myDelegate using add like set and get 
            {
                this.myDelegate += value;
            }
            remove{//whenever some class unsubscribes event then method reference is removed by using remove ;


                myDelegate -= value;
            }
        }
       // or you can also crate auto implemeneted events
        public event MyDelegateType autoEvent;
        
        //step to : raise event 
        public void RaiseEvent(int a,int b)
        {
            if(myDelegate!=null)
                myDelegate(a, b); //if somebody is subscribed then only it will execute otherwise it is null
            
            //calling auto implemenated event 
            this.autoEvent(a, b);

            
        }
    }
}

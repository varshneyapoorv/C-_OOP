using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Customer {
        public int Id;
        public string Name;
        public List<Order>Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

//hum this keyword ka use control flow ko pass karne ke liye karte hai

        public Customer(int id)
        // this yha par use hota hai jab hume ek constructor me dusra constructor call karna ho
         :  this()
        {   
            this.Id = id;
            
        }


        public Customer(int id, string name) 
        // yha pr this ye bta raha hai ki phle wala constructor call karo jisme ek parameter hai int wala fir uske bad ye constructor call karo
        : this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}

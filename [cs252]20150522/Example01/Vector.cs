using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01

{
    internal class Student: IComparable
    {
        public int 國文 {get;set;}
        public int 英文 {get;set;}
        public static int Order { get; set; }

        public int 總分{

            get {
                return this.國文 + this.英文;           
            
            }
        }
        public Student(int 國文,int 英文)
        {
             this.國文 = 國文;
             this.英文 = 英文;
        
        }

        public int CompareTo(object obj) 
        {
            Student  B = obj as Student;
            if (this.國文 > B.國文)
                return 1*Order;
            else if (this.國文 == B.國文)
                return 0;            
        　　else　return -1*Order;
        }
        public override string ToString() 
        {
            string s = string.Format("國文={0},英文={1},總分{2}",this.國文,this.英文,this.總分);
            return s;
        
        }

        
        
    }
}

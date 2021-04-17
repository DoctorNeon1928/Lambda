using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            //5,6,7,8,9

            

            VectorList<User> Users = new VectorList<User>(5);
            Users.elements[0] = new User { Id = 1, Name = "John", Phone = "1234567", Age = 20 };
            Users.elements[1] = new User { Id = 2, Name = "Jane", Phone = "4365745674", Age = 40 };
            Users.elements[2] = new User { Id = 3, Name = "Max", Phone = "34563546", Age = 60 };
            Users.elements[3] = new User { Id = 4, Name = "Eva", Phone = "96798", Age = 80 };
            Users.elements[4] = new User { Id = 5, Name = "Mickel", Phone = "3245", Age = 100 };

            var temp = Users.Select(x=>x.Age>30 && x.Age<100).Select(x=>
            {
                string newname = x.Name = " " + x.Age;

                return new { Name = newname, Age = x.Age };
            }).Select(x => x.Name);
            
            double maxage = Users.max(x => x.Age)


        }





    }


    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }

    public class VectorList<T>
    {
        public T[] elements;

        public VectorList(int count)
        {
            elements = new T[count];
        }

        public VectorList<TResult> Select(Func<T, TResult> f)
        {
            VectorList<TResult> outlist = new VectorList<TResult>(elements.Length);

            for(int i=0;i<elements.Length;i++)
            {
                outlist.elements[i] = f(elements[i]);
            }

            return outlist;

        }

        public VectorList<T> Where(Func<T,bool> filter)
        {
            int[] appr = new int[elements.Length];

            int counter = 0;

            for(int i=0;i<elements.Length; i++)
            {
                if(filter(elements[i]))
                {
                    appr[counter] = i;
                    counter++;
                }
            }

            VectorList<T> t = new VectorList<T>(counter);

            for (int i = 0; i < counter; i++)
            {
                res.elements[i] = elements[appr[i]];
            }

            return null;
        }

        public double Max TResult Max<TResult>(Func<T,TResult> F)
        {
            //TResult t = default(TResult);

            double t = double.Parse(F(elements[0]).ToString());

            for (int i = 0; i < elements.Length; i++)
            {
                double.Parse(t.ToString()) > double.Parse(F(elements[0]).ToString())

                if (t < temp)
                {
                    t = temp;
                }
            }

            return t;

            



        }
        
               
        }
    }
}
namespace Example
{
    /* Jerarquia de clases
     *           A
     *          / \
     *         B   C
     *         |
     *         D
     *         |
     *         E <- new
     *         |
     *         F
     *         |
     *         G
     */

    public class A
    {
        public virtual void test() {
            Console.WriteLine("Invocando metodo test desde la clase A");
        }
    }

    public class B : A {
        public override void test() { 
            Console.WriteLine("Invocando metodo test desde la clase B");
        }
    }

    public class C : A { }

    public class D : B {
        public override void test() {
            Console.WriteLine("Invocando metodo test desde la clase D");
        }
    }

    public class E : D {
        public new void test() {
            Console.WriteLine("Invocando metodo test desde la clase E");
        }
    }

    public class F : E {
        //public override void test()
        //{
        //    Console.WriteLine("Invocando metodo test desde la clase D");
        //}
        public new virtual void test()
        {
            Console.WriteLine("Invocando metodo test desde la clase F");
        }
    }

    public class G : F {
        public override void test()
        {
            Console.WriteLine("Invocando metodo test desde la clase G");
        }
    }
}
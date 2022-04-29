using Example;

Console.WriteLine("\nPrueba: Invocando el metodo test por cada tipo");
new A().test();
new B().test();
new C().test();
new D().test();
new E().test();
new F().test();
new G().test();

Console.WriteLine("\nPrueba: un array de tipo A[], con una instancia de cada tipo");
A[] arreglo = new A[] { new A(), new B(), new C(), new D(), new E(), new F(), new G()};
foreach (var x in arreglo) {
    x.test();
}

Console.WriteLine("\nPrueba: Invocando el metodo test por cada tipo casteando todo a tipo A");
((A)new A()).test();
((A)new B()).test();
((A)new C()).test();
((A)new D()).test();
((A)new E()).test();
((A)new F()).test();
((A)new G()).test();

Console.WriteLine("\nPrueba: un array de tipo A[], con una instancia de cada tipo a partir de E");
A[] arreglo2 = new E[] { new E(), new F(), new G() };
foreach (var x in arreglo2){
    x.test();
}

Console.WriteLine("\nPrueba: un array de tipo E[], con una instancia de cada tipo a partir de E");
E[] arreglo3 = new E[] { new E(), new F(), new G() };
foreach (var x in arreglo3)
{
    x.test();
}

Console.WriteLine("\nPrueba: Miscelanea 1");
A var1 = new D();
var1.test();
((B)var1).test();

Console.WriteLine("\nPrueba: Miscelanea 2");
A var2 = new F();
var2.test();
((F)var2).test();

Console.WriteLine("\nPrueba: Miscelanea 3");
A var3 = new G();
var3.test();
((F)var3).test();


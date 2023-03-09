// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programa 1");

int mes = 0;
int s = 5;

for (int i = 0; i < 20; i++)
{
    s = s + s;
    mes++;
    Console.WriteLine("En el mes numero "+mes+" debe pagar: "+s);

}
Console.WriteLine("Proyecto 2");
int h = 0;
int d = 0;
char respuesta;
int t = 0;
int z = 0;
int f = 0;
int v = 0;
int n= 0;
do
{
    Console.WriteLine("Ingrese las horas trabajadas");
    h = Convert.ToInt32(Console.ReadLine());

    f = h + f;

    Console.WriteLine("Ingrese los dias trabajados");
    d = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Desea seguir ingresando valores? s=si / n=no");
    respuesta = Convert.ToChar(Console.ReadLine());
    v = t + v;
    n++;
} while (respuesta == 's');
Console.WriteLine("Ingrese el sueldo por hora");
z = Convert.ToInt32(Console.ReadLine());

t = h * z;
v = f * z;

Console.WriteLine("El sueldo semanal de "+n+" empleados es "+t);
Console.WriteLine("La empresa pago un total de " + v + " por " + n+ " empleados");

Console.WriteLine("Proyecto 3");
char resp;
int val = 0;
int cant = 0;
int x = 0;
int y = 0;
double c = 0;
do
{
    Console.WriteLine("Ingrese el valor del billete");
    val = Convert.ToInt32(Console.ReadLine());
  
    if (val == 5 || val == 20 ||val==1 || val==100 || val == 50 ||val==200)
    {
        x = val + x;
        Console.WriteLine("Ingrese la cantidad del billete");
        cant = Convert.ToInt32(Console.ReadLine());

        y = cant + y;

        Console.WriteLine("Ingrese la cantidad total de centavos");
        c = Convert.ToDouble(Console.ReadLine());
        
    }
    else
    {
        Console.WriteLine("No existen billetes de ese valor");
        
    }
    Console.WriteLine("Desea seguir ingresando valores? s=si / n=no");
    resp = Convert.ToChar(Console.ReadLine());

} while (resp == 's');

double total = 0;
total = x * y + c;
Console.WriteLine("El total de la caja registradora es "+total);


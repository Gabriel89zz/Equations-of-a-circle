using Equations_of_a_circle;

Circle c1 = new Circle();
c1.Radio = 2;
c1.H = 3;
c1.K = 4;


c1.DisplayCircleInfo(c1);
Console.WriteLine(c1.GetEquationOfTheCircle(c1.Radio, c1.H, c1.K));
c1.ShowEquationGral();
Console.WriteLine(c1.GetEquationOfTheCircle(c1)+"\n");

Circle c2 = new Circle();
c2.Radio = 8;
c2.DisplayCircleInfo(c2);
Console.WriteLine(c2.GetEquationOfTheCircle()+ "\n");
Circle.GoOut();
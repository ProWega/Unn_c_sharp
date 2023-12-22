using Lab4_abstract;

TriangleColor triangle = new TriangleColor("Несуществующий треугольник",1,2,3,ColorValues.red);
triangle.Print();
triangle.C = -7;
triangle.Print();

triangle.SetABC(-7, -5, -3);
triangle.Print();
using _06Polymorphism;

//Upcasting, referans değişkenin tipi parent class olabilir
//Parent tipte bir referans subtipte bir nesneyi gösterir
//ParentClassların sahip olduğu metot ve değişkenlere subclasslar da sahip olduğu için güvenlidir

BaseGeometricShape square = new Square(7);
square.CalculateArea();

Console.WriteLine("\r\n*******************\r\n");

BaseGeometricShape rectangle = new Rectangle(4,10);
rectangle.CalculateArea();

Console.WriteLine("\r\n*******************\r\n");

BaseGeometricShape RightTriangle = new RightTriangle(2,3);
RightTriangle.CalculateArea();
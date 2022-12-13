namespace pro100user;

public class Triangle
{
 private int a;
 private int b;
 private int c;
 private int color;

 public Triangle(int a, int b, int c, int color)
 { 
  this.a = a;
  this.b = b;
  this.c = c;
  this.color = color;
 }

 public int this[int i]
 {
  get
  {
   switch (i)
   {
    case 0: return a;
    case 1: return b;
    case 2: return c;
    case 3: return color;
    default: throw new Exception("Неприпустиме значення індексу");
   }
  }
 }

 public static Triangle operator +(Triangle triangle) =>
  new Triangle(++triangle.a, ++triangle.b, ++triangle.c, triangle.color);

 public static Triangle operator -(Triangle triangle) =>
  new Triangle(--triangle.a, --triangle.b, --triangle.c, triangle.color);


 public static bool operator true(Triangle triangle)
 {
  return true;
 }

 public static bool operator false(Triangle triangle)
 {
  return false;
 }

 public static Triangle operator *(Triangle first, int scalar) =>
  new Triangle(first.a * scalar, first.b * scalar, first.c * scalar, first.color);
}
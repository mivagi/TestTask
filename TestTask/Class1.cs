using System;

namespace TestTask
{
    //Я сделал методы возвращающие void,
    //но можно было использовать out что бы получать false если треугольник не прямоугольный
    //и true если треугольник прямоугольный, но из-за этого пришлось бы передовать дополнительный
    //аргумент в методы где он не нужен, либо названия методов были бы разные.
    //Еще можно было бы сделать отдельный класс с полями double, куда бы записывались результаты
    //вычисления площади, и bool, для записи того является ли треугольник прямоугольным.
    //Могли бы вы уточнить задание.
    public class Figure
    {
        private const double PI = 3.14f;
        private double area;
        //Метод для вычисления площади круга.
        public void FigureArea(double r)
        {
            area = PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга равна {area}");
        }
        //Метод для вычисления площади треугольника.
        public void FigureArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника равна {area}");
            var max = a;
            if (b > a)
                max = b;
            if (c > max)
                max = c;
            if (max == a)
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник не прямоугольный");
            }
            else if (max == b)
            {
                if (Math.Sqrt(b) == Math.Sqrt(a) + Math.Sqrt(c))
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник не прямоугольный");
            }
            else if (max == c)
            {
                if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник не прямоугольный");
            }
        }
    }
}
/*Вопрос №3:
 * Есть таблицы Category(с полями id и name) и Product(с полями id и name)
 * Для связи многие ко многим надо создать дополнительную 
 * таблицу CategoriesAndProducts с полями categoryId и productId
 * И тогда запрос будет выглядеть так:
 * SELECT Product.name, Category.name FROM Product
 * JOIN CategoriesAndProducts
 * ON Product.id = CategoriesAndProducts.productId
 * LEFT JOIN Category
 * ON Category.id = CategoriesAndProducts.categoryId;
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1.	Разработать один из классов на ваше усмотрение (примеры описаны ниже).
                2.	Реализовать не менее пяти закрытых полей (различных типов), представляющих основные характеристики рассматриваемого класса.
                3.	Создать не менее одного методов управления классом и методы доступа к его закрытым полям. 
                4.	Создать метод, в который передаются аргументы по ссылке. 
                5.	Создать не менее двух статических полей (различных типов), представляющих общие характеристики объектов данного класса. 
                6.	Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы которых определяются студентом, 
                исходя из специфики реализуемого класса, а также реализация конструктора по умолчанию.
                7.	Создать статический конструктор.
                8.	Создать массив (не менее 5 элементов) объектов созданного класса.
                9.	Создать дополнительный метод для данного класса в другом файла, используя ключевое слово partial. 
Варианты (по выбору):
1. Автомобиль;
2. Мотоцикл;
3. Самолет;
4. Бытовая техника (на выбор);
5. Продукты питания (на выбор);
6. Канцелярские товары (на выбор);
7. Мебель (на выбор);
9. Поезд;

*/
            Random rnd = new Random();
            Car car1 = new Car();
         
            car1.HorsePower = rnd.Next(50, 600);
            car1.Weight = rnd.Next(850, 2400);
            car1.Mark = "Mercedes";
            car1.Cost = rnd.Next(200000, 20000000);
            Car car2 = new Car();
            car2.HorsePower = rnd.Next(50, 600);
            car2.Weight = rnd.Next(850, 2400);
            car2.Mark = "Audi";
            car2.Cost = rnd.Next(200000, 20000000);
            Car car3 = new Car();
            car3.HorsePower = rnd.Next(50, 600);
            car3.Weight = rnd.Next(850, 2400);
            car3.Mark = "Toyota";
            car3.Cost = rnd.Next(200000, 20000000);

            Car car4 = new Car();
            car4.HorsePower = rnd.Next(50, 600);
            car4.Weight = rnd.Next(850, 2400);
            car4.Mark = "BMW";
            car4.Cost = rnd.Next(200000, 20000000);
            Car car5 = new Car();
            car5.HorsePower = rnd.Next(50, 600);
            car5.Weight = rnd.Next(850, 2400);
            car5.Mark = "Chevrolet";
            car5.Cost = rnd.Next(200000, 20000000);
            Car[] Garage = new Car[]{car1, car2, car3, car4, car5};
            for(int i = 0; i < Garage.Length; i++)
            {
                Console.WriteLine("Car index " + i++);
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine(Garage[j]);
                }
            }





        }
    }
    public class Car
    {
        public int HorsePower { get; set; }
        public int Weight { get; set; }
        public string Mark { get; set; }
        public int Cost { get; set; }
        public Car(int HorsePower, int Weight, int Cost, string Mark)
        {
            this.HorsePower = HorsePower;
            this.Weight = Weight;
            this.Cost = Cost;
            this.Mark = Mark;
        }
        public Car()
        {

        }
        public override string ToString()
        {
            return string.Format("Power: {0}  \n Weight:{1} \n Mark:{2} \n Cost:{3} \n", HorsePower, Weight, Mark, Cost);
        }
    }
    


}

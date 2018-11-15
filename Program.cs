using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{   class ThisFlower : Control
    { 
        public Color colors;

        public string Name { get; set; }
        public ThisFlower(string name, int price, Color colors) : base(price)
        {
            Name = name;
            Price = price;
            this.colors = colors;
        }
       
        public void Display()
        {
            Console.WriteLine(Name + "  " + Price + "$");
        }
    }
    class Conteiner
    {
        public List<ThisFlower> LThisFlower { get; set; }
        public static int count = 0;
        public Conteiner(ThisFlower flo, ThisFlower flo2)
        {
            LThisFlower = new List<ThisFlower>() { flo, flo2 };
        }
        public void AddD(ThisFlower flo)
        {
            LThisFlower.Add(flo);
        }
        public void Dell(int n)
        {
            LThisFlower.RemoveAt(n);
        }
        public void GetInfo()
        {
            foreach (ThisFlower i in LThisFlower)
            {
                Console.WriteLine(i.Name +" " +  i.Price + " " + i.colors);
            }
            Console.WriteLine();
        }
    }
     class Control
    {
        public int Price { get; set; } // цена цветка
       
       
        public Control(int price)
        {
           Price = price;
        }     
        
    }
    struct MyFlowers //Как и классы, структуры могут хранить состояние в виде переменных и определять поведение в виде методов
    {
        public int yearFlower;
        public string name;
        //Важно учитывать, что если мы определяем конструктор в структуре, то он должен инициализировать все поля структуры
        public MyFlowers(string name, int yearFlower)
        {
            this.name = name;
            this.yearFlower = yearFlower;
        }
        public void GetInfo()
        {
            Console.WriteLine(name + " завянет через " + yearFlower + " дней");
        }
    }
    enum Color {Синий, Розовый, Белый, Желтый, Фиолетовый }
    enum Flow {Роза, Тюльпан, Орхидея, Ромашки, Гладиолус, Фикус, Фиалка, Лилия }
    class Flower
    {
        public Color color;
        public Flow flo;
        public Flower(Flow flo, Color color)
        {
            this.flo = flo;
            this.color = color;
        }
      public void Print()
        {
            Console.WriteLine("Цветок: " + flo + "  Цвет: " + color);
        }
    }

    public interface ISomeInterface
    {
        void Print();
        void Die();
    }
    public interface ISomeInterface2
    {
        void PrintGrow();
        void Die();
    }
    class Plant : ISomeInterface
    {

        public int GrowYears;
        public Plant(int day)
        {
            GrowYears = day;
        }
        public void Print()
        {
            Console.WriteLine("Растение вырастет через " + GrowYears + " дней");
        }
        void ISomeInterface.Die() { Console.Write("Статус цветка - Жив. "); }
        public override string ToString()
        {
            return "Plant:" + GrowYears + " " + base.ToString(); //переопределение метода ToString(), 

        }

    }
  
    class Kust : ISomeInterface, ISomeInterface2
    {
        public float dlina;
        public int GrowYears;
        public Kust(int day, float d)
        {
            GrowYears = day;
            dlina = d;
        }
        public void Print()
        {
            Console.WriteLine("Растение вырастет через " + GrowYears + " дней");
        }
        public void PrintGrow()
        {
            Console.WriteLine("Длина растения: " + dlina);
        }
        void ISomeInterface2.Die()
        { Console.WriteLine("Растение погибло"); }
        void ISomeInterface.Die()
        { Console.WriteLine("Растение живо"); }

        public override string ToString()
        {
            return "Kust:" + GrowYears + " " + dlina + " " + base.ToString(); //переопределение метода ToString(), 

        }
    }
    //Абстрактный класс похож на обычный класс, но мы не можем использовать конструктор абстрактного класса для создания его объекта
    abstract class Byket
    {
        public string Name { get; set; }
        public Byket(string name)
        {
            Name = name;
        }
        public void Draw()
        {
            Console.Write("Букет " + Name);
        }
        //Те методы и свойства, которые мы хотим сделать доступными для переопределения, в базовом классе помечается модификатором virtual.
        //Такие методы и свойства называют виртуальными
        public virtual void Numm() { }
    }

    class Rose : Byket
    {
        public int Kol { get; set; } // количество цветов в букете
        public Rose(string name, int Koll) : base(name)
        {
            Kol = Koll;
        }
        // А чтобы переопределить метод в классе-наследнике, этот метод определяется с модификатором override.
        public override void Numm()
        {
            Console.Write(" содержит " + Kol + " цветов");
        }
        public override string ToString()
        {
            return "Rose:" + base.Name + " " + Kol + " " + base.ToString(); //переопределение метода ToString(), 

        }
    }

    class Gladiolus : Byket
    {
        public int Kol { get; set; } // количество цветов в букете
        public Gladiolus(string name, int Koll) : base(name)
        {
            Kol = Koll;
        }
        public override void Numm()
        {
            Console.Write(" содержит " + Kol + " цветов");
        }
        public override string ToString()
        {
            return "Gladiolus:" + base.Name + " " + Kol + " " + base.ToString(); //переопределение метода ToString(), 

        }

    }
    sealed class Paper : Cactus // Запечатанный класс. Класс, от которого запрещается наследовать.
    { }
   partial class Cactus
    { }
    class myByket
    { }
    class Container
    {
        public List<myByket> myBykets { get; set; }
        public Container()
        {
            myBykets = new List<myByket>() { };

        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            /* Flower flower1 = new Flower(Flow.Роза, Color.Синий);
             flower1.Print();

             MyFlowers flower = new MyFlowers("Тюльпан", 18);
             flower.GetInfo();*/

            ThisFlower Rose = new ThisFlower("Роза", 3, Color.Синий);
            ThisFlower Liliya = new ThisFlower("Лилия", 2, Color.Розовый);
            ThisFlower Orhideya = new ThisFlower("Орхидея", 5, Color.Фиолетовый);

            int summa = Rose.Price + Liliya.Price + Orhideya.Price;
            Console.WriteLine("Цена букета: " + summa+ "$");

            if (Rose.colors == Color.Синий || Liliya.colors == Color.Синий || Orhideya.colors == Color.Синий)
            {
                Console.WriteLine("В букуте есть цветы синего цвета");
            }
            else { Console.WriteLine("В букете нет цветов синего цвета"); }
            if (Rose.colors == Color.Розовый || Liliya.colors == Color.Розовый || Orhideya.colors == Color.Розовый)
            {
                Console.WriteLine("В букете есть цветы розового цвета");
            }
            else { Console.WriteLine("В букете нет цветов розового цвета"); }
            if (Rose.colors == Color.Белый || Liliya.colors == Color.Белый || Orhideya.colors == Color.Белый)
            {
                Console.WriteLine("В букуте есть цветы белого цвета");
            }
            else { Console.WriteLine("В букете нет цветов белого цвета"); }
            if (Rose.colors == Color.Желтый || Liliya.colors == Color.Желтый || Orhideya.colors == Color.Желтый)
            {
                Console.WriteLine("В букуте есть цветы желтого цвета");
            }
            else { Console.WriteLine("В букете нет цветов желтого цвета"); }
            if (Rose.colors == Color.Фиолетовый || Liliya.colors == Color.Фиолетовый || Orhideya.colors == Color.Фиолетовый)
            {
                Console.WriteLine("В букуте есть цветы фиолетового цвета");
            }
            else { Console.WriteLine("В букете нет цветов фиолетового цвета"); }

            Console.WriteLine("Введите цвет (Синий - 0, Розовый - 1, Белый - 2 , Желтый - 3 , Фиолетовый - 4 )");
            int findd = Convert.ToInt32(Console.ReadLine());
            if (findd == 0)
            { Rose.Display(); }
            if (findd == 1)
            { Liliya.Display(); }
            if (findd == 2)
            { Console.WriteLine("Цветка с белым цветом нет"); }
            if (findd == 3)
            { Console.WriteLine("Цветка с желтым цветом нет"); }
            if (findd == 4)
            { Orhideya.Display();}


            Conteiner flo = new Conteiner(Rose, Liliya);
            Console.WriteLine("Начальное содержимое букета: ");
            flo.GetInfo();
            flo.AddD(Orhideya);
            Console.WriteLine("Букет после добавления цветка: ");
            flo.GetInfo();
            Console.WriteLine("Введите цветок, который желаете удалить (номер под которым записан цветок - от 0 до 2)");
            int t = Convert.ToInt32(Console.ReadLine());
            flo.Dell(t);
            Console.WriteLine("Конечный букет: ");
            flo.GetInfo();
        }
    }
}


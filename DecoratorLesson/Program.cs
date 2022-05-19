Beverage myCoffee = new Coffee();
myCoffee.MIllilitres = 120;//再添加装饰的类中可以定义对应的值，参考新get，set方法
myCoffee = new AddOnSaltedCaramel(myCoffee);

Console.WriteLine(myCoffee.Cost());
Console.WriteLine(myCoffee.MIllilitres);
Console.WriteLine(myCoffee.Description());


Beverage myLatte=new Latte();
myLatte = new AddOnSaltedCaramel(myLatte);

Console.WriteLine(myLatte.Cost());
Console.WriteLine(myLatte.Description());

Beverage myTea = new Tea();
myTea = new AddOnSugar(myTea);
myTea = new AddOnSugar(myTea);
myTea = new AddOnSugar(myTea);
myTea = new AddOnSaltedCaramel(myTea);
myTea = new AddOnCream(myTea);
myTea = new AddOnSpeakingDrink(myTea);


Console.WriteLine(myTea.Cost());
Console.WriteLine(myTea.Description());
public abstract class Beverage//抽象类
{
    //protected受保护的  virtual虚拟的
    protected string _description { get; set; }
    public virtual string Description()
    {
        return _description;
    }
    protected double _cost { get; set; }
    public virtual double Cost()
    {
        return _cost;
    }
    public virtual int MIllilitres { get; set; }
    //abstract抽象类中只能有abstract抽象或者Virtual虚假的属性
    //如果是抽象的必须实现，但是虚拟的不需要实现
}

public class Coffee : Beverage
{
    public Coffee()
    {
        _description = "Arabica Coffee";
        _cost = 1.25;
    }
}
public class Latte : Beverage
{
    public Latte()
    {
        _description = "Latte Coffee";
        _cost = 1.5;
    }
}
public class Espresso : Beverage
{
    public Espresso()
    {
        _description = "Espresso";
        _cost = 1.75;
    }
}
public class Tea : Beverage
{
    public Tea()
    {
        _description = "Loose Leaf Tea";
        _cost = 0.50;
    }
}
public class Smoothie : Beverage//Smoothie冰沙
{
    public Smoothie()
    {
        _description = "Fruit Smoothie";
        _cost = 3.5;
    }
}

//add am extra shot of espresso加一杯浓缩咖啡
//build one class out of many classes to add theri functionality从许多类中构建一个类来添加它们的功能

public abstract class AddOnDecorator : Beverage//Decorator装饰
{
    //whatever beverage this decorates is the property任何饮料都有装饰这个属性
    public Beverage Beverage { get; set; }
    public abstract override string Description();
    public abstract override double Cost();
    public override int MIllilitres 
    {
        get { return Beverage.MIllilitres; }
        set { Beverage.MIllilitres = value; }
    }
    //public AddOnDecorator(Beverage beverage)
    //{
    //    Beverage = beverage;
    //}
}
public class AddOnSaltedCaramel : AddOnDecorator
{
    public AddOnSaltedCaramel(Beverage beverage)
    {
        Beverage = beverage;
    }
    public override string Description()
    {
        return Beverage.Description() + ",salted Caramel";
    }
    public override double Cost()
    {
        return Beverage.Cost() + 1.00;
    }
}
public class AddOnSugar : AddOnDecorator
{
    public AddOnSugar(Beverage beverage)
    {
        Beverage = beverage;
    }
    public override string Description()
    {
        return Beverage.Description() + ",Sugar";
    }
    public override double Cost()
    {
        return Math.Round(Beverage.Cost() + 0.05,2);
    }
}
public class AddOnCream : AddOnDecorator
{
    public AddOnCream(Beverage beverage)
    {
        Beverage = beverage;
    }
    public override double Cost()
    {
        return Math.Round(Beverage.Cost() + 0.1,2);
    }

    public override string Description()
    {
        return Beverage.Description() + ",Cream";
    }
}
public class AddOnSpeakingDrink : AddOnDecorator
{
    public AddOnSpeakingDrink(Beverage beverage)
    {
        Beverage = beverage;
    }
    public override double Cost()
    {
        return Math.Round(Beverage.Cost() + 5.00, 2);
    }

    public override string Description()
    {
        return Beverage.Description() + ",and it talks to you.";
    }
}

//public class CoffeeWithEspresso : Beverage
//{
//    public CoffeeWithEspresso()
//    {
//        _description = "Arabica Coffee with Espresso";
//        _cost = 1.75;
//    }
//}

//public class TeaWithEspresso : Beverage
//{
//    public TeaWithEspresso()
//    {
//        _description = "Tea with Espresso";
//        _cost = 2.00;
//    }
//}
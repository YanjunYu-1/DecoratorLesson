经典案例：调配咖啡的例子

1、创建abstract类，这是一个大类，无论咖啡，奶昔还是茶都在饮料类中

（1）protected受保护的数据需要通过虚拟的方法进行调用

（2）abstract抽象类中abstract属性，在继承的过程中必须设置bady

（3）abstract抽象类中virtual虚假的属性，在继承的过程中不需要设置

2、对于不同饮料设置需要的property，在以后可以调用。

3、设置添加装饰的abstract类

（1）继承最大的父类，并可以在此类中自由调取饮料类中的信息

（2）将父类中virtual属性重写，并写成abstract型

（3）如果会用到的规格，例如大、中、小杯，1000ml、500ml在此override覆盖

4、设置添加的具体装饰

（1）设置构造函数（constructor），参数为父类

（2）override覆盖父类中的virtual虚假property，因为之前构造函数参数导入父类信息，此处可以直接调用

5,、做了一个关于汽车的小练习

/*
 ► At a Honda dealership, people can choose to buy a car from a large selection of new cars.
► 在本田经销商处，人们可以从大量新车中选择购买汽车。

► All new cars have properties like (Year, Model, Base Price, Color, Body Type).
► 所有新车都具有（年份、型号、基本价格、颜色、车身类型）等属性。

► After choosing the car they want, customers can select from a wide range of upgrades.
► 客户选择想要的汽车后，可以从多种升级中进行选择。

► Upgrades include (Leather Seats, Ignition Button, Hybrid Engine), each upgrade costs extra money.
► 升级包括（真皮座椅、点火按钮、混合引擎），每次升级都需要额外付费。

► Create an OOP design to model this system.
► 创建一个 OOP 设计来对该系统建模。

► Add “Alloy Rims” to the set of upgrade
► 将“合金轮辋”添加到升级组
 */
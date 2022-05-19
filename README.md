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
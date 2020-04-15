using System.Collections.Generic;

namespace BubbleSortWithDelegates
{
    class MyDataBase
    {
        public List<TShirt> Alltshirts { get; set; }
        public MyDataBase()
        {
            TShirt t1 = new TShirt(Color.RED, Size.M, Fabric.COTTON);
            TShirt t2 = new TShirt(Color.VIOLE, Size.L, Fabric.CASHMERE);
            TShirt t3 = new TShirt(Color.BLUE, Size.S, Fabric.LINEN);
            TShirt t4 = new TShirt(Color.INDIGO, Size.M, Fabric.COTTON);
            TShirt t5 = new TShirt(Color.YELLOW, Size.XXXL, Fabric.POLYESTER);
            TShirt t6 = new TShirt(Color.GREEN, Size.XXL, Fabric.RAYON);
            TShirt t7 = new TShirt(Color.INDIGO, Size.M, Fabric.LINEN);
            TShirt t8 = new TShirt(Color.RED, Size.XS, Fabric.SILK);
            TShirt t9 = new TShirt(Color.RED, Size.M, Fabric.WOOL);
            TShirt t10 = new TShirt(Color.BLUE, Size.XS, Fabric.CASHMERE);
            TShirt t11 = new TShirt(Color.GREEN, Size.L, Fabric.COTTON);
            TShirt t12 = new TShirt(Color.RED, Size.M, Fabric.POLYESTER);
            TShirt t13 = new TShirt(Color.VIOLE, Size.L, Fabric.RAYON);
            TShirt t14 = new TShirt(Color.RED, Size.M, Fabric.COTTON);
            TShirt t15 = new TShirt(Color.INDIGO, Size.XXXL, Fabric.COTTON);
            TShirt t16 = new TShirt(Color.ORANGE, Size.XXL, Fabric.CASHMERE);
            TShirt t17 = new TShirt(Color.ORANGE, Size.XL, Fabric.COTTON);
            TShirt t18 = new TShirt(Color.BLUE, Size.M, Fabric.LINEN);
            TShirt t19 = new TShirt(Color.VIOLE, Size.M, Fabric.SILK);
            TShirt t20 = new TShirt(Color.ORANGE, Size.L, Fabric.WOOL);
            TShirt t21 = new TShirt(Color.RED, Size.S, Fabric.CASHMERE);
            TShirt t22 = new TShirt(Color.GREEN, Size.S, Fabric.COTTON);
            TShirt t23 = new TShirt(Color.RED, Size.M, Fabric.LINEN);
            TShirt t24 = new TShirt(Color.BLUE, Size.XL, Fabric.RAYON);
            TShirt t25 = new TShirt(Color.RED, Size.XS, Fabric.COTTON);
            TShirt t26 = new TShirt(Color.RED, Size.XXL, Fabric.WOOL);
            TShirt t27 = new TShirt(Color.GREEN, Size.L, Fabric.COTTON);
            TShirt t28 = new TShirt(Color.ORANGE, Size.M, Fabric.LINEN);
            TShirt t29 = new TShirt(Color.RED, Size.M, Fabric.SILK);
            TShirt t30 = new TShirt(Color.RED, Size.L, Fabric.RAYON);
            TShirt t31 = new TShirt(Color.YELLOW, Size.S, Fabric.COTTON);
            TShirt t32 = new TShirt(Color.RED, Size.XXL, Fabric.COTTON);
            TShirt t33 = new TShirt(Color.VIOLE, Size.M, Fabric.CASHMERE);
            TShirt t34 = new TShirt(Color.RED, Size.XL, Fabric.COTTON);
            TShirt t35 = new TShirt(Color.YELLOW, Size.M, Fabric.CASHMERE);
            TShirt t36 = new TShirt(Color.INDIGO, Size.XS, Fabric.COTTON);
            TShirt t37 = new TShirt(Color.RED, Size.XXL, Fabric.COTTON);
            TShirt t38 = new TShirt(Color.RED, Size.XXL, Fabric.CASHMERE);
            TShirt t39 = new TShirt(Color.ORANGE, Size.M, Fabric.COTTON);
            TShirt t40 = new TShirt(Color.GREEN, Size.XS, Fabric.LINEN);

            Alltshirts = new List<TShirt>() { t1,t2,t3,t4,t5,t6,t7,t8,t9,t10,t11,t12,t13,t14,t15,t16,t17,t18,t19,t20,
                t21,t22,t23,t24,t25,t26,t27,t28,t29,t30,t31,t32,t33,t34,t35,t36,t37,t38,t39,t40};
        }
    }
}

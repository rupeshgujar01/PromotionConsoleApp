using System;

namespace PromotionConsoleApp
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            GetCart();
        }

        public static void GetCart()
        {
            int UnitPriceA = 50, UnitPriceB = 30, UnitPriceC = 20, UnitPriceD = 15;
            int QtyA, QtyB, QtyC, QtyD;

            Console.WriteLine("How many units of A : ");
            QtyA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many units of B : ");
            QtyB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many units of C : ");
            QtyC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many units of D : ");
            QtyD = Convert.ToInt32(Console.ReadLine());

            int Total = CalculateTotal(QtyA, QtyB, QtyC, QtyD);

            Console.WriteLine("Total : " + Total);
            Console.ReadLine();
        }

        public static int CalculateTotal(int qtyA, int qtyB, int qtyC, int qtyD)
        {
            Promotions promotion = new Promotion3ofA();
            int ATotal = promotion.CalculatePromotion(qtyA);

            promotion = new Promotion2ofB();
            int BTotal = promotion.CalculatePromotion(qtyB);

            promotion = new PromotionCD();
            promotion.d = qtyD;
            int CDTotal = promotion.CalculatePromotion(qtyC);

            int Total = ATotal + BTotal + CDTotal;
            return Total;
        }
    }

    public class Promotions
    {
        public int d = 0;
        public virtual int CalculatePromotion(int qty)
        {
            int total = 0;
            return total;
        }
    }

    public class Promotion3ofA : Promotions
    {
        public override int CalculatePromotion(int qtyA)
        {
            int promtotionalQtyA = qtyA / 3;
            int normalQtyA = qtyA % 3;

            int ATotal = (promtotionalQtyA * 130) + (normalQtyA * 50);
            return ATotal;
        }
    }

    public class Promotion2ofB : Promotions
    {
        public override int CalculatePromotion(int qtyB)
        {
            int promtotionalQtyB = qtyB / 2;
            int normalQtyB = qtyB % 2;

            int BTotal = (promtotionalQtyB * 45) + (normalQtyB * 30);
            return BTotal;
        }
    }

    public class PromotionCD : Promotions
    {
        public override int CalculatePromotion(int qtyC)
        {
            int promtotionalQtyCD = 0, normalQtyCD = 0, CDTotal = 0;
            if (qtyC > 0 && d > 0)
            {
                promtotionalQtyCD = (qtyC + d) / 2;
                normalQtyCD = (qtyC + d) % 2;

                if (qtyC != d)
                {
                    normalQtyCD = qtyC > d ? 20 : 15;
                }
                CDTotal = (promtotionalQtyCD * 30) + (normalQtyCD);
            }
            else if (qtyC > 0)
            {
                CDTotal = qtyC * 20;
            }
            else if (d > 0)
            {
                CDTotal = d * 15;
            }

            return CDTotal;
        }
    }
}

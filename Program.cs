using System;

namespace PromotionConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int QtyA, QtyB, QtyC, QtyD;
            GetCart(out QtyA, out QtyB, out QtyC, out QtyD);
        }

        public static void GetCart(out int QtyA, out int QtyB, out int QtyC, out int QtyD)
        {
            int UnitPriceA = 50, UnitPriceB = 30, UnitPriceC = 20, UnitPriceD = 15;

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
            int promtotionalQtyA = qtyA / 3;
            int normalQtyA = qtyA % 3;

            int ATotal = (promtotionalQtyA * 130) + (normalQtyA * 50);


            int promtotionalQtyB = qtyB / 2;
            int normalQtyB = qtyB % 2;

            int BTotal = (promtotionalQtyB * 45) + (normalQtyB * 30);

            int promtotionalQtyCD=0, normalQtyCD=0, CDTotal=0;
            if (qtyC > 0 && qtyD > 0)
            {
                promtotionalQtyCD = (qtyC + qtyD) / 2;
                normalQtyCD = (qtyC + qtyD) % 2;

                if (qtyC != qtyD)
                {
                    normalQtyCD = qtyC > qtyD ? 20 : 15;
                }
                CDTotal = (promtotionalQtyCD * 30) + (normalQtyCD);
            }
            else if (qtyC > 0)
            {
                CDTotal = qtyC * 20;
            }
            else if (qtyD > 0)
            {
                CDTotal = qtyD * 15;
            }

            int Total = ATotal + BTotal + CDTotal;
            return Total;            
        }
    }
}

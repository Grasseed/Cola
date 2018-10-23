using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("今天有一個商家推出可樂促銷活動,一瓶可樂一元,「每2瓶空瓶或每4枚瓶蓋即可再換一瓶可樂」," +
                "試算出所有錢買可樂後,最後能喝到幾瓶可樂?");
            Console.Write("請輸入你想買可樂的錢:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("你能兌換到的可樂瓶數:" + CountBottle(n) + "瓶");
            Console.ReadKey();
        }
        public static int CountBottle(int Bottle)
        {
            int BottleTop = Bottle, sum = Bottle, EmptyBottle = Bottle;//令瓶蓋為瓶子數,瓶子總數為瓶子數,空瓶子數目為瓶子數
            int RemEmptyBottle, RemBottleTop;//剩餘空瓶數換完瓶子的空瓶數,蓋子換完空瓶子剩下的蓋子數目

            while ((EmptyBottle >= 2) || (BottleTop >= 4))//當空瓶子數目大於等於2或瓶蓋數大於等於4條件成立時,做下列行為
            {
                Bottle = (EmptyBottle / 2) + (BottleTop / 4);//可兌得瓶數 = 空瓶子/2+瓶蓋/4
                RemEmptyBottle = EmptyBottle % 2;//兌換後剩餘瓶數 =  空瓶子/2的餘數
                RemBottleTop = BottleTop % 4;//兌換後剩餘瓶蓋數 =  空瓶子/2的餘數
                EmptyBottle = Bottle;//空瓶數=兌得瓶子數
                BottleTop = Bottle;//瓶蓋=兌得瓶子數
                sum += Bottle;//瓶子(含飲料)總數=原始總數+兌得的瓶數
                EmptyBottle += RemEmptyBottle;//空瓶子數=原本的空瓶子數+兌換後剩餘瓶數
                BottleTop += RemBottleTop;//瓶蓋數=兌換後剩餘瓶蓋數
            }
            //例如輸入10元,輸出可兌得35瓶可樂
            //a+=b >> a = a+b
            return sum;//回傳函式一個總和值
        }
    }
}

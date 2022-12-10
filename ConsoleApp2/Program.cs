//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////namespace ConsoleApp2
////{
//    //    internal class Program
//    //    {
//    //        static void Main(string[] args)
//    //        {
//    //            double oneM, day;
//    //            double S; //oneM=원금,day=기간,S=원리합계
//    //            double per=0;//이율
//    //            Console.WriteLine("원금 = ");
//    //            oneM=double.Parse(Console.ReadLine());
//    //            Console.WriteLine("기간 = ");
//    //            day=double.Parse(Console.ReadLine());
//    //            Console.WriteLine("이율 = ");
//    //            per=double.Parse(Console.ReadLine());

//    //            S = oneM *Math.Pow((1 + per),day);
//    //            Console.WriteLine("결과 : {0}", S);

//    //        }
//    //    }
//    //}


//class Program
// {
//    static void Main(String[] args)
//     {
//       string str;
//       int year;
//       Console.WriteLine("연도를 입력해주세요");
//       str=Console.ReadLine();
//       year=int.Parse(str);
//       if((year%4)==0&&((year%100)!=0||(year%400)==0))
//        {
//            Console.WriteLine("{0}년은 윤년입니다.", year);
//        }
//       else
//        {
//            Console.WriteLine("{0}년은 평년입니다.", year);
//        }
//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project003
{
    class MaxApp
    {
        public static void Main()
        {
            //int[] Area = new int[] { 6, 9, 8, 7, 0 }; //배열에 정수 5개 입력, 마지막 0을 입력
            //int[] A1 = new int[200];


            //Console.WriteLine("최대값 : " + Area.Max()); //최댓값 출력

            int one;//2000원씩
            int ju;//26주
            for(one=2000;one<=26*2000;one++)
            {
                for(ju=1;ju<=26;ju++)
                {
                    Console.WriteLine("26주 후 원금: {0}",one);
                }
            }
        }
    }
}
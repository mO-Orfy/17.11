//Уроки 20-21
//№4
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//if (x > 0 && y > 0)
//{
//    Console.WriteLine("1");
//}
//else
//{
//    if (x < 0 && y > 0)
//    {
//        Console.WriteLine("2");
//    }
//    else
//    {
//        if (x < 0 && y < 0)
//        {
//            Console.WriteLine("3");
//        }
//        else
//        {
//            if (x > 0 && y < 0)
//            {
//                Console.WriteLine("4");
//            }
//        }
//    }
//}
//№5
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//int z = Convert.ToInt32(Console.ReadLine());
//if (x > 0 && y > 0 && z > 0)
//{
//    Console.WriteLine("1");
//}
//else
//{
//    if (x < 0 && y > 0 && z > 0)
//    {
//        Console.WriteLine("2");
//    }
//    else
//    {
//        if (x < 0 && y < 0 && z > 0)
//        {
//            Console.WriteLine("3");
//        }
//        else
//        {
//            if (x > 0 && y < 0 && z > 0)
//            {
//                Console.WriteLine("4");
//            }
//            else
//            {
//                if (x > 0 && y < 0 && z < 0)
//                {
//                    Console.WriteLine("5");
//                }
//                else
//                {
//                    if (x > 0 && y < 0 && z < 0)
//                    {
//                        Console.WriteLine("6");
//                    }
//                    else
//                    {
//                        if (x > 0 && y < 0 && z < 0)
//                        {
//                            Console.WriteLine("7");
//                        }
//                         else
//                         {
//                            if (x > 0 && y < 0 && z < 0)
//                            {
//                                Console.WriteLine("8");
//                            }
//                            }
//                        }
//                    }
//                }
//            }


//        }
//    }
//Уроки 22-23
//№3
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a <= b && b <= c)
//{
//    Console.WriteLine("{0} {1} {2}", a, b, c);
//}
//else if (a <= c && c <= b)
//{
//    Console.WriteLine("{0} {1} {2}", a, c, b);
//}
//else if (b <= a && a <= c)
//{
//    Console.WriteLine("{0} {1} {2}", b, a, c);
//}
//else if (b <= c && c <= a)
//{
//    Console.WriteLine("{0} {1} {2}", b, c, a);
//}
//else if (c <= a && a <= b)
//{
//    Console.WriteLine("{0} {1} {2}", c, a, b);
//}
//else
//{
//    Console.WriteLine("{0} {1} {2}", c, b, a);
//}
//№4
//int x1 = int.Parse(Console.ReadLine());
//int y1 = int.Parse(Console.ReadLine());
//int x2 = int.Parse(Console.ReadLine());
//int y2 = int.Parse(Console.ReadLine());
//int dx = Math.Abs(x1 - x2);
//int dy = Math.Abs(y1 - y2);
//if ((dx == 2 && dy == 1) || (dx == 1 && dy == 2)) { Console.WriteLine("YES");
// } 
//  else { Console.WriteLine("NO");
// } 
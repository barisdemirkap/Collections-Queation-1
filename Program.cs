using System ;
using System.Collections ;

namespace question1
{
    class Program
    {   
        public static bool IsPrime(int number1)
        {
            bool condition = false;
            int control = 0 ;
            for (int i =2; i<number1 ; i++)
                {
                    if(number1%i==0)
                        {
                            control=1;
                            break;
                        }       
                }
            if(control==1)
            {
                condition=false ;
            }
            else
            {
                condition = true ;
            }
            return condition ;
        }
        static void Main(string[] args)
        {   
            ArrayList _list = new ArrayList() ;
            ArrayList _listprime = new ArrayList() ;
            ArrayList _listnotprime = new ArrayList() ;
            int countprime = 0 ;
            int countnotprime = 0 ;
            decimal sumprime = 0 ;
            decimal sumnotprime = 0 ;
            for(int i = 0 ; i<20 ; i++)
                 {   try
                    {   Console.WriteLine("Bir sayi giriniz") ;

                        int number=Convert.ToInt32(Console.ReadLine()) ;
                        if (IsPrime(number))
                            {
                                _listprime.Add(number) ;
                                countprime++ ;
                            }
                        else
                        {
                            _listnotprime.Add(number) ;
                            countnotprime++ ;
                        }                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Bad Number") ;
                    }
                 } 
                
                _listnotprime.Sort();
                _listprime.Sort();
        
                    Console.WriteLine("*** Sirali Asal Sayilar***") ;
                foreach (var item in _listprime)
                    Console.WriteLine(item) ;

                Console.WriteLine("*** Sirali Asal olmayan Sayilar***") ;
                foreach (var item in _listnotprime)
                    Console.WriteLine(item) ;
                
                for(int i = 0 ; i < countprime ; i++)
                    {
                        sumprime += Convert.ToInt32(_listprime[i]) ;
                    }
                Console.WriteLine("asal sayilar ortalamasi:" + sumprime/countprime) ;
                for(int i = 0 ; i < countnotprime ; i++)
                    {
                        sumnotprime += Convert.ToInt32(_listnotprime[i]) ;
                    }
                Console.WriteLine("asal olmayan sayilar ortalamasi:" + sumnotprime/countnotprime) ;


            }

        
            


        }
    }

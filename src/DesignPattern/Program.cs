﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Decoretor DesignPattern
            Decoretor();
            #endregion
            #region  Observer DesignPattern
            Observer();
            #endregion

            #region  Strategy DesignPattern
            Strategy();
            #endregion
            #region  Chain_Of_Responsibility DesignPattern
            Chain_Of_Responsibility();
            #endregion

            void Decoretor()
            {
                Console.WriteLine("--------Decoretor Pattern----------");
                Decoretor.FileDataSource source = new Decoretor.FileDataSource("Test.txt");
                var compration = new Decoretor.ComprationDecoredtor(source);
                var DataEncription = new Decoretor.EncriptionDecretor(compration);
                DataEncription.Write("Data1");
                Console.WriteLine("===============");
                Console.WriteLine(DataEncription.Read());
                Console.ReadKey();
                Console.ReadKey();
            }
            void Observer()
            {
                Console.WriteLine("------------ObserverPattern--------");
                ObServer.Celebritys Kylie = new ObServer.Celebritys("Kylie Jenner");
                ObServer.Celebritys Kanye = new ObServer.Celebritys("Kanye Wes");

                ObServer.follower followerAli = new ObServer.follower("Ali");
                ObServer.follower followerHamid = new ObServer.follower("Hamid");
                ObServer.follower followerMojtabad = new ObServer.follower("Mojtabad");
                ObServer.follower followerDavood = new ObServer.follower("Davood");

                Kylie.Register(followerDavood);
                Kanye.Register(followerAli);

                Kylie.tweet("Welcome here");
                Kanye.tweet("Hello followers");

                Kanye.Register(followerHamid);
                Kylie.Register(followerMojtabad);

                Kylie.tweet("Today is a good day");
                Kanye.tweet("A new song is on the way");

                Console.ReadKey();

            }
            void Strategy()
            {
                Console.WriteLine("------------StrategyPattern--------");
                DesignPattern.Strategy.ContextSort contextSort = new Strategy.ContextSort();
                int[] input = { 4, 2, 9, 6, 23, 12, 34, 0, 1 };
                contextSort.setnumbers(input);
                contextSort.SetStrategy(new DesignPattern.Strategy.QuickSort());
                contextSort.SortNumers();

                contextSort.setnumbers(input);
                contextSort.SetStrategy(new DesignPattern.Strategy.SelectionSort());
                contextSort.SortNumers();

                contextSort.setnumbers(input);
                contextSort.SetStrategy(new DesignPattern.Strategy.BubbleSort());
                contextSort.SortNumers();

                Console.ReadKey();
            }
            void Chain_Of_Responsibility()
            {
                Console.WriteLine("------------Chain_Of_Responsibility_Pattern--------");
                DesignPattern.Chain_Of_Responsibility.Handler assistant = new DesignPattern.Chain_Of_Responsibility.assistant();
                DesignPattern.Chain_Of_Responsibility.Handler manager = new DesignPattern.Chain_Of_Responsibility.manager();
                DesignPattern.Chain_Of_Responsibility.Handler CEO = new DesignPattern.Chain_Of_Responsibility.CEO();
                assistant.setsuccessor(manager);
                manager.setsuccessor(CEO);

                DesignPattern.Chain_Of_Responsibility.Cheque cheque1 = new Chain_Of_Responsibility.Cheque("123456" , 1500000);
                DesignPattern.Chain_Of_Responsibility.Cheque cheque2 = new Chain_Of_Responsibility.Cheque("654321", 800000);
                DesignPattern.Chain_Of_Responsibility.Cheque cheque3 = new Chain_Of_Responsibility.Cheque("987654", 3000000);

                assistant.Sendcheckforsignature(cheque1);
                assistant.Sendcheckforsignature(cheque2);
                assistant.Sendcheckforsignature(cheque3);
                Console.ReadKey();
            }
        }
        
    }
}

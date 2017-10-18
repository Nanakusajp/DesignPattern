﻿using System;

namespace SingletonSample
{
    public class Singleton
    {
        private static readonly Singleton _singleton = new Singleton();

        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static Singleton GetInstance()
        {
            return _singleton;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safemoon_Stats
{
    public class Var
    {
        private static bool pullWallet_;
        public static bool pullWallet
        {
            get { return pullWallet_; }
            set { pullWallet_ = value; }
        }

        private static string Price_;
        public static string Price
        {
            get { return Price_; }
            set { Price_ = value; }
        }

        private static string Volume_;
        public static string Volume
        {
            get { return Volume_; }
            set { Volume_ = value; }
        }

        private static string Marketcap_;
        public static string Marketcap
        {
            get { return Marketcap_; }
            set { Marketcap_ = value; }
        }
    }
}

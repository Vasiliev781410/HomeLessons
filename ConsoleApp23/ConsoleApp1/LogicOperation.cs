using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp23
{
    public class LogicOperation
    {
        public static List<FixedAssets> assets = new List<FixedAssets>();
        public static DateTime DateBegin = new DateTime();
        public static DateTime CurrentDate = new DateTime();

        public static void DateBeginSet()
        {
            DateBegin = DateTime.Today;
            CurrentDate = DateTime.Today;
        }

        static object locker = new object();
        public static void DateCurrentSet()
        {
            lock (locker)
            {
                CurrentDate = CurrentDate.AddDays(1);
                //Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, CurrentDate);
            }
        }

        public static void CountWearout()
        {
            foreach (FixedAssets asset in LogicOperation.assets)
            {
                TimeSpan diff = CurrentDate - asset.DateBeginExpl;
                double days = diff.TotalDays;
                if (days < asset.ServiceTimeD)
                {
                    asset.StillDays = asset.ServiceTimeD - days;
                }
                else
                {
                    asset.StillDays = 0;
                }
            }
        }
        public static void OrderAsset()
        {
            foreach (FixedAssets asset in LogicOperation.assets)
            {
                TimeSpan diff = CurrentDate - asset.DateBeginExpl;
                double days = diff.TotalDays;
                if (asset.ServiceTimeD != 0)
                {
                    if (days / asset.ServiceTimeD * 100 > 70)
                    {
                        asset.Name.WriteExpr();
                    }
                }
            }
        }
        public static void ListAssets()
        {
            LogicOperation.assets.Sort(delegate (FixedAssets us1, FixedAssets us2)
            { return us1.StillDays.CompareTo(us2.StillDays); });

            foreach (FixedAssets asset in LogicOperation.assets)
            {
                Console.WriteLine("Основное средство {0} осталось эксплуатировать {1}", asset.Name, asset.StillDays.ToString());
            }
        }

        public static void AddList(FixedAssets obj)
        {
            assets.Add(obj);
        }
    }
}

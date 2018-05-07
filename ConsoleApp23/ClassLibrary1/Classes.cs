using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // абстрактный класс Основные фонды
    public abstract class FixedAssets
    {
        public string Name { get; set; }
        public int ServiceTimeD { get; set; }
        public DateTime DateBeginExpl { get; set; }
        public double StillDays { get; set; }

    }

    // 1. Абстр. класс Оборудование
    public abstract class Equipments : FixedAssets
    {
    }
    //// 1.1.Класс компьютеры абстр. класса Оборудование (1)
    public class Computers : Equipments
    {
        public Computers NewAsset(string name, int servDay, DateTime date)
        {
            Computers asset = new Computers();
            asset.Name = name;
            asset.ServiceTimeD = servDay;
            asset.DateBeginExpl = date;

            return asset;
        }
    }
    //// 1.2 Класс станки абстр. класса Оборудование (2)
    public class MachineTools : Equipments
    {
        public MachineTools NewAsset(string name, int servDay, DateTime date)
        {
            MachineTools asset = new MachineTools();
            asset.Name = name;
            asset.ServiceTimeD = servDay;
            asset.DateBeginExpl = date;

            return asset;
        }

    }

    // 2. Абстр. класс Приборы и инвентарь
    public abstract class Inventory : FixedAssets
    {
    }
    //// 2.1.Класс мебель абстр. класса Приборы и инвентарь (3)
    public class Furnitures : Inventory
    {
        public Furnitures NewAsset(string name, int servDay, DateTime date)
        {
            Furnitures asset = new Furnitures();
            asset.Name = name;
            asset.ServiceTimeD = servDay;
            asset.DateBeginExpl = date;

            return asset;
        }
    }
    //// 2.2 Класс приборы абстр. класса Приборы и инвентарь (4)
    public class Appliances : Inventory
    {
        public Appliances NewAsset(string name, int servDay, DateTime date)
        {
            Appliances asset = new Appliances();
            asset.Name = name;
            asset.ServiceTimeD = servDay;
            asset.DateBeginExpl = date;

            return asset;
        }
    }

    // 3. Абстр. класс Траснпорт
    public abstract class Transport : FixedAssets
    {
    }
    //// 3.1.Класс Грузовики абстр. класса Траснпорт (5)
    public class Autotrucks : Transport
    {
        public Autotrucks NewAsset(string name, int servDay, DateTime date)
        {
            Autotrucks asset = new Autotrucks();
            asset.Name = name;
            asset.ServiceTimeD = servDay;
            asset.DateBeginExpl = date;

            return asset;
        }
    }
    //// 3.2 Класс Легковые авто абстр. класса Траснпорт (6)
    public class Cars : Transport
    {
        public Cars NewAsset(string name, int servDay, DateTime date)
        {
            Cars asset = new Cars();
            asset.Name = name;
            asset.ServiceTimeD = servDay;
            asset.DateBeginExpl = date;

            return asset;
        }
    }

}

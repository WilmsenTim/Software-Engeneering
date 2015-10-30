using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class PlayerStats
    {
        string name = "Player";
        int moneySelected = 0;
        int money = 5000;


        public string Name
        {
            get
            {
                if (name != null || name != "")
                {
                    return name;
                }
                else
                {
                    return "Player1";
                }
            }
            set
            {
                if(value != null || name != "")
                {
                    name = value;
                }
                else
                {
                    name = "Player1";
                }
            }
        }
        public int MoneySelected
        {
            get
            {
                return moneySelected;
            }
            set
            {
                moneySelected = value;
            }
        }

        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }


        public PlayerStats(string initName,int initMoney)
        {
            Name = initName;
            Money = initMoney;
        }



    }
}

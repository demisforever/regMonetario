using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reg_monetario.Clases
{
    class CurrencyPurchase
    {
        int idCurrencyPurchase;
        DateTime date;
        decimal price;
        decimal usd;
        decimal ars;
        string description;

        public CurrencyPurchase()
        {
        }

        public CurrencyPurchase(int idCurrencyPurchase, DateTime date, decimal price, decimal usd, decimal ars, string description)
        {
            this.idCurrencyPurchase = idCurrencyPurchase;
            this.date = date;
            this.price = price;
            this.usd = usd;
            this.ars = ars;
            this.description = description;
        }

        public int IdCurrencyPurchase
        {
            set { idCurrencyPurchase = value; }
            get { return idCurrencyPurchase; }
        }

        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }

        public decimal Value
        {
            set { price = value; }
            get { return price; }
        }

        public decimal Usd
        {
            set { usd = value; }
            get { return usd; }
        }

        public decimal Ars
        {
            set { ars = value; }
            get { return ars; }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }

    }
}

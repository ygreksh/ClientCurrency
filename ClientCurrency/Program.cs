using System;
using System.Collections.Generic;

namespace ClientCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Client, Account> clients = new Dictionary<Client,Account>();

            clients.Add(new Client {Name = "Ivanov" }, 
                new Account { currency = new Ruble 
                { CurrencyName = "Ruble", rate = 77.0 }, value = 10000 });
            clients.Add(new Client { Name = "Petrov" }, 
                new Account { currency = new Leu { CurrencyName = "Ruble", rate = 22.0 }, value = 10000 });
            clients.Add(new Client { Name = "Sidorov" }, 
                new Account { currency = new Dollar { CurrencyName = "Ruble", rate = 99.0 }, value = 10000 });


            // если клиент может иметь несколько счетов в разных валютах
            // для каждого из них создается свой Dictionary<Account, string>
            // ключ Account гарантирует что у одного клиента все счета с разной валютой
            Ruble currencyRubles = new Ruble { CurrencyName = "Ruble", rate = 78};
            Dollar currencyDollar = new Dollar { CurrencyName = "Dollar", rate = 1};
            Leu currencyLeu = new Leu { CurrencyName = "Leu", rate = 18};
            //словарь из трех сченов разных валют
            Dictionary<Account, string> dictAccount = new Dictionary<Account, string>() {
                { new Account { currency = currencyRubles, value = 123.45 }, "Счет в рублях"},
                { new Account { currency = currencyDollar, value = 4.20 }, "Счет в долларах"},
                { new Account { currency = currencyLeu, value = 88.80 }, "Счет в леях" }
            };
            //Новый клиент Кузнецов
            Client clientKuznetsov = new Client
            {
                Name = "Kuznetsov",
                PassportNumber = "RR-9876543"
            };
            //Теперь новый Dictionary<Client, Dictionary<Account, string>>
            Dictionary<Client, Dictionary<Account, string>> multiAccauntClints = new Dictionary<Client, Dictionary<Account, string>>();
            multiAccauntClints.Add(clientKuznetsov,dictAccount);    // Добавлен Кузнецов с тремя валютными счетами
            


            


        }

        public static double CurrencyExchange(double valueFrom, Currency currencyFrom, Currency currencyTo) 
        {

            return valueFrom * currencyFrom.rate / currencyTo.rate ;
        }
    }
}

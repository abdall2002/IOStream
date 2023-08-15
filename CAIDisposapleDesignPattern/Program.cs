// See https://aka.ms/new-console-template for more information

using CAIDisposapleDesignPattern;


// 1) not recommended

CurrencyService currencyService = new CurrencyService();
var result = currencyService.GetCurrencies();
//currencyService.Dispose();
Console.WriteLine(result);
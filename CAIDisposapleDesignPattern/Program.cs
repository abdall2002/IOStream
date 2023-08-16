// See https://aka.ms/new-console-template for more information

using CAIDisposapleDesignPattern;


// 1) not recommended

//CurrencyService currencyService = new CurrencyService();
//var result = currencyService.GetCurrencies();
//currencyService.Dispose();
//Console.WriteLine(result);

//2) recommended
//CurrencyService currencyService = null;
//try
//{
//    currencyService = new CurrencyService();
//    var result = currencyService.GetCurrencies();
//    Console.WriteLine(result);

//}
//catch (Exception)
//{
//    Console.WriteLine("Error");
//}
//finally
//{
//    currencyService?.Dispose(); 
//}

// 3) more recommended  using .net framework 2+

//using (CurrencyService currencyService = new CurrencyService())
//{ 
//    var result = currencyService.GetCurrencies();
//    Console.WriteLine(result);
//}

// 4) using with no blocks c# 8.0
CurrencyService currencyService = new CurrencyService();
var result = currencyService.GetCurrencies();
Console.WriteLine(result);

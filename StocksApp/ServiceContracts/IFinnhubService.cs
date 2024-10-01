namespace StocksApp.ServiceContracts
{
    public interface IFinnhubService
    {
        Task<Dictionary<string, object>?> GetStockPrieceQuote(string stockSymbol);

    }
}

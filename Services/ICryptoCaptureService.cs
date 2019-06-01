using CryptoCommon.DataTypes;
using PortableCSharpLib.DataType;
using PortableCSharpLib.TechnicalAnalysis;
using System.Collections.Generic;

namespace Services
{
    public interface ICryptoCaptureService
    {
        string GetExchange();
        List<string> GetAvailableSymbols();
        Ticker GetTicker(string symbol);
        //Dictionary<string, Ticker> GetTickers();
        Orderbook GetOrderbook(string symbol);
        List<OHLC> GetOHLC(string symbol, int interval);
        QuoteBasicBase Download(string symbol, int interval, int limit = 300);
        //three messages
        //event EventHandlers.TickerReceivedEventHandlerList OnTickerListReceived;
        //event EventHandlers.ExceptionOccuredEventHandler OnExceptionOccured;
        //event EventHandlers.CandleListReceivedEventHandler OnCandleListRecevied;
    }
}

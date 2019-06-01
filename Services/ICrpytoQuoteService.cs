using PortableCSharpLib.TechnicalAnalysis;
using System.Collections.Generic;

namespace Services
{
    public interface ICrpytoQuoteService
    {
        string GetExchange();
        List<string> GetAvaliableSymbols();
        List<string> GetAvaliableQuoteIds();
        QuoteCapture GetInMemoryQuoteCapture(string symbol);
        QuoteBasicBase GetInMemoryQuoteBasic(string symbol, int interval);
    }
}

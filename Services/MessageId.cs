namespace Services
{
    public enum MessageId
    {
        /// 1. {exch}_ICrpytoQuoteService
        Okex_Spot_QuoteBasicDataAppended,
        Okex_Spot_OnTickerList,
        Okex_Spot_OnCandleList,

        Okex_Future_QuoteBasicDataAppended,
        Okex_Future_OnTickerList,
        Okex_Future_OnCandleList,
        Okex_Future_OnFutureOrderList,

        Kraken_QuoteBasicDataAppended,
        Kraken_OnTickerList,
        Kraken_OnCandleList,

        Bittrex_QuoteBasicDataAppended,
        Bittrex_OnTickerList,
        Bittrex_OnCandleList
    }
}

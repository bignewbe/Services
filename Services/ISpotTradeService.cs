using CryptoCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISpotTradeService
    {
        //ServiceResult<bool> UpdateLastTimeForOrder(FZOrder order);
        ServiceResult<long> GetLastTimeForOrder(string orderId, string symbol);
        ServiceResult<List<FZOrder>> GetOpenOrders(string instrument_id, bool isReturnAll=false);         //submmiting + open + cancelling + partial filled
        ServiceResult<List<FZOrder>> GetClosedOrders(string instrument_id, bool isReturnAll = false);     //fully filled orders
        //ServiceResult<List<FZOrder>> GetCancelleddOrders(string instrument_id); //fully filled orders
        //ServiceResult<List<FZOrder>> GetFailedOrders(string instrument_id);     //fully filled orders

        ServiceResult<bool> CancelOrder(string symbol, string orderId);
        ServiceResult<FZOrder> CheckOrder(string symbol, string orderId);
        ServiceResult<FZOrder> PlaceStopOrder(string symbol, OrderType type, double amount, double tpPrice, double slPrice);
        ServiceResult<FZOrder> PlaceOrder(string symbol, OrderType type, double price, double amount, string refid, double? triggerprice = null);
        ServiceResult<FZOrder> PlaceOrder(FZOrder order);

        //account
        ServiceResult<Dictionary<string, SpotBalance>> GetAccounts();
        //ServiceResult<SpotBalance> GetAccountByCurrency(string currency);
    }
}

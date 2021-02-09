using CryptoCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISpotTradeService
    {
        //ServiceResult<bool> UpdateLastTimeForOrder(SpotOrder order);
        ServiceResult<long> GetLastTimeForOrder(string orderId, string symbol);
        ServiceResult<List<SpotOrder>> GetOpenOrders(string instrument_id, bool isReturnAll=false);         //submmiting + open + cancelling + partial filled
        ServiceResult<List<SpotOrder>> GetClosedOrders(string instrument_id, bool isReturnAll = false);     //fully filled orders
        //ServiceResult<List<SpotOrder>> GetCancelleddOrders(string instrument_id); //fully filled orders
        //ServiceResult<List<SpotOrder>> GetFailedOrders(string instrument_id);     //fully filled orders

        ServiceResult<bool> CancelOrder(string symbol, string orderId);
        ServiceResult<SpotOrder> PlaceOrder(string symbol, OrderType type, double price, double amount, string refid, double? triggerprice = null);
        ServiceResult<SpotOrder> CheckOrder(string symbol, string orderId);

        //account
        ServiceResult<Dictionary<string, SpotBalance>> GetAccounts();
        //ServiceResult<SpotBalance> GetAccountByCurrency(string currency);
    }
}

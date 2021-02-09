using CryptoCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISpotClient
    {
        //ServiceResult<long> GetOpenOrderList();
        ServiceResult<SpotOrder> UpdateLastTimeForOrder(SpotOrder order);
        ServiceResult<SpotOrder> PlaceOrder(SpotOrder order);
        ServiceResult<bool> CancelOrder(SpotOrder order);

        ServiceResult<Dictionary<string, SpotBalance>> GetAccountBalance();
        ServiceResult<Dictionary<string, SpotOrder>> GetOpenOrderList();
        ServiceResult<Dictionary<string, SpotOrder>> GetCloseOrderList();
        ServiceResult<List<SpotOrder>> GetOpenOrderListBySymbol(string symbol);
        ServiceResult<List<SpotOrder>> GetCloseOrderListBySymbol(string symbol);
        ServiceResult<SpotTradeInfo> GetSpotTradeInfo(string symbol, string paramId);
        ServiceResult<List<SwingParam>> GetTraderParam();
    }
}

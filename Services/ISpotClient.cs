using CryptoCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISpotClient
    {
        ServiceResult<Dictionary<string, SpotOrder>> GetOpenOrderList();
        ServiceResult<Dictionary<string, SpotOrder>> GetCloseOrderList();
        ServiceResult<List<SpotOrder>> GetOpenOrderListBySymbol(string symbol);
        ServiceResult<List<SpotOrder>> GetCloseOrderListBySymbol(string symbol);
        ServiceResult<SpotTradeInfo> GetSpotTradeInfo(string symbol, string paramId);
    }
}

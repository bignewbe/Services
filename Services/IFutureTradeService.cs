﻿using CryptoCommon.DataTypes;
using CryptoCommon.Future.DataType;
using CryptoCommon.Future.Interface;
using System.Collections.Generic;

namespace Services
{
    public interface IFutureTradeService
    {
        // order
        ServiceResult<List<FZOrder>> GetOpenOrders(string instrument_id);       //submmiting + open + cancelling + partial filled
        ServiceResult<List<FZOrder>> GetClosedOrders(string instrument_id);     //fully filled orders
        ServiceResult<List<FZOrder>> GetCancelleddOrders(string instrument_id); //fully filled orders
        ServiceResult<List<FZOrder>> GetFailedOrders(string instrument_id);     //fully filled orders

        ServiceResult<FZOrder> CancelOrder(string symbol, string orderId);
        ServiceResult<FZOrder> PlaceOrder(string symbol, OrderType type, double price, int amount, string refid, ExecutionType executionType = ExecutionType.Standard);
        ServiceResult<FZOrder> CheckOrder(string symbol, string orderId);

        //ServiceResult<FZOrder> PlaceOrder(FZOrder order);
        //ServiceResult<FZOrder> CancelOrder(FZOrder order);
        //ServiceResult<FZOrder> CheckOrder(FZOrder order);

        ServiceResult<Dictionary<string, FuturePosition>> GetPositionBatch();
        ServiceResult<FuturePosition> GetPositionById(string instrument_id);

        //account
        ServiceResult<Dictionary<string, FutureBalance>> GetAccounts();
        ServiceResult<FutureBalance> GetAccountByCurrency(string currency);
    }
}

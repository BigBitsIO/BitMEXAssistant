//using ServiceStack.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace BitMEX
{
    public class OrderBookItem
    {
        public string Symbol { get; set; }
        public int Level { get; set; }
        public int BidSize { get; set; }
        public decimal BidPrice { get; set; }
        public int AskSize { get; set; }
        public decimal AskPrice { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class BitMEXApi
    {
        private string domain = "https://www.bitmex.com";
        private string testdomain = "https://testnet.bitmex.com";
        private string apiKey;
        private string apiSecret;
        private int rateLimit;
        List<string> errors = new List<string>();

        public BitMEXApi(string bitmexKey = "", string bitmexSecret = "", bool RealNetwork = true, int rateLimit = 5000)
        {
            this.apiKey = bitmexKey;
            this.apiSecret = bitmexSecret;
            this.rateLimit = rateLimit;
            if(!RealNetwork)
            {
                this.domain = testdomain;
            }
        }

        #region API Connector - Don't touch
        private string BuildQueryData(Dictionary<string, string> param)
        {
            if (param == null)
                return "";

            StringBuilder b = new StringBuilder();
            foreach (var item in param)
                b.Append(string.Format("&{0}={1}", item.Key, WebUtility.UrlEncode(item.Value)));

            try { return b.ToString().Substring(1); }
            catch (Exception) { return ""; }
        }

        private string BuildJSON(Dictionary<string, string> param)
        {
            if (param == null)
                return "";

            var entries = new List<string>();
            foreach (var item in param)
                entries.Add(string.Format("\"{0}\":\"{1}\"", item.Key, item.Value));

            return "{" + string.Join(",", entries) + "}";
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private long GetNonce()
        {
            DateTime yearBegin = new DateTime(2018, 7, 17);
            return DateTime.UtcNow.Ticks - yearBegin.Ticks;
        }

        public byte[] hmacsha256(byte[] keyByte, byte[] messageBytes)
        {
            using (var hash = new HMACSHA256(keyByte))
            {
                return hash.ComputeHash(messageBytes);
            }
        }

        public string GetExpiresArg()
        {
            long timestamp = (long)((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);

            string expires = (timestamp + 60).ToString();

            return (expires);
        }

        public string GetWebSocketSignatureString(string APISecret, string APIExpires)
        {
            byte[] signatureBytes = hmacsha256(Encoding.UTF8.GetBytes(APISecret), Encoding.UTF8.GetBytes("GET/realtime" + APIExpires));
            string signatureString = ByteArrayToString(signatureBytes);
            return signatureString;
        }

        private string Query(string method, string function, Dictionary<string, string> param = null, bool auth = false, bool json = false)
        {
            string paramData = json ? BuildJSON(param) : BuildQueryData(param);
            string url = "/api/v1" + function + ((method == "GET" && paramData != "") ? "?" + paramData : "");
            string postData = (method != "GET") ? paramData : "";

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(domain + url);
            webRequest.Method = method;

            if (auth)
            {
                //string nonce = GetNonce().ToString();
                //string message = method + url + nonce + postData;
                string expires = GetExpiresArg();
                string message = method + url + expires + postData;
                byte[] signatureBytes = hmacsha256(Encoding.UTF8.GetBytes(apiSecret), Encoding.UTF8.GetBytes(message));
                string signatureString = ByteArrayToString(signatureBytes);

                //webRequest.Headers.Add("api-nonce", nonce);
                webRequest.Headers.Add("api-expires", expires);
                webRequest.Headers.Add("api-key", apiKey);
                webRequest.Headers.Add("api-signature", signatureString);
            }

            try
            {
                if (postData != "")
                {
                    webRequest.ContentType = json ? "application/json" : "application/x-www-form-urlencoded";
                    var data = Encoding.UTF8.GetBytes(postData);
                    using (var stream = webRequest.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }

                using (WebResponse webResponse = webRequest.GetResponse())
                using (Stream str = webResponse.GetResponseStream())
                using (StreamReader sr = new StreamReader(str))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (WebException wex)
            {
                using (HttpWebResponse response = (HttpWebResponse)wex.Response)
                {
                    if (response == null)
                        throw;

                    using (Stream str = response.GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(str))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
        #endregion

        #region Examples from BitMex
        //public List<OrderBookItem> GetOrderBook(string symbol, int depth)
        //{
        //    var param = new Dictionary<string, string>();
        //    param["symbol"] = symbol;
        //    param["depth"] = depth.ToString();
        //    string res = Query("GET", "/orderBook", param);
        //    return JsonSerializer.DeserializeFromString<List<OrderBookItem>>(res);
        //}

        //public string GetOrders(string Symbol)
        //{
        //    var param = new Dictionary<string, string>();
        //    param["symbol"] = Symbol;
        //    //param["filter"] = "{\"open\":true}";
        //    //param["columns"] = "";
        //    //param["count"] = 100.ToString();
        //    //param["start"] = 0.ToString();
        //    //param["reverse"] = false.ToString();
        //    //param["startTime"] = "";
        //    //param["endTime"] = "";
        //    return Query("GET", "/order", param, true);
        //}

        //public string PostOrders()
        //{
        //    var param = new Dictionary<string, string>();
        //    param["symbol"] = "XBTUSD";
        //    param["side"] = "Buy";
        //    param["orderQty"] = "1";
        //    param["ordType"] = "Market";
        //    return Query("POST", "/order", param, true);
        //}

        //public string DeleteOrders()
        //{
        //    var param = new Dictionary<string, string>();
        //    param["orderID"] = "de709f12-2f24-9a36-b047-ab0ff090f0bb";
        //    param["text"] = "cancel order by ID";
        //    return Query("DELETE", "/order", param, true, true);
        //}
        #endregion

        #region Our Calls


        #region Ordering
        public string MarketOrder(string Symbol, string Side, int Quantity, bool ReduceOnly = false)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = Symbol;
            param["side"] = Side;
            param["orderQty"] = Quantity.ToString();
            param["ordType"] = "Market";
            if(ReduceOnly)
            {
                param["execInst"] = "ReduceOnly";
            }
            string res = Query("POST", "/order", param, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("POST", "/order", param, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            return res;
        }

        public string LimitOrder(string Symbol, string Side, int Quantity, decimal Price, bool ReduceOnly = false, bool PostOnly = false, bool Hidden = false)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = Symbol;
            param["side"] = Side;
            param["orderQty"] = Quantity.ToString();
            param["ordType"] = "Limit";
            param["price"] = Price.ToString().Replace(",",".");
            if (ReduceOnly && !PostOnly)
            {
                param["execInst"] = "ReduceOnly";
            }
            else if(!ReduceOnly && PostOnly)
            {
                param["execInst"] = "ParticipateDoNotInitiate";
            }
            else if(ReduceOnly && PostOnly)
            {
                param["execInst"] = "ReduceOnly,ParticipateDoNotInitiate";
            }
            if(Hidden)
            {
                param["displayQty"] = "0";
            }


            string res = Query("POST", "/order", param, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("POST", "/order", param, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            return res;
        }

        public List<Order> LimitNowOrder(string Symbol, string Side, int Quantity, decimal Price, bool ReduceOnly = false, bool PostOnly = false, bool Hidden = false)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = Symbol;
            param["side"] = Side;
            param["orderQty"] = Quantity.ToString();
            param["ordType"] = "Limit";
            param["price"] = Price.ToString().Replace(",",".");
            if (ReduceOnly && !PostOnly)
            {
                param["execInst"] = "ReduceOnly";
            }
            else if (!ReduceOnly && PostOnly)
            {
                param["execInst"] = "ParticipateDoNotInitiate";
            }
            else if (ReduceOnly && PostOnly)
            {
                param["execInst"] = "ReduceOnly,ParticipateDoNotInitiate";
            }
            if (Hidden)
            {
                param["displayQty"] = "0";
            }


            string res = Query("POST", "/order", param, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("POST", "/order", param, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }

            try
            {
                List<Order> Result = new List<Order>();
                Result.Add(JsonConvert.DeserializeObject<Order>(res));
                return Result;
            }
            catch (Exception ex)
            {
                return new List<Order>();
            }
        }

        public List<Order> LimitNowAmendOrder(string OrderId, decimal? Price = null, int? OrderQty = null)
        {
            var param = new Dictionary<string, string>();
            param["orderID"] = OrderId;
            if(Price != null)
            {
                param["price"] = Price.ToString().Replace(",",".");
            }
            if(OrderQty != null)
            {
                param["orderQty"] = OrderQty.ToString();
            }

            string res = Query("PUT", "/order", param, true);

            try
            {
                List<Order> Result = new List<Order>();
                if(!res.Contains("error"))
                {
                    Result.Add(JsonConvert.DeserializeObject<Order>(res));
                    return Result;
                }
                else
                {
                    return new List<Order>();
                }
                
            }
            catch (Exception ex)
            {
                return new List<Order>();
            }
        }

        public List<Order> TrailingStopAmendOrder(string OrderId, decimal? Price = null, int? OrderQty = null)
        {
            var param = new Dictionary<string, string>();
            param["orderID"] = OrderId;
            if (Price != null)
            {
                param["price"] = Price.ToString().Replace(",",".");
            }
            if (OrderQty != null)
            {
                param["orderQty"] = OrderQty.ToString();
            }

            string res = Query("PUT", "/order", param, true);

            try
            {
                List<Order> Result = new List<Order>();
                if (!res.Contains("error"))
                {
                    Result.Add(JsonConvert.DeserializeObject<Order>(res));
                    return Result;
                }
                else
                {
                    return new List<Order>();
                }

            }
            catch (Exception ex)
            {
                return new List<Order>();
            }
        }

        public List<Order> CancelOrder(string OrderId)
        {
            var param = new Dictionary<string, string>();
            param["orderID"] = OrderId;
            
            string res = Query("DELETE", "/order", param, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("DELETE", "/order", param, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }

            try
            {
                List<Order> Result = new List<Order>();
                Result.Add(JsonConvert.DeserializeObject<Order>(res));
                return Result;
            }
            catch (Exception ex)
            {
                return new List<Order>();
            }
        }

        public string ChangeMargin(string Symbol, decimal Margin)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = Symbol;
            param["leverage"] = Margin.ToString();



            string res = Query("POST", "/position/leverage", param, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("POST", "/order", param, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            return res;
        }

        public string CancelAllOpenOrders(string symbol, string Note = "")
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["text"] = Note;
            string res = Query("DELETE", "/order/all", param, true, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("DELETE", "/order/all", param, true, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            return res;
        }

        public string BulkOrder(string Orders)
        {
            var param = new Dictionary<string, string>();
            param["orders"] = Orders;
            string res = Query("POST", "/order/bulk", param, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("POST", "/order/bulk", param, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            return res;
        }

        public string AmendBulkOrder(string Orders)
        {
            var param = new Dictionary<string, string>();
            param["orders"] = Orders;
            string res = Query("PUT", "/order/bulk", param, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("PUT", "/order/bulk", param, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            return res;
        }


        #endregion


        public List<Instrument> GetActiveInstruments()
        {
            string res = Query("GET", "/instrument/active");
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("GET", "/instrument/active");
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            try
            {
                return JsonConvert.DeserializeObject<List<Instrument>>(res);
            }
            catch (Exception ex)
            {
                return new List<Instrument>();
            }
        }

        public List<Instrument> GetInstrument(string symbol)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            string res = Query("GET", "/instrument", param);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("GET", "/instrument", param);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            try
            {
                return JsonConvert.DeserializeObject<List<Instrument>>(res);
            }
            catch (Exception ex)
            {
                return new List<Instrument>();
            }
        }


        public List<Position> GetOpenPositions(string symbol)
        {
            var param = new Dictionary<string, string>();
            string res = Query("GET", "/position", param, true);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(BitMEXAssistant.Properties.Settings.Default.RetryAttemptWaitTime); // Force app to wait 500ms
                res = Query("GET", "/position", param, true);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            try
            {
                return JsonConvert.DeserializeObject<List<Position>>(res).Where(a => a.Symbol == symbol && a.IsOpen == true).OrderByDescending(a => a.TimeStamp).ToList();
            }
            catch (Exception ex)
            {
                return new List<Position>();
            }
        }

        public decimal GetCurrentPrice(string symbol)
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["reverse"] = true.ToString();
            param["count"] = "1";
            string res = Query("GET", "/trade", param, true);
            if(res.Contains("error"))
            {
                return 0;
            }
            else
            {
                return JsonConvert.DeserializeObject<List<Trade>>(res).FirstOrDefault().Price;
            }
            
        }

        // Getting Account Balance
        public decimal GetAccountBalance()
        {
            var param = new Dictionary<string, string>();
            param["currency"] = "XBt";
            string res = Query("GET", "/user/margin", param, true);
            if (res.Contains("error"))
            {
                return -1;
            }
            else
            {
                return Convert.ToDecimal(JsonConvert.DeserializeObject<Margin>(res).UsefulBalance); // useful balance is the balance with full decimal places.
                // default wallet balance doesn't show the decimal places like it should.
            }

        }

        // Get API Key Permissions
        public bool GetAPIKeyPermissions()
        {
            string res = Query("GET", "/apiKey", null, true);
            if (res.Contains("error"))
            {
                return false;
            }
            else
            {
                JArray json = JArray.Parse(res);
                foreach (JObject api_key in json)
                {
                    string key = api_key.GetValue("id").ToString();
                    if (key == this.apiKey)
                    {
                        JToken permissions = api_key.GetValue("permissions");
                        foreach (JToken permission in permissions)
                        {
                            if (permission.ToString() == "order")
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }

        public List<SimpleCandle> GetCandleHistory(string symbol, string size, DateTime Start = new DateTime())
        {
            var param = new Dictionary<string, string>();
            param["symbol"] = symbol;
            param["count"] = 500.ToString(); // 500 max
            param["reverse"] = "false";
            if (Start != new DateTime())
            {
                param["startTime"] = Start.ToString();
            }
            param["binSize"] = size;
            string res = Query("GET", "/trade/bucketed", param);
            int RetryAttemptCount = 0;
            int MaxRetries = RetryAttempts(res);
            while (res.Contains("error") && RetryAttemptCount < MaxRetries)
            {
                errors.Add(res);
                Thread.Sleep(500); // Force app to wait 500ms
                res = Query("GET", "/trade/bucketed", param);
                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    errors.Add("Max rety attempts of " + MaxRetries.ToString() + " reached.");
                    break;
                }
            }
            try
            {
                return JsonConvert.DeserializeObject<List<SimpleCandle>>(res).OrderBy(a => a.TimeStamp).ToList();
            }
            catch (Exception ex)
            {
                return new List<SimpleCandle>();
            }

        }

        #endregion


        private int RetryAttempts(string res)
        {
            int att = 0;

            if (res.Contains("Unable to cancel order due to existing state"))
            {
                att = 0;
            }
            else if (res.Contains("The system is currently overloaded. Please try again later."))
            {
                if(BitMEXAssistant.Properties.Settings.Default.OverloadRetry)
                {
                    att = BitMEXAssistant.Properties.Settings.Default.OverloadRetryAttempts;
                }
                else
                {
                    att = 0;
                }
            }
            else if (res.Contains("error"))
            {
                att = 0;
            }

            return att;
        }



        #region RateLimiter

        private long lastTicks = 0;
        private object thisLock = new object();

        private void RateLimit()
        {
            lock (thisLock)
            {
                long elapsedTicks = DateTime.Now.Ticks - lastTicks;
                var timespan = new TimeSpan(elapsedTicks);
                if (timespan.TotalMilliseconds < rateLimit)
                    Thread.Sleep(rateLimit - (int)timespan.TotalMilliseconds);
                lastTicks = DateTime.Now.Ticks;
            }
        }

        #endregion RateLimiter
    }

    // Working Classes
    public class Margin // For account balance
    {
        public double? WalletBalance { get; set; }
        public double? AvailableMargin { get; set; }
        public double? UsefulBalance
        {
            get { return (WalletBalance / 100000000) ?? 0; }
        }
    }

    public class OrderBook
    {
        public string Side { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
    }

    public class Instrument
    {
        public string Symbol { get; set; }
        public decimal TickSize { get; set; }
        public double Volume24H { get; set; }
        public int DecimalPlacesInTickSize
        {
            get { return BitConverter.GetBytes(decimal.GetBits(TickSize)[3])[2]; }
        }
    }

    public class Candle
    {
        public DateTime TimeStamp { get; set; }
        public double? Open { get; set; }
        public double? Close { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Volume { get; set; }
        public int Trades { get; set; }
        public int PCC { get; set; }
        public double? MA1 { get; set; }
        public double? MA2 { get; set; }

        public double? PVT { get; set; } // NEW - for PVT

        public double? STOCHK { get; set; }
        public double? STOCHD { get; set; }

        public double? TypicalPrice
        {
            get { return ((High + Low + Close) / 3) ?? 0; } // 0 if null
        }//  For MFI
        public double? RawMoneyFlow
        {
            get { return (TypicalPrice * Volume) ?? 0; } // 0 if null
        }//  For MFI
        public double? MoneyFlowRatio { get; set; } //  For MFI
        public double? MoneyFlowChange { get; set; } //  For MFI // This gets set to the TypicalPrice of this candle, to the TypicalPrice of the previous candle
        public double? MFI { get; set; } //  For MFI

        public double? BBUpper { get; set; }
        public double? BBMiddle { get; set; }
        public double? BBLower { get; set; }
        public double? EMA1 { get; set; }
        public double? EMA2 { get; set; }
        public double? EMA3 { get; set; }
        public double? MACDLine { get; set; }
        public double? MACDSignalLine { get; set; }
        public double? MACDHistorgram { get; set; }
        public double? TR { get; set; }
        public double? ATR1 { get; set; }
        public double? ATR2 { get; set; }
        public double? GainOrLoss // For RSI
        {
            get { return (Close - Open) ?? 0; } // 0 if null
        }
        public double? RS { get; set; } // For RSI
        public double? RSI { get; set; } // For RSI
        public double? AVGGain { get; set; } // For RSI
        public double? AVGLoss { get; set; } // For RSI




        public void SetMoneyFlowChange(double? PreviousTypicalPrice) // NEW - For MFI
        {
            MoneyFlowChange = TypicalPrice - PreviousTypicalPrice;
        }

        public void SetTR(double? PreviousClose)
        {
            List<double?> TRs = new List<double?>();

            TRs.Add(High - Low);
            TRs.Add(Convert.ToDouble(Math.Abs(Convert.ToDecimal(High - PreviousClose))));
            TRs.Add(Convert.ToDouble(Math.Abs(Convert.ToDecimal(Low - PreviousClose))));

            TR = TRs.Max();
        }

        
    }

    public class Position
    {
        public DateTime TimeStamp { get; set; }
        public decimal? Leverage { get; set; }
        public int? CurrentQty { get; set; }
        public decimal? CurrentCost { get; set; }
        public bool IsOpen { get; set; }
        public decimal? MarkPrice { get; set; }
        public decimal? MarkValue { get; set; }
        public decimal? UnrealisedPnl { get; set; }
        public decimal? UnrealisedPnlPcnt { get; set; }
        public decimal? UnrealisedRoePcnt { get; set; }
        public decimal? AvgEntryPrice { get; set; }
        public decimal? BreakEvenPrice { get; set; }
        public decimal? LiquidationPrice { get; set; }
        public decimal? RealizedPnl { get; set; }
        public decimal? HighestPriceSinceOpen { get; set; }
        public decimal? LowestPriceSinceOpen { get; set; }
        public decimal? TrailingStopPrice { get; set; }

        public string Symbol { get; set; }

        public decimal? UsefulUnrealisedPnl
        {
            get
            {
                if(UnrealisedPnl!= null)
                {
                    return Math.Round(((decimal)UnrealisedPnl / 100000000), 4);
                }
                else
                {
                    return 0;
                }
            }
        }
    }

    public class Order
    {
        public DateTime TimeStamp { get; set; }
        public string Symbol { get; set; }
        public string OrdStatus { get; set; }
        public string OrdType { get; set; }
        public string OrderId { get; set; }
        public string Side { get; set; }
        public double? Price { get; set; }
        public int? OrderQty { get; set; }
        public int? DisplayQty { get; set; }
        public string ExecInst { get; set; }
    }

    public class Trade
    {
        public decimal Price { get; set; }
    }

    public class SimpleCandle
    {
        public DateTime TimeStamp { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Volume { get; set; }
        public int Trades { get; set; }
       
    }
}
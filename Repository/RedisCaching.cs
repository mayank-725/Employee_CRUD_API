using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RedisCaching
    {
        public void RedisConnection(string key, string value)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            data.StringSet(key, value);
            data.StringGet(key);
        } 

        public string  RedisConnection(string key)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            //data.StringSet(key, value);
           var result= data.StringGet(key);
            return result;
        }
    }
}

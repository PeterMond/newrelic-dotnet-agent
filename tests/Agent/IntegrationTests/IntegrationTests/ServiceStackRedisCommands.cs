/*
* Copyright 2020 New Relic Corporation. All rights reserved.
* SPDX-License-Identifier: Apache-2.0
*/

namespace NewRelic.Agent.IntegrationTests
{
    public class ServiceStackRedisCommands
    {
        public const string SaveAsync = "BGSAVE";
        public const string Shutdown = "SHUTDOWN";
        public const string RewriteAppendOnlyFileAsync = "BGREWRITEAOF";
        public const string FlushDb = "FLUSHDB";
        public const string SetClientName = "SET";
        public const string GetAllKeys = "KEYS";
        public const string SetEntry = "SET";
        public const string SetEntryExpireIn = "SETEX";
        public const string SetEntryIfNotExists = "SET";
        public const string SetAll = "MSET";
        public const string SetAllKeyValueDictionary = "MSET";
        public const string GetEntry = "GET";
        public const string GetValue = "GET";
        public const string GetAndSetEntry = "GETSET";
        public const string GetValues = "MGET";
        public const string GetValuesObject = "MGET";
        public const string GetValuesMap = "MGET";
        public const string GetValuesMapObject = "MGET";
        public const string AppendToValue = "APPEND";
        public const string RenameKey = "RENAME";
        public const string GetFromHash = "HGETALL";
        public const string StoreAsHash = "SADD";
        public const string StoreObject = "SET";
        public const string ContainsKey = "EXISTS";
        public const string RemoveEntry = "DEL";
        public const string IncrementValue = "INCR";
        public const string IncrementValueBy = "INCRBY";
        public const string IncrementValueByDouble = "INCRBYFLOAT";
        public const string IncrementValueByFloat = "INCRBYFLOAT";
        public const string DecrementValue = "DECR";
        public const string DecrementValueBy = "DECRBY";
        public const string SearchKeys = "KEYS";
        public const string GetEntryType = "TYPE";
        public const string GetRandomKey = "RANDOMKEY";
        public const string ExpireEntryIn = "EXPIRE";
        public const string ExpireEntryAt = "EXPIREAT";
        public const string GetTimeToLive = "TTL";
        public const string GetSortedEntryValues = "SORT";
        public const string WriteAll = "MSET";
        public const string ScanAllSetItems = "SADD";
        public const string ScanAllSortedSetItems = "SADD";
        public const string ScanAllHashEntries = "HMSET";
        public const string AddToHyperLog = "PFADD";
        public const string CountHyperLog = "PFCOUNT";
        public const string MergeHyperLogs = "PFMERGE";
        public const string AcquireLock = "SET";
        public const string AcquireLockExpireIn = "SET";
        public const string Watch = "WATCH";
        public const string UnWatch = "UNWATCH";
        public const string PublishMessage = "PUBLISH";
        public const string GetAllItemsFromSet = "SMEMBERS";
        public const string AddItemToSet = "SADD";
        public const string RemoveItemFromSet = "SREM";
        public const string PopItemFromSet = "SPOP";
        public const string MoveBetweenSets = "SMOVE";
        public const string GetSetCount = "SCARD";
        public const string SetContainsItem = "SISMEMBER";
        public const string GetIntersectFromSets = "SINTER";
        public const string StoreIntersectFromSets = "SINTERSTORE";
        public const string GetUnionFromSets = "SUNION";
        public const string StoreUnionFromSets = "SUNIONSTORE";
        public const string GetDifferencesFromSet = "SDIFF";
        public const string StoreDifferencesFromSet = "SDIFFSTORE";
        public const string GetRandomItemFromSet = "SRANDMEMBER";
        public const string GetAllItemsFromList = "LRANGE";
        public const string GetRangeFromList = "LRANGE";
        public const string GetRangeFromSortedList = "SORT";
        public const string GetSortedItemsFromList = "SORT";
        public const string AddItemToList = "RPUSH";
        public const string PrependItemToList = "LPUSH";
        public const string RemoveAllFromList = "LTRIM";
        public const string RemoveStartFromList = "LPOP";
        public const string BlockingRemoveStartFromList = "BLPOP";
        public const string BlockingRemoveStartFromLists = "BLPOP";
        public const string RemoveEndFromList = "RPOP";
        public const string TrimList = "LTRIM";
        public const string RemoveItemFromList = "LREM";
        public const string RemoveItemFromListWithValueCountParams = "LREM";
        public const string GetListCount = "LLEN";
        public const string GetItemFromList = "LINDEX";
        public const string SetItemInList = "LSET";
        public const string EnqueueItemOnList = "LPUSH";
        public const string DequeueItemFromList = "RPOP";
        public const string BlockingDequeueItemFromList = "BRPOP";
        public const string BlockingDequeueItemFromLists = "BRPOP";
        public const string PushItemToList = "RPUSH";
        public const string PopItemFromList = "RPOP";
        public const string BlockingPopItemFromList = "BRPOP";
        public const string BlockingPopItemFromLists = "BRPOP";
        public const string PopAndPushItemBetweenLists = "RPOPLPUSH";
        public const string BlockingPopAndPushItemBetweenLists = "BRPOPLPUSH";
        public const string AddItemToSortedSet = "ZADD";
        public const string AddItemToSortedSetWithScore = "ZADD";
        public const string RemoveItemFromSortedSet = "ZREM";
        public const string PopItemWithLowestScoreFromSortedSet = "ZRANGE";
        public const string PopItemWithHighestScoreFromSortedSet = "ZREVRANGE";
        public const string SortedSetContainsItem = "ZRANK";
        public const string IncrementItemInSortedSetDouble = "ZINCRBY";
        public const string IncrementItemInSortedSetLong = "ZINCRBY";
        public const string GetItemIndexInSortedSet = "ZRANK";
        public const string GetItemIndexInSortedSetDesc = "ZREVRANK";
        public const string GetAllItemsFromSortedSet = "ZRANGE";
        public const string GetAllItemsFromSortedSetDesc = "ZREVRANGE";
        public const string GetRangeFromSortedSet = "ZRANGE";
        public const string GetRangeFromSortedSetDesc = "ZREVRANGE";
        public const string GetAllWithScoresFromSortedSet = "ZRANGE";
        public const string GetRangeWithScoresFromSortedSet = "ZRANGE";
        public const string GetRangeWithScoresFromSortedSetDesc = "ZREVRANGE";
        public const string GetRangeFromSortedSetByLowestScoreWithStringScores = "ZRANGEBYSCORE";
        public const string GetRangeFromSortedSetByLowestScoreWithStringScoresAndSkipTake = "ZRANGEBYSCORE";
        public const string GetRangeFromSortedSetByLowestScoreWithDoubles = "ZRANGEBYSCORE";
        public const string GetRangeFromSortedSetByLowestScoreWithLongs = "ZRANGEBYSCORE";
        public const string GetRangeFromSortedSetByLowestScoreWithDoublesAndSkipTake = "ZRANGEBYSCORE";
        public const string GetRangeFromSortedSetByLowestScoreWithLongsAndSkipTake = "ZRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByLowestScoreWithStringScores = "ZRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByLowestScoreWithStringScoresAndSkipTake = "ZRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByLowestScoreWithDoubles = "ZRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByLowestScoreWithLongs = "ZRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByLowestScoreWithDoublesAndSkipTake = "ZRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByLowestScoreWithLongsAndSkipTake = "ZRANGEBYSCORE";
        public const string GetRangeFromSortedSetByHighestScoreWithStringScores = "ZREVRANGEBYSCORE";
        public const string GetRangeFromSortedSetByHighestScoreWithStringScoresAndSkipTake = "ZREVRANGEBYSCORE";
        public const string GetRangeFromSortedSetByHighestScoreWithDoubles = "ZREVRANGEBYSCORE";
        public const string GetRangeFromSortedSetByHighestScoreWithLongs = "ZREVRANGEBYSCORE";
        public const string GetRangeFromSortedSetByHighestScoreWithDoublesAndSkipTake = "ZREVRANGEBYSCORE";
        public const string GetRangeFromSortedSetByHighestScoreWithLongsAndSkipTake = "ZREVRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByHighestScoreWithStringScores = "ZREVRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByHighestScoreWithStringScoresAndSkipTake = "ZREVRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByHighestScoreWithDoubles = "ZREVRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByHighestScoreWithLongs = "ZREVRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByHighestScoreWithDoublesAndSkipTake = "ZREVRANGEBYSCORE";
        public const string GetRangeWithScoresFromSortedSetByHighestScoreWithLongsAndSkipTake = "ZREVRANGEBYSCORE";
        public const string RemoveRangeFromSortedSet = "ZREMRANGEBYRANK";
        public const string RemoveRangeFromSortedSetByScoreDouble = "ZREMRANGEBYSCORE";
        public const string RemoveRangeFromSortedSetByScoreLong = "ZREMRANGEBYSCORE";
        public const string GetSortedSetCount = "ZCARD";
        public const string GetSortedSetCountWithStringScores = "ZCOUNT";
        public const string GetSortedSetCountWithDoubles = "ZCOUNT";
        public const string GetSortedSetCountWithLongs = "ZCOUNT";
        public const string GetItemScoreInSortedSet = "ZSCORE";
        public const string StoreIntersectFromSortedSets = "ZINTERSTORE";
        public const string StoreIntersectFromSortedSetsWithParams = "ZINTERSTORE";
        public const string StoreUnionFromSortedSets = "ZUNIONSTORE";
        public const string SearchSortedSet = "ZRANGEBYLEX";
        public const string SearchSortedSetCount = "ZLEXCOUNT";
        public const string RemoveRangeFromSortedSetBySearch = "ZREMRANGEBYLEX";
        public const string HashContainsEntry = "HEXISTS";
        public const string SetEntryInHash = "HSET";
        public const string SetEntryInHashIfNotExists = "HSETNX";
        public const string SetRangeInHash = "HMSET";
        public const string IncrementValueInHashDouble = "HINCRBYFLOAT";
        public const string IncrementValueInHashInt = "HINCRBY";
        public const string GetValueFromHash = "HGET";
        public const string GetValuesFromHash = "HMGET";
        public const string RemoveEntryFromHash = "HDEL";
        public const string GetHashCount = "HLEN";
        public const string GetHashKeys = "HKEYS";
        public const string GetHashValues = "HVALS";
        public const string GetAllEntriesFromHash = "HGETALL";
        public const string ExecLuaAsString = "EVAL";
        public const string ExecLuaAsStringWithKeys = "EVALSHA";
        public const string ExecLuaShaAsString = "EVAL";
        public const string ExecLuaShaAsStringWithKeys = "EVALSHA";
        public const string ExecLuaAsInt = "EVAL";
        public const string ExecLuaAsIntWithKeys = "EVAL";
        public const string ExecLuaShaAsInt = "EVALSHA";
        public const string ExecLuaShaAsIntWithKeys = "EVALSHA";
        public const string ExecLuaAsList = "EVAL";
        public const string ExecLuaAsListWithKeys = "EVAL";
        public const string ExecLuaShaAsList = "EVALSHA";
        public const string ExecLuaShaAsListWithKeys = "EVALSHA";
        public const string HasLuaScript = "SCRIPT";
        public const string WhichLuaScriptsExists = "SCRIPT";
        public const string RemoveAllLuaScripts = "SCRIPT";
        public const string KillRunningLuaScript = "SCRIPT";
        public const string LoadLuaScript = "SCRIPT";
    }
}

using System;
using System.Collections.Generic;

namespace chain_of_responsability.Services.Abstract
{
    public class DataService
    {
        private Dictionary<string, string> _Map;
        private DataService()
        {
            _Map = new Dictionary<string, string>();
        }
        private static DataService Instance { get; set; }

        public static DataService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DataService();
            }
            return Instance;
        }

        public void Add(string key, string value)
        {
            Console.WriteLine(string.Format("Adding to map: key<{0}>, value<{1}>", key, value));
            this._Map.Add(key, value);
        }

        public Dictionary<string, string> Map {
            get
            {
                Console.WriteLine("Getting map...");
                return _Map;
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class UserResultRepository
    {
        public static string Path = "results.json";
        public static void SaveResults(User user)
        {
            var users = GetAll();
            users.Add(user);
            Save(users);
            
        }

        public static List<User> GetAll()
        {
           if (!FileOperation.Exists(Path))
            {
                return new List<User>();
            }
                      
            var allResults = FileOperation.Get(Path);
            var results = JsonConvert.DeserializeObject<List<User>>(allResults);
            return results;
        }

        static void Save(List<User> users)
        {
            var jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            FileOperation.Replace(Path, jsonData);
        }
    }
}

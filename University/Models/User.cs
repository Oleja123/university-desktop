using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
        [JsonPropertyName("role")]
        public string Role { get; set; }

        public User(int id, string username, string fullName, string role)
        {
            Id = id;
            Username = username;
            FullName = fullName;
            Role = role;
        }
    }
}

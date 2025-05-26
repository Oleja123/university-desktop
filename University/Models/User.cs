using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        [JsonPropertyName("id")]
        [DisplayName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("username")]
        [DisplayName("Имя пользователя")]
        public string Username { get; set; }
        [JsonPropertyName("full_name")]
        [DisplayName("ФИО")]
        public string FullName { get; set; }
        [JsonPropertyName("role")]
        [DisplayName("Роль")]
        public string Role { get; set; }
        [JsonPropertyName("token_available")]
        [DisplayName("Токен активен")]
        public bool TokenAvailable { get; set; }

        public User(int id, string username, string fullName, string role, bool tokenAvailable)
        {
            Id = id;
            Username = username;
            FullName = fullName;
            Role = role;
            TokenAvailable = tokenAvailable;
        }
    }
}


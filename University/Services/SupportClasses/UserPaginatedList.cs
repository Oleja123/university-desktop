using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services.SupportClasses
{
    public class UserPaginatedList
    {
        public List<User>? Users { get; set; }
        public int? Page { get; set; }
        public int? NextPage { get; set; }
        public int? PrevPage { get; set; }

        public UserPaginatedList(List<User> users, int page, int nextPage, int prevPage)
        {
            Users = users;
            Page = page;
            NextPage = nextPage;
            PrevPage = prevPage;
        }

        public UserPaginatedList()
        {

        }

        public static UserPaginatedList Deserealise(String json)
        {
            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            UserPaginatedList cur = new UserPaginatedList();
            cur.Users = JsonSerializer.Deserialize<List<User>>(root.GetProperty("items"));
            cur.Page = JsonSerializer.Deserialize<int>(root.GetProperty("_meta").GetProperty("page").ToString()!);
            int totalPages = JsonSerializer.Deserialize<int>(root.GetProperty("_meta").GetProperty("total_pages").ToString()!);
            if (cur.Page != totalPages)
            {
                cur.NextPage = cur.Page + 1;
            }
            else
            {
                cur.NextPage = 1;
            }

            if (cur.Page != 1)
            {
                cur.PrevPage = cur.Page - 1;
            }
            else
            {
                cur.PrevPage = totalPages;
            }

            return cur;
        }
    }
}

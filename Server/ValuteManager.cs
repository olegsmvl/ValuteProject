using ModelCourse;
using System.Net.Http;
using System.Text.Json;

namespace Server
{
    public class ValuteManager
    {
        public bool Enabled { get; private set; }
        public Course GetCourse()
        {
            Enabled = false;

            if (!Enabled) return null;

            var client = new HttpClient();
            var response = client.GetAsync("https://www.cbr-xml-daily.ru/daily_json.js").Result;
            response.EnsureSuccessStatusCode();
            string body = response.Content.ReadAsStringAsync().Result;
            var data = JsonSerializer.Deserialize<Course>(body);
            return data;
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Sample.Pages
{
    public class Player : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
//public class Player {
//    public int id { get; set; }
//    public string name { get; set; }
//    public string commonName { get; set; }
//    public int league { get; set; }
//    public int nation { get; set; }
//    public int club { get; set; }
//    public int rarity { get; set; }
//    public string position { get; set; }
//    public int rating { get; set; }
//    public int pace { get; set; }
//    public int shooting { get; set; }
//    public int passing { get; set; }
//    public int dribbling { get; set; }
//    public int defending { get; set; }
//    public int physicality { get; set; }
//    public int diving { get; set; }
//    public int handling { get; set; }
//    public int kicking { get; set; }
//    public int positioning { get; set; }
//    public int reflexes { get; set; }
//    public int speed { get; set; }

//    public void insert_into_database() {
//        string clean_name = name.Replace("'", "''");
//        string clean_commonName = commonName.Replace("'", "''");
//        string sql;
//        if (position == "GK") {
//            sql = $"INSERT INTO [PacksOpening].[dbo].[Players] VALUES({id},'{clean_name}','{clean_commonName}',{league},{nation},{club},{rarity},'{position}',{rating},{diving},{handling},{kicking},{positioning},{reflexes},{speed})";
//        }
//        else {
//            sql = $"INSERT INTO [PacksOpening].[dbo].[Players] VALUES({id},'{clean_name}','{clean_commonName}',{league},{nation},{club},{rarity},'{position}',{rating},{pace},{shooting},{passing},{dribbling},{defending},{physicality})";
//        }

//        Debug.WriteLine(sql);
//        connection.query(sql);
//    }
//}



// insert data into database
//var players = new List<Player>();
//using (StreamReader r = new StreamReader("Data/player_database.json")) {
//    string json = r.ReadToEnd();
//    players = JsonSerializer.Deserialize<List<Player>>(json);
//}
//foreach (var player in players)
//{
//    player.insert_into_database();
//}
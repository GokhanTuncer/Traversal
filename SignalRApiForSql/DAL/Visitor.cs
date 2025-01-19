namespace SignalRApiForSql.DAL
{

    public enum ECity
    {
        Istanbul = 1,
        Ankara = 2,
        Izmir = 3,
        Bursa = 4,
        Antalya = 5
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }

}

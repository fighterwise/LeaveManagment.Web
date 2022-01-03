namespace LeaveManagment.Web.Data
{
    public class LeaveType : BaseEntity
    {
       //გადავიტანეთ მშობელ კლასში public int Id { get; set; }
       // ეს იქნება პირველი სვეტი

       public string Name { get; set; }
        //ეს იქნება მეორე სვეტი

       public int DefaultDays { get; set; }
        //ეს კი არის რამდენი შვებულების დღე აქვს დარჩენილი

       // მშობელშია public DateTime DateCreated { get; set; }
        //ვაკეთებთ ტრეკინგს როდის შეიქმნა ეს სვეტი

        //მშობელშია public DateTime DateModified { get; set; }
        //ვაკეთებთ ტრეკინს როდის მოხდა მოდიფიცირება შეცვლა ამ სვეტის.


    }
}

namespace Core_Demo.Models
{
    public class AddProfileImage
    {
        //Entity katmanındaki entitymizi etkilemesin diye ayrı bir model oluşturduk.
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; } //dosyadan bir dosya seçebilmek için kullanırız. 
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}

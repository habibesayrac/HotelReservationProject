namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class ResultBookingDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        
        public string Status { get; set; }
    }
}
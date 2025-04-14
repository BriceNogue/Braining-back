namespace Domain.Entities
{
    public class User : _BaseEntity
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Phone_number { get; set; } = string.Empty;
        public string Email_address { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public long Role_id { get; set; }
    }
}

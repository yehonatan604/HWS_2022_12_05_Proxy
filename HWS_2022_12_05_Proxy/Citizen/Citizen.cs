using System.Text.Json;

namespace HWS_2022_12_05_Proxy
{
    public class Citizen
    {
        [NonSerialized]
        public DateTime? _passPortValidThrough;

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }

        public DateTime? PassPortCreated { get; set; }
        public DateTime? PassPortValidThrough
        {
            get => _passPortValidThrough;
            set
            {
                if (PassPortCreated == null)
                {
                    _passPortValidThrough = null;
                }
                else
                {
                    _passPortValidThrough = value;
                }
            }
        }

        public Citizen(string? firstName, string? lastName, string? address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public override string ToString()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, options);
        }
    }
}

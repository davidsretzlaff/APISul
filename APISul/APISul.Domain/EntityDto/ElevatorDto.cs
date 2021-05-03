using Newtonsoft.Json;

namespace APISul.Domain.EntityDto
{
    public class ElevatorDto
    {
        [JsonIgnore]
        public string andar { get; set; }
        public string elevador { get; set; }
        public string turno { get; set; }
    }
}
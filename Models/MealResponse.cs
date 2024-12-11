using System.Collections.Generic;
using System.Text.Json.Serialization;

public class MealResponse
{
    [JsonPropertyName("meals")]
    public List<Meal>? Meals { get; set; }
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
public class ActivitiesForFL
{
    public string Name { get; set; }
}

public class ActivitiesForKY
{
    public string Name { get; set; }
}

public class Root
{
    [JsonProperty("State Option 1")]
    public string StateOption1 { get; set; }

    [JsonProperty("Activities For KY")]
    public List<ActivitiesForKY> ActivitiesForKY { get; set; }

    [JsonProperty("State Option 2")]
    public string StateOption2 { get; set; }

    [JsonProperty("Activities for FL")]
    public List<ActivitiesForFL> ActivitiesForFL { get; set; }
}


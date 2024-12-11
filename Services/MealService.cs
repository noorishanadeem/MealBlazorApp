using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class MealService
{
    private readonly HttpClient _httpClient;

    public MealService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<MealResponse?> SearchMealByName(string mealName)
    {
        return await _httpClient.GetFromJsonAsync<MealResponse>($"https://www.themealdb.com/api/json/v1/1/search.php?s={mealName}");
    }

    public async Task<MealResponse?> SearchMealByFirstLetter(char letter)
    {
        return await _httpClient.GetFromJsonAsync<MealResponse>($"https://www.themealdb.com/api/json/v1/1/search.php?f={letter}");
    }

    public async Task<CategoryResponse?> GetCategories()
    {
        return await _httpClient.GetFromJsonAsync<CategoryResponse>("https://www.themealdb.com/api/json/v1/1/categories.php");
    }

    public async Task<MealResponse?> GetMealById(string mealId)
    {
        return await _httpClient.GetFromJsonAsync<MealResponse>($"https://www.themealdb.com/api/json/v1/1/lookup.php?i={mealId}");
    }

}

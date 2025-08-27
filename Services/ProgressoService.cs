using Microsoft.JSInterop;

namespace Biblia.Services;

public class ProgressoService
{
    private readonly IJSRuntime _js;

    public ProgressoService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task<Dictionary<string, List<int>>> CarregarAsync()
    {
        var json = await _js.InvokeAsync<string>("localStorage.getItem", "progresso");
        if (string.IsNullOrEmpty(json)) return new();
        return System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, List<int>>>(json) ?? new();
    }

    public async Task SalvarAsync(Dictionary<string, List<int>> progresso)
    {
        var json = System.Text.Json.JsonSerializer.Serialize(progresso);
        await _js.InvokeVoidAsync("localStorage.setItem", "progresso", json);
    }
}
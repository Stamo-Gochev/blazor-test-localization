



namespace CustomRazorComponents.Localization
{
    public interface ICustomLocalizer
    {
        string GetString(string key);
        string this[string name] { get; }
    }
}

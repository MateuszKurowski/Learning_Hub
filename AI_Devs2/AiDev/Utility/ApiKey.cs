namespace AI_Devs2.Utility;
internal class ApiKey
{
    private static readonly string _applicationFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AI_Devs2");
    private static readonly string _apiKeyPath = Path.Combine(_applicationFolderPath, "ApiKey");

    public static void SaveKey(string key)
    {
        if (string.IsNullOrWhiteSpace(key))
            return;

        try
        {
            if (Directory.Exists(_applicationFolderPath) == false) 
            {
                CreateApplicationFolder();
            }

            File.WriteAllText(_apiKeyPath, key);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Wystąpił błąd podczas zapisywania klucza API:\r\n {ex.Message}", "Błąd klucza API");
        }
    }

    public static void RemoveKey()
    {
        try
        {
            if (Directory.Exists(_applicationFolderPath) == false)
            {
                CreateApplicationFolder();
                return;
            }

            if (File.Exists(_apiKeyPath))
            {
                File.Delete(_apiKeyPath);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Wystąpił błąd podczas usuwania klucza API:\r\n {ex.Message}", "Błąd klucza API");
        }
    }

    public static string GetKey()
    {
        string apiKey = string.Empty;

        try
        {
            if (Directory.Exists(_applicationFolderPath) == false) 
            {
                CreateApplicationFolder();
                return apiKey;
            }

            if (File.Exists(_apiKeyPath))
            {
                apiKey = File.ReadAllText(_apiKeyPath);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Wystąpił błąd podczas odczytu klucza API:\r\n {ex.Message}", "Błąd klucza API");
        }

        return apiKey;
    }

    private static void CreateApplicationFolder()
    {
        Directory.CreateDirectory(_applicationFolderPath);
    }
}

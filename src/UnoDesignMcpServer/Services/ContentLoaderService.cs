namespace UnoDesignMcpServer.Services;

/// <summary>
/// Service for loading markdown documentation files.
/// </summary>
public class ContentLoaderService
{
    private readonly string _basePath;

    public ContentLoaderService()
    {
        _basePath = AppContext.BaseDirectory;
    }

    /// <summary>
    /// Loads markdown content from a file relative to the application base directory.
    /// </summary>
    /// <param name="relativePath">The relative path to the markdown file.</param>
    /// <returns>The content of the file, or an error message if not found.</returns>
    public string LoadMarkdown(string relativePath)
    {
        var fullPath = Path.Combine(_basePath, relativePath);

        if (File.Exists(fullPath))
        {
            return File.ReadAllText(fullPath);
        }

        return $"Documentation not found: {relativePath}";
    }

    /// <summary>
    /// Loads markdown content from the docs directory.
    /// </summary>
    public string LoadDocs(string subPath) => LoadMarkdown(Path.Combine("docs", subPath));

    /// <summary>
    /// Loads markdown content from the resources directory.
    /// </summary>
    public string LoadResources(string subPath) => LoadMarkdown(Path.Combine("resources", subPath));
}

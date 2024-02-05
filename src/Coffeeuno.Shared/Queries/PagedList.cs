namespace Coffeeuno.Shared.Queries;

public class PagedList<T>
{
    public IReadOnlyList<T> Items { get; private set; } = new List<T>();
    public int CurrentPage { get; private set; }
    public int ResultsPerPage { get; private set; }
    public int TotalResults { get; private set; }
    public int TotalPages { get; private set; }

    public bool IsEmpty => !Items.Any();
    
    public PagedList()
    {
        CurrentPage = 1;
        ResultsPerPage = 20;
        TotalResults = 0;
        TotalPages = 1;
    }

    public PagedList(IReadOnlyList<T> items, int currentPage,
        int resultsPerPage, int totalResults, int totalPages)
    {
        Items = items;
        CurrentPage = currentPage;
        ResultsPerPage = resultsPerPage;
        TotalResults = totalResults;
        TotalPages = totalPages;
    }

    public static PagedList<T> Create(
        IReadOnlyList<T> items, int currentPage, 
        int resultsPerPage, int totalResults, int totalPages) 
            => new(items, currentPage, resultsPerPage, totalResults, totalPages);
}
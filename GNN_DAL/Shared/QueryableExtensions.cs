using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Shared
{
    public static class QueryableExtensions
    {
        public static async Task<PaginatedResult<T>> ToPaginatedListAsync<T>
            (this IQueryable<T> source,
            int pageNumber,
            int pageSize,
            CancellationToken cancellationToken = default)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            pageSize = pageSize <= 0 ? 10 : pageSize;

            var count = await source.CountAsync(cancellationToken);

            var items = await source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);

            return new PaginatedResult<T>(items, pageNumber, pageSize, count);
        }

        public static PaginatedResult<T> ToPaginatedList<T>(
      this IEnumerable<T> source,
      int pageNumber,
      int pageSize)
        {
            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            pageSize = pageSize <= 0 ? 10 : pageSize;

            var count = source.Count();
            var items = source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PaginatedResult<T>(items, pageNumber, pageSize, count);
        }
    }
}

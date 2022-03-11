using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace NgrokApi
{
    public interface HasId
    {
        string Id { get; }
    }

    public class Iterator<T> : IAsyncEnumerable<T> where T : HasId
    {
        private Func<string, Task<List<T>>> fetchNextPage;
        private string lastId;

        public Iterator(string lastId, Func<string, Task<List<T>>> fetchNextPage)
        {
            this.lastId = lastId;
            this.fetchNextPage = fetchNextPage;
        }

        public async IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken token)
        {
            List<T> items = null;
            int index = -1;
            while (true)
            {
                index = index + 1;
                if (items != null && index < items.Count())
                {
                    this.lastId = items[index - 1].Id;
                    yield return items[index - 1];
                }
                else
                {
                    // fetch next page
                    var nextItems = await fetchNextPage(this.lastId ?? "");
                    if (nextItems.Count() == 0)
                    {
                        break;
                    }
                    else
                    {
                        items = nextItems;
                        index = 0;
                        this.lastId = items[0].Id;
                        yield return items[0];
                    }
                }
            }
        }
    }
}

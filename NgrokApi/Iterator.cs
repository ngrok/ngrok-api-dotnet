using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime;
using System.Linq;
using Newtonsoft.Json;

namespace NgrokApi
{
    public interface HasId
    {
        string Id { get; }
    }

    public class Iterator<T> : IDisposable, IEnumerable<T>, IEnumerator<T> where T : HasId
    {
        private List<T> items;
        private int index = -1;
        private Func<string, Task<List<T>>> fetchNextPage;
        private string lastId;

        public Iterator(string lastId, Func<string, Task<List<T>>> fetchNextPage)
        {
            this.lastId = lastId;
            this.fetchNextPage = fetchNextPage;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            index = index + 1;
            if (items != null && index < items.Count())
            {
                this.lastId = items[index - 1].Id;
                return true;
            }
            else
            {
                // fetch next page
                var nextItems = Task.Run<List<T>>(async () => await fetchNextPage(lastId ?? "")).Result;
                if (nextItems.Count() == 0)
                {
                    return false;
                }
                else
                {
                    this.items = nextItems;
                    this.index = 0;
                    this.lastId = items[0].Id;
                }
            }
            return true;
        }

        public void Reset()
        {
            items = null;
            index = -1;
        }

        public T Current
        {
            get { return items[index]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        void IDisposable.Dispose() { }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuery
{
    public interface ISimpleQueryable<TSource> : IEnumerable<TSource>
    {
        string QueryDescription { get; }
        ISimpleQueryable<TSource> CreateNewQueryable(string quetDescription);
        TResult Execute<TResult>();
    }

    public static class SimpleQueryableExtension
    {
        public static ISimpleQueryable<TSource> where<TSource>(this ISimpleQueryable<TSource> quaryable,
            Expression<Func<TSource, bool>> predicate)
        {
            string newQueryDescription = quaryable.QueryDescription + ".Where(" + predicate.ToString() + ")";
            return quaryable.CreateNewQueryable(newQueryDescription);
        }

        public static int Count<TSource>(this ISimpleQueryable<TSource> queryable)
        {
            string newQueryDescription = queryable.QueryDescription + ".Count()";
            ISimpleQueryable<TSource> newQueryable = queryable.CreateNewQueryable(newQueryDescription);
            return newQueryable.Execute<int>();
        }
    }

    class FakeSimpleQueryable<TSource> : ISimpleQueryable<TSource>
    {
        private readonly object _dataSource;

        public FakeSimpleQueryable(string queryDescription, object dataSource)
        {
            _dataSource = dataSource;
            QueryDescription = queryDescription;
        }
        public IEnumerator<TSource> GetEnumerator()
        {
            return Execute<IEnumerator<TSource>>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string QueryDescription
        {
            get;
            private set;
        }

        public ISimpleQueryable<TSource> CreateNewQueryable(string queryDescription)
        {
            return new FakeSimpleQueryable<TSource>(queryDescription, _dataSource);
        }

        public TResult Execute<TResult>()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new FakeSimpleQueryable<string>("",null);
            int result = provider.Where(s => s.Contains("substring")).Where(s => s != "some string").Count();
        }
    }
}

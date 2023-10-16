using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Extensions
{
    public static class ModelExtensionMethods
    {
        public static ResultModel<T> ToResultModel<T>(this IEnumerable<T> items)
        {
            var result = new ResultModel<T>
            {
                Items = items,
                IsSuccess = true
            };

            return result;
        }

        public static ResultModel<T> ToErrorModel<T>(this IEnumerable<T> items, string errorMessage)
        {
            var result = new ResultModel<T>
            {
                Errors = new List<string> { errorMessage },
                IsSuccess = false
            };

            return result;
        }

        public static ResultModel<T> ToResultModel<T>(this T item)
        {
            var result = new ResultModel<T>
            {
                Item = item,
                IsSuccess = true
            };

            return result;
        }

        public static ResultModel<T> ToErrorModel<T>(this T item, string errorMessage)
        {
            var result = new ResultModel<T>
            {
                Errors = new List<string> { errorMessage },
                IsSuccess = false
            };

            return result;
        }
    }
}

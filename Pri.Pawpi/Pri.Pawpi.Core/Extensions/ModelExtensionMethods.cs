using Pri.Pawpi.Core.Entities;
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

        public static void MapEntity(this Person person, PersonModel personModel)
        {
            person.FirstName = personModel.FirstName;
            person.LastName = personModel.LastName;
            person.Birth = personModel.Birth;
            person.Address = personModel.Address;
            person.City = personModel.City;
            person.Postal = personModel.Postal;
            person.Phone = personModel.Phone;
            person.Email = personModel.Email;
        }
    }
}

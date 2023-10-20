using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Extensions
{
    public static class ValidationCheckExtensionsMethods
    {
        public static bool CheckIfIdsExist(this IQueryable<BaseEntity> list, IEnumerable<int> idsToCheck)
        {
            if (list.Where(p => idsToCheck.Contains(p.Id)).Count() != idsToCheck.Count())
                return false;
            return true;
        }

        public static bool CheckIdsInput(this IQueryable<BaseEntity> list, IEnumerable<int> idsToCheck)
        {
            var listCount = list.Where(l => idsToCheck.Contains(l.Id)).Count();
            if (idsToCheck.Count() == 0 && listCount == 0)
                return false;
            return true;
        }
    }
}

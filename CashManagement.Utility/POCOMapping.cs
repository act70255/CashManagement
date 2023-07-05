using System;
using System.Linq;
using System.Reflection;

namespace CashManagement.Utility
{
    public static class POCOMapping
    {
        public static T Map<T>(object sourceObject)
        {
            if (sourceObject == null) throw new Exception("Source object is null");
            var instance = Activator.CreateInstance(typeof(T));
            if (instance == null) throw new Exception("Can not create de typeof(T) Instance");
            var sourceType = sourceObject.GetType();
            var targetType = instance.GetType();
            PropertyInfo[] sourceProperties = sourceType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            PropertyInfo[] targetProperties = targetType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var sourceProperty in sourceProperties)
            {
                if (sourceProperty == null) continue;
                var targetProperty = targetProperties.FirstOrDefault(p => p.Name.ToLower() == sourceProperty.Name.ToLower() && p.CanWrite);
                if (targetProperty == null) continue;
                var sourceValue = sourceProperty?.GetValue(sourceObject, null);
                if (sourceProperty?.PropertyType == targetProperty.PropertyType)
                {
                    instance?.GetType()?.GetProperty(sourceProperty.Name)?.SetValue(instance, sourceValue);
                    continue;
                }
                // IEnumerable 處理 以後再補?
                //if ((targetProperty.PropertyType.GetInterfaces().Any(p => p.Name == "IEnumerable`1") 
                //    && targetProperty.PropertyType.FullName.IndexOf("System.String") < 0))
                //{

                //}
            }
            return (T)instance;
        }
    }

}
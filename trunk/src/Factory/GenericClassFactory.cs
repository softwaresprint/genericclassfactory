namespace SoftwareSprint.Helper
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("Gendarme.Rules.Design.Generic", "DoNotDeclareStaticMembersOnGenericTypesRule", Justification = "Will only be used in Unit testing")]
    public class GenericClassFactory<T, TClass>
        where TClass : T
    {
        [SuppressMessage("Microsoft.Design", "CA1000", Justification = "Will only be used in Unit testing")]
        public static Func<object[], T> Dispenser { get; set; }

        public T CreateInstance(params object[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException("args");
            }

            if (Dispenser != null)
            {
                return Dispenser(args);
            }

            return (T)Activator.CreateInstance(typeof(TClass), args);
        }

        public T CreateInstance()
        {
            if (Dispenser != null)
            {
                return Dispenser(new object[] { });
            }

            return (T)Activator.CreateInstance(typeof(TClass), new object[] { });
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace XfbContainer.CommonTypes.Extensions
{
    public static class VerifyTypesExtensions
    {
        private const string ThrowMessage = "An exception was thrown in the class";
        private const string DefaultExceptionClassName = nameof(VerifyTypesExtensions);
        private const string NullReferenceMessage = "Message: reference equals null";
        private const string NotReferenceMessage = "Message: object is not a reference";

        private static (string ParameterName, string ExceptionClassName, string DotOrAdditionMessage) GetParametersFormat(this object @this, string argumentName = null, string className = null, string additionMessage = null)
        {
            var parameterName = argumentName ?? nameof(@this);
            var exceptionClassName = className ?? DefaultExceptionClassName;
            var dotOrAdditionMessage = additionMessage == null ? "." : $". Addition message: {additionMessage}.";

            return (parameterName, exceptionClassName, dotOrAdditionMessage);
        }
        private static void VerifyTrueReference(this object @this, string argumentName = null, string className = null, string additionMessage = null)
        {
            if (@this == null)
            {
                var format = @this.GetParametersFormat(argumentName, className, additionMessage);

                var fullMessage = $"{ThrowMessage}: [{format.ExceptionClassName}]. {NullReferenceMessage}{format.DotOrAdditionMessage}";

                throw new ArgumentNullException(format.ParameterName, fullMessage);
            }
            if (@this.GetType().IsValueType)
            {
                throw new Exception($"{NotReferenceMessage}.");
            }
        }

        public static void VerifyReference<TRef>(this TRef @this, string argumentName = null, string className = null, string additionMessage = null) where TRef : class
        {
            @this.VerifyTrueReference(argumentName, className, additionMessage);
        }
        public static TRef VerifyReferenceAndSet<TRef>(this TRef @this, string argumentName = null, string className = null, string additionMessage = null) where TRef : class
        {
            @this.VerifyReference(argumentName, className, additionMessage);

            return @this;
        }
        public static void VerifyCollectionNotNullOrEmpty<TAny>(this IEnumerable<TAny> @this, string argumentName = null, string className = null, string additionMessage = null)
        {
            @this.VerifyReference(argumentName, className, additionMessage);

            if (!@this.Any())
            {
                var format = @this.GetParametersFormat(argumentName, className, additionMessage);

                throw new InvalidOperationException($"{ThrowMessage}: [{format.ExceptionClassName}]. Collection: [{format.ParameterName}] is empty{format.DotOrAdditionMessage}");
            }
        }
    }
}

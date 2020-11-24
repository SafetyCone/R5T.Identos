using System;


/// <summary>
/// Placed in extended class namespace. Including this library/namespace is enough to indicate a desire for these extension methods.
/// </summary>
namespace Microsoft.AspNetCore.Identity
{
    public static class GuidExtensions
    {
        /// <summary>
        /// Converts a <see cref="Guid"/> identity user ID to a string with the default identity database ID format.
        /// Example: 1e1822fa-0ad4-4442-89f5-abb266f9008d
        /// * Lower-case
        /// </summary>
        public static string ToStringDatabaseIDFormat(this Guid identityUserIdentityValue)
        {
            var databaseIDFormattedString = identityUserIdentityValue.ToString(); // Basically, just the default.
            return databaseIDFormattedString;
        }
    }
}

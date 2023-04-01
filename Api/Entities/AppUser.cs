using Microsoft.AspNetCore.Identity;

namespace Api.Entities
{
    // the type determines the primary key of the users table (string <GUID> by default)
    public class AppUser : IdentityUser<string>
    {
        /*
         * Add any attributes that doesn't exist in the implemented IdentityUser.
         * e.g an address attribute
         */
    }
}

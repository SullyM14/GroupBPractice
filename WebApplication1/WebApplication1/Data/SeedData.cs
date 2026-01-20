using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data
{
    public class SeedData
    {

        //New method to add user roles and dummy user accounts
        //Service Provider allows access to all services in the application
        //User Manager to allow me to create and manage users
        //Role Manager to allow me to create and manage roles
        public static async Task SeedUserRoles(IServiceProvider serviceProvider, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            string[] arrayOfRoles = {"Admin","Student","Guest" }; //Creating the array for all potential roles

            foreach(var role in arrayOfRoles) // Loop through each role in the array
            {
                var roleExists = await roleManager.RoleExistsAsync(role); //Check if that role currently exists

                if(roleExists == false) //If the role does not exists
                {
                    var FinalRole = new IdentityRole(role); //Converting the role string to data type identity role
                    await roleManager.CreateAsync(FinalRole); //Add the final role
                }
            }





        }




    }
}

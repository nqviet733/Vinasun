using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class UserRoleModelImpl : UserRoleModel
    {

        //Create new UserRole
        void UserRoleModel.addUserRole(EntityDiagramContainer container, UserRole userRole)
        {
            try
            {
                container.UserRoles.Add(userRole);
                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a UserRole already exist
        UserRole UserRoleModel.retrieveUserRole(EntityDiagramContainer container, int userRoleId)
        {
            try
            {
                return container.UserRoles.Find(userRoleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all user roles
        IList<UserRole> UserRoleModel.retrieveAllUserRoles(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<UserRole>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a UserRole already exist
        void UserRoleModel.updateUserRole(EntityDiagramContainer container, UserRole userRoleIn)
        {
            try
            {
                var userRole = container.UserRoles.FirstOrDefault(c => c.id == userRoleIn.id);
                userRole.description = userRoleIn.description;
                userRole.permission = userRoleIn.permission;

                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //delete a UserRole already exist
        void UserRoleModel.deleteUserRole(EntityDiagramContainer container, UserRole userRoleIn)
        {
            try
            {
                var ur = (from userRole in container.UserRoles
                                where userRole.id == userRoleIn.id
                                select userRole).FirstOrDefault();
                container.UserRoles.Remove(ur);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

    }
}

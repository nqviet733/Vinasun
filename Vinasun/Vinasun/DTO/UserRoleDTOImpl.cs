using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class UserRoleDTOImpl : UserRoleDTO
    {

        //Create new UserRole
        int UserRoleDTO.addUserRole(EntityDiagramContainer container, UserRole userRole)
        {
            int signal = 0;
            try
            {
                container.UserRoles.Add(userRole);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a UserRole already exist
        UserRole UserRoleDTO.retrieveUserRole(EntityDiagramContainer container, int userRoleId)
        {
            UserRole ur = null;
            try
            {
                ur = container.UserRoles.Find(userRoleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return ur;
        }

        //retrieve all user roles
        IList<UserRole> UserRoleDTO.retrieveAllUserRoles(EntityDiagramContainer container)
        {
            IList<UserRole> urs = null;
            try
            {
                urs = container.Set<UserRole>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (urs == null)
                {
                    urs = new List<UserRole>();
                }
            }
            return urs;
        }

        //update a UserRole already exist
        int UserRoleDTO.updateUserRole(EntityDiagramContainer container, UserRole userRoleIn)
        {
            int signal = 0;
            try
            {
                container.UserRoles.FirstOrDefault(c => c.id == userRoleIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a UserRole already exist
        int UserRoleDTO.deleteUserRole(EntityDiagramContainer container, UserRole userRoleIn)
        {
            int signal = 0;
            try
            {
                var ur = (from userRole in container.UserRoles
                                where userRole.id == userRoleIn.id
                                select userRole).FirstOrDefault();
                container.UserRoles.Remove(ur);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist UserRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}

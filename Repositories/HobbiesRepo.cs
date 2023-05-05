using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Repositories
{
    public class HobbiesRepo
    {

        UserRegistrationEntities userRegistrationEntities = new UserRegistrationEntities();

        //This Method is Used to Retrieve The Details Of Hobbies
        public List<Hobby> GetHobbiesDetails()
        {
            try
            {
                return userRegistrationEntities.Hobbies.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }

        }


        //This Method is Used to Retrieve The Details Of Hobbies By ID Based
        public Hobby GetHobbiesById(int id)
        {
            try
            {
                return userRegistrationEntities.Hobbies.Where(a => a.HobbiesId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                return null;
            }


        }


        //This Method is Used to Save Details Of Hobbies 
        public bool SaveHobbies(Hobby hobby)
        {
            try
            {
                userRegistrationEntities.Hobbies.Add(hobby);
                userRegistrationEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }



        //This Method is Used to Update the Existing Details  Of Hobbies 
        public bool UpdateHobbies(Hobby hobby)
        {
            try
            {
                var data = userRegistrationEntities.Hobbies.Where(a => a.HobbiesId == hobby.HobbiesId).FirstOrDefault();
                userRegistrationEntities.Entry(data).CurrentValues.SetValues(hobby);
                userRegistrationEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}
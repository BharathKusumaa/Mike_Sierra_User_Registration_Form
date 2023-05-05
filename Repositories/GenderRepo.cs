using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Repositories
{
    public class GenderRepo
    {

        UserRegistrationEntities userRegistrationEntities = new UserRegistrationEntities();

        //This Method is Used to Retrieve The Details Of GenderInfo
        public List<Gender> GetGenderInfoDetails()
        {
            try
            {
                return userRegistrationEntities.Genders.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }

        }


        //This Method is Used to Retrieve The Details Of GenderInfo By ID Based
        public Gender GetGenderInfoById(int id)
        {
            try
            {
                return userRegistrationEntities.Genders.Where(a => a.GenderId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                return null;
            }


        }


        //This Method is Used to Save Details Of GenderInfo 
        public bool SaveGenderInfo(Gender gender)
        {
            try
            {
                userRegistrationEntities.Genders.Add(gender);
                userRegistrationEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }



        //This Method is Used to Update the Existing Details  Of GenderInfo 
        public bool UpdateGenderInfo(Gender gender)
        {
            try
            {
                var data = userRegistrationEntities.Genders.Where(a => a.GenderId == gender.GenderId).FirstOrDefault();
                userRegistrationEntities.Entry(data).CurrentValues.SetValues(gender);
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
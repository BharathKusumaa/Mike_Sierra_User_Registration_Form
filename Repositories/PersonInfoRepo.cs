using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Repositories
{
    public class PersonInfoRepo
    {

        UserRegistrationEntities userRegistrationEntities = new UserRegistrationEntities();

        //This Method is Used to Retrieve The Details Of PersonInfo
        public List<PersonInfo> GetPersonInfoDetails()
        {
            try
            {
                return userRegistrationEntities.PersonInfoes.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }
           
        }


        //This Method is Used to Retrieve The Details Of PersonInfo By ID Based
        public PersonInfo GetPersonInfoById(int id)
        {
            try
            {
                return userRegistrationEntities.PersonInfoes.Where(a => a.UserId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                return null;
            }
    

        }


        //This Method is Used to Save Details Of PersonInfo 
        public bool SavePersonInfo(PersonInfo personInfo)
        {
            try
            {
                userRegistrationEntities.PersonInfoes.Add(personInfo);
                userRegistrationEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
          
        }



        //This Method is Used to Update the Existing Details  Of PersonInfo 
        public bool UpdatePersonInfo(PersonInfo personInfo)
        {
            try
            {
                var data = userRegistrationEntities.PersonInfoes.Where(a => a.UserId == personInfo.UserId).FirstOrDefault();
                userRegistrationEntities.Entry(data).CurrentValues.SetValues(personInfo);
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
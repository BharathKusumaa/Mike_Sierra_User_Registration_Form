using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.BussinessLogic
{
    public class PersonInfoBL
    {
        PersonInfoRepo personInfoRepo = new PersonInfoRepo();
        GenderRepo genderRepo = new GenderRepo();
        HobbiesRepo hobbiesRepo = new HobbiesRepo();

        //This Method is Used to Retrieve The Details Of PersonInfo
        public List<PersonInfo> GetPersonInfoDetails()
        {
            try
            {
                return personInfoRepo.GetPersonInfoDetails();
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
                return personInfoRepo.GetPersonInfoById(id);
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
                return personInfoRepo.SavePersonInfo(personInfo);
               
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
                return personInfoRepo.UpdatePersonInfo(personInfo);
              
                 
            }
            catch (Exception ex)
            {

                return false;
            }

        }

            //To Get Grid view 
        public List<PersonInfoDetails> GetPersonInformation()
        {
            try
            {
                var personsdata = personInfoRepo.GetPersonInfoDetails();
                var gendersdata = genderRepo.GetGenderInfoDetails();
                var hobbiesdata = hobbiesRepo.GetHobbiesDetails();
                var resultdata = from person in personsdata
                                 join gender in gendersdata
                                 on person.Gender equals gender.GenderId
                                 join hobby in hobbiesdata
                                 on person.Hobbies equals hobby.HobbiesId
                                 select new PersonInfoDetails
                                 {
                                     UserId = person.UserId,
                                     FirstName = person.FirstName,
                                     LastName = person.LastName,
                                     Email = person.Email,
                                     Password = person.Password,
                                     Mobile=person.Mobile,
                                     Gender=gender.Gender1,
                                    Hobbies=hobby.Hobbies,
                                 };
                return resultdata.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Repositories;

namespace WebApplication1.BussinessLogic
{
    public class GenderBL
    {

        GenderRepo genderRepo = new GenderRepo();

        //This Method is Used to Retrieve The Details Of GenderInfo
        public List<Gender> GetGenderInfoDetails()
        {
            try
            {
                return genderRepo.GetGenderInfoDetails();
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
                return genderRepo.GetGenderInfoById(id);
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
                return genderRepo.SaveGenderInfo(gender);
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
                return genderRepo.UpdateGenderInfo(gender);
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Repositories;

namespace WebApplication1.BussinessLogic
{
    public class HobbiesBL 
    {
        HobbiesRepo hobbiesRepo = new HobbiesRepo();

        //This Method is Used to Retrieve The Details Of Hobbies
        public List<Hobby> GetHobbiesDetails()
        {
            try
            {
                return hobbiesRepo.GetHobbiesDetails();
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
                return hobbiesRepo.GetHobbiesById(id);
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
                return hobbiesRepo.SaveHobbies(hobby);
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
                return hobbiesRepo.UpdateHobbies(hobby);
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}
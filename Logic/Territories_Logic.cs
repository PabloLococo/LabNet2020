using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAO;

namespace Logic
{
    public class Territories_Logic

    {
        private Territories_DAO territories_DAO;

        public Territories_Logic()
        {
            territories_DAO = new Territories_DAO();
        }

        public Territories Insert_New_Territorie(Territories territories)
        {
            return territories_DAO.Insert(territories);
        }

        public List<Territories> List_Territories()
        {
            return territories_DAO.GetAll();
        }

        public void Delete_Employee(Territories territories)
        {
            territories_DAO.Delete(territories);
        }

        public void Update_Territories(Territories territories)
        {
            territories_DAO.Update(territories);
        }
    }
}

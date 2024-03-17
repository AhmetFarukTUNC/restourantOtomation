using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class cPersonels
    {

        cGeneral general = new cGeneral();

        #region fields

        private int _PersonelId;

        private string _PersonelMissionId;
        
        private string _PersonelName;
        
        private string PersonelSurname;

        private string _PersonelPassword;

        private string _PersonelUsername;

        private bool PersonelDurum;

        #endregion

        #region Properties

        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        
        public string PersonelMissionId { get => _PersonelMissionId; set => _PersonelMissionId = value; }
        
        public string PersonelName { get => _PersonelName; set => _PersonelName = value; }
        
        public string PersonelSurname1 { get => PersonelSurname; set => PersonelSurname = value; }
        
        public string PersonelPassword { get => _PersonelPassword; set => _PersonelPassword = value; }
        
        public string PersonelUsername { get => _PersonelUsername; set => _PersonelUsername = value; }
        
        public bool PersonelDurum1 { get => PersonelDurum; set => PersonelDurum = value; }

        #endregion

        public bool personelEntryControl(string password,int UserId)
        {

            bool result = false;

            try
            {
                SqlConnection con = new SqlConnection(general.conString);
                SqlCommand cmd = new SqlCommand("Select * from Personeler where ID=@Id and PASSWORD=@Password",con);


                
            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }
    }
}

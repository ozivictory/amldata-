using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amldata.Models
{
    public class ctrdesc
    {
        public int Id { get; set; }
        public string TRANS_NUMBER { get; set; }
        public string Trans_desc { get; set; }
        public DateTime TRANS_DATE { get; set; }
        public string TRANS_LOCATION { get; set; }
        public string TELLER { get; set; }
        public string AUTHORIZED { get; set; }
        public DateTime Date_post { get; set; }
        public bool Late_Dep { get; set; }
        public double Amount_local { get; set; }
        public string Trans_mode { get; set; }
        public string From_funds_code { get; set; }
        public string From_funds_comment { get; set; }
        public string From_foreign_curr { get; set; }
        public string From_inst_name { get; set; }
        public string From_inst_code { get; set; }
        public string Trans_conductor { get; set; }
        public string From_Account { get; set; }
        public string From_account_name { get; set; }
        public string From_country { get; set; }
        public string From_currency_code { get; set; }
        public string From_first_name { get; set; }
        public string From_last_name { get; set; }
        public string To_funds_code { get; set; }
        public string To_funds_comment { get; set; }
        public string To_inst_name { get; set; }
        public string To_inst_code { get; set; }
        public string To_foreign_currency { get; set; }
        public string To_account { get; set; }
        public string To_country_code { get; set; }
        public double Foreign_amount { get; set; }
        public string Foreign_ex_rate { get; set; }
        public string Branch { get; set; }
        public string Swift { get; set; }
        public string Non_bank_inst { get; set; }
        public string Account_type { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public string SSN { get; set; }
        public string Nationality { get; set; }
        public string Residence { get; set; }
        public string Phones { get; set; }
        public string Occupation { get; set; }
        public string Source_of_wealth { get; set; }
        public string Comments { get; set; }
        public string Address { get; set; }

        // TODO: Check Address_type datatype prev: char
        public string Address_type { get; set; }
        public string City { get; set; }

        // TODO: check Country_Code, T_Contact_type, T_Comm_Type, T-Number datatype . prev: char
        public string Country_code { get; set; }
        public string T_Contact_type { get; set; }
        public string T_Comm_type { get; set; }
        public string T_Number { get; set; }
        public string INC_Name { get; set; }
        public string INC_NO { get; set; }
        public string INC_BUSINESS { get; set; }
        public string INC_PHONE { get; set; }
        public string INC_ADDRESS { get; set; }
        public string INC_EMAIL { get; set; }
        public string INC_COUNTRY_CODE { get; set; }
        public DateTime INCP_DATE { get; set; }
        public string INC_STATE { get; set; }
        public string TAX_NUMBER { get; set; }
        public string INC_DIR_ID { get; set; }
        public string INC_DIR_FIRSTNAME { get; set; }
        public string INC_DIR_LASTNAME { get; set; }
        public string SIGN_TITLE { get; set; }
        public string SIGN_FIRSTNAME { get; set; }
        public string SIGN_LASTNAME { get; set; }
        public DateTime SIGN_DOB { get; set; }
        public DateTime OPENED { get; set; }
        public DateTime CLOSED { get; set; }
        public double BALANCE { get; set; }

        public string STATUS_CODE { get; set; }
        public string BENEFICIARY { get; set; }
        public string BENEFICIARY_COMMENT { get; set; }

    }
}

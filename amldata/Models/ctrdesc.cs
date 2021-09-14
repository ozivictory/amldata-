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
        public string trans_desc { get; set; }
        public DateTime TRANS_DATE { get; set; }
        public string TRANS_LOCATION { get; set; }
        public string TELLER { get; set; }
        public string AUTHORIZED { get; set; }
        public DateTime date_post { get; set; }
        public bool Late_Dep { get; set; }
        public double Amount_local { get; set; }
        public string trans_mode { get; set; }
        public string From_funds_code { get; set; }
        public string from_funds_comment { get; set; }
        public char from_foreign_curr { get; set; }
        public string from_inst_name { get; set; }
        public string from_inst_code { get; set; }
        public string trans_conductor { get; set; }
        public string from_Account { get; set; }
        public string from_account_name { get; set; }
        public string from_country { get; set; }
        public string from_currency_code { get; set; }
        public string from_first_name { get; set; }
        public string from_last_name { get; set; }
        public char to_funds_code { get; set; }
        public string to_funds_comment { get; set; }
        public string to_inst_name { get; set; }
        public string to_inst_code { get; set; }
        public string to_foreign_currency { get; set; }
        public string to_account { get; set; }
        public string to_country_code { get; set; }
        public double foreign_amount { get; set; }
        public string foreign_ex_rate { get; set; }
        public string branch { get; set; }
        public string swift { get; set; }
        public string non_bank_inst { get; set; }
        public char account_type { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public char title { get; set; }
        public string SSN { get; set; }
        public char nationality { get; set; }
        public string residence { get; set; }
        public string phones { get; set; }
        public string occupation { get; set; }
        public string source_of_wealth { get; set; }
        public string comments { get; set; }
        public string address { get; set; }
        public char address_type { get; set; }
        public string city { get; set; }
        public char country_code { get; set; }
        public char T_Contact_type { get; set; }
        public char T_Comm_type { get; set; }
        public char T_Number { get; set; }
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
        public char SIGN_TITLE { get; set; }
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

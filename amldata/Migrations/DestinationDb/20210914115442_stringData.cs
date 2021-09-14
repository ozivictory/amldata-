using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace amldata.Migrations.DestinationDb
{
    public partial class stringData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CTR",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANS_NUMBER = table.Column<string>(nullable: true),
                    Trans_desc = table.Column<string>(nullable: true),
                    TRANS_DATE = table.Column<DateTime>(nullable: false),
                    TRANS_LOCATION = table.Column<string>(nullable: true),
                    TELLER = table.Column<string>(nullable: true),
                    AUTHORIZED = table.Column<string>(nullable: true),
                    Date_post = table.Column<DateTime>(nullable: false),
                    Late_Dep = table.Column<bool>(nullable: false),
                    Amount_local = table.Column<double>(nullable: false),
                    Trans_mode = table.Column<string>(nullable: true),
                    From_funds_code = table.Column<string>(nullable: true),
                    From_funds_comment = table.Column<string>(nullable: true),
                    From_foreign_curr = table.Column<string>(nullable: true),
                    From_inst_name = table.Column<string>(nullable: true),
                    From_inst_code = table.Column<string>(nullable: true),
                    Trans_conductor = table.Column<string>(nullable: true),
                    From_Account = table.Column<string>(nullable: true),
                    From_account_name = table.Column<string>(nullable: true),
                    From_country = table.Column<string>(nullable: true),
                    From_currency_code = table.Column<string>(nullable: true),
                    From_first_name = table.Column<string>(nullable: true),
                    From_last_name = table.Column<string>(nullable: true),
                    To_funds_code = table.Column<string>(nullable: true),
                    To_funds_comment = table.Column<string>(nullable: true),
                    To_inst_name = table.Column<string>(nullable: true),
                    To_inst_code = table.Column<string>(nullable: true),
                    To_foreign_currency = table.Column<string>(nullable: true),
                    To_account = table.Column<string>(nullable: true),
                    To_country_code = table.Column<string>(nullable: true),
                    Foreign_amount = table.Column<double>(nullable: false),
                    Foreign_ex_rate = table.Column<string>(nullable: true),
                    Branch = table.Column<string>(nullable: true),
                    Swift = table.Column<string>(nullable: true),
                    Non_bank_inst = table.Column<string>(nullable: true),
                    Account_type = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SSN = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Residence = table.Column<string>(nullable: true),
                    Phones = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Source_of_wealth = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Address_type = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country_code = table.Column<string>(nullable: true),
                    T_Contact_type = table.Column<string>(nullable: true),
                    T_Comm_type = table.Column<string>(nullable: true),
                    T_Number = table.Column<string>(nullable: true),
                    INC_Name = table.Column<string>(nullable: true),
                    INC_NO = table.Column<string>(nullable: true),
                    INC_BUSINESS = table.Column<string>(nullable: true),
                    INC_PHONE = table.Column<string>(nullable: true),
                    INC_ADDRESS = table.Column<string>(nullable: true),
                    INC_EMAIL = table.Column<string>(nullable: true),
                    INC_COUNTRY_CODE = table.Column<string>(nullable: true),
                    INCP_DATE = table.Column<DateTime>(nullable: false),
                    INC_STATE = table.Column<string>(nullable: true),
                    TAX_NUMBER = table.Column<string>(nullable: true),
                    INC_DIR_ID = table.Column<string>(nullable: true),
                    INC_DIR_FIRSTNAME = table.Column<string>(nullable: true),
                    INC_DIR_LASTNAME = table.Column<string>(nullable: true),
                    SIGN_TITLE = table.Column<string>(nullable: true),
                    SIGN_FIRSTNAME = table.Column<string>(nullable: true),
                    SIGN_LASTNAME = table.Column<string>(nullable: true),
                    SIGN_DOB = table.Column<DateTime>(nullable: false),
                    OPENED = table.Column<DateTime>(nullable: false),
                    CLOSED = table.Column<DateTime>(nullable: false),
                    BALANCE = table.Column<double>(nullable: false),
                    STATUS_CODE = table.Column<string>(nullable: true),
                    BENEFICIARY = table.Column<string>(nullable: true),
                    BENEFICIARY_COMMENT = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTR", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTR");
        }
    }
}

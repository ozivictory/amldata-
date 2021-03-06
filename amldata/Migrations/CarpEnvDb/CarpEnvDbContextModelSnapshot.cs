// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using amldata.Data;

namespace amldata.Migrations.CarpEnvDb
{
    [DbContext(typeof(CarpEnvDbContext))]
    partial class CarpEnvDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("amldata.Models.ctrdesc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AUTHORIZED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Account_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Amount_local")
                        .HasColumnType("float");

                    b.Property<double>("BALANCE")
                        .HasColumnType("float");

                    b.Property<string>("BENEFICIARY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BENEFICIARY_COMMENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CLOSED")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_post")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Foreign_amount")
                        .HasColumnType("float");

                    b.Property<string>("Foreign_ex_rate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_account_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_currency_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_foreign_curr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_funds_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_funds_comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_inst_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_inst_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From_last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("INCP_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("INC_ADDRESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_BUSINESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_COUNTRY_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_DIR_FIRSTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_DIR_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_DIR_LASTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_NO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_PHONE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INC_STATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Late_Dep")
                        .HasColumnType("bit");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Non_bank_inst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OPENED")
                        .HasColumnType("datetime2");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SIGN_DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("SIGN_FIRSTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SIGN_LASTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SIGN_TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STATUS_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source_of_wealth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Swift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TAX_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TELLER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TRANS_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("TRANS_LOCATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRANS_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_Comm_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_Contact_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_country_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_foreign_currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_funds_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_funds_comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_inst_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_inst_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trans_conductor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trans_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trans_mode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CTR");
                });
#pragma warning restore 612, 618
        }
    }
}

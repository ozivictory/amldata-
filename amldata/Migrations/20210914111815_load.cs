using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace amldata.Migrations
{
    public partial class load : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CTR");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_airbyte_raw_ctr11");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AUTHORIZED = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount_local = table.Column<double>(type: "float", nullable: false),
                    BALANCE = table.Column<double>(type: "float", nullable: false),
                    BENEFICIARY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BENEFICIARY_COMMENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLOSED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    From_funds_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INCP_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    INC_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_BUSINESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_COUNTRY_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_DIR_FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_DIR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_DIR_LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_PHONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INC_STATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Late_Deposit = table.Column<bool>(type: "bit", nullable: false),
                    OPENED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SIGN_DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SIGN_FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIGN_LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIGN_TITLE = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATUS_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAX_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TELLER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANSACTION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TRANSACTION_LOCATION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANSACTION_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    T_Comm_type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    T_Contact_type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    T_Number = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    account_type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address_type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country_code = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    date_posting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    foreign_amount = table.Column<double>(type: "float", nullable: false),
                    foreign_ex_rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_Account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_account_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_currency_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_foreign_currency = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    from_funds_comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_institution_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_institution_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    from_last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    non_bank_inst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    residence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    source_of_wealth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    swift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    to_account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    to_country_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    to_foreign_currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    to_funds_code = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    to_funds_comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    to_institution_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    to_institution_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trans_conductor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_mode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }
    }
}

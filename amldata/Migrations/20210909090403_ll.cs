using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace amldata.Migrations
{
    public partial class ll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTR",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_NUMBER = table.Column<string>(nullable: true),
                    transaction_desc = table.Column<string>(nullable: true),
                    TRANSACTION_DATE = table.Column<DateTime>(nullable: false),
                    TRANSACTION_LOCATION = table.Column<string>(nullable: true),
                    TELLER = table.Column<string>(nullable: true),
                    AUTHORIZED = table.Column<string>(nullable: true),
                    date_posting = table.Column<DateTime>(nullable: false),
                    Late_Deposit = table.Column<bool>(nullable: false),
                    Amount_local = table.Column<double>(nullable: false),
                    transaction_mode = table.Column<string>(nullable: true),
                    From_funds_code = table.Column<string>(nullable: true),
                    from_funds_comment = table.Column<string>(nullable: true),
                    from_foreign_currency = table.Column<string>(nullable: false),
                    from_institution_name = table.Column<string>(nullable: true),
                    from_institution_code = table.Column<string>(nullable: true),
                    trans_conductor = table.Column<string>(nullable: true),
                    from_Account = table.Column<string>(nullable: true),
                    from_account_name = table.Column<string>(nullable: true),
                    from_country = table.Column<string>(nullable: true),
                    from_currency_code = table.Column<string>(nullable: true),
                    from_first_name = table.Column<string>(nullable: true),
                    from_last_name = table.Column<string>(nullable: true),
                    to_funds_code = table.Column<string>(nullable: false),
                    to_funds_comment = table.Column<string>(nullable: true),
                    to_institution_name = table.Column<string>(nullable: true),
                    to_institution_code = table.Column<string>(nullable: true),
                    to_foreign_currency = table.Column<string>(nullable: true),
                    to_account = table.Column<string>(nullable: true),
                    to_country_code = table.Column<string>(nullable: true),
                    foreign_amount = table.Column<double>(nullable: false),
                    foreign_ex_rate = table.Column<string>(nullable: true),
                    branch = table.Column<string>(nullable: true),
                    swift = table.Column<string>(nullable: true),
                    non_bank_inst = table.Column<string>(nullable: true),
                    account_type = table.Column<string>(nullable: false),
                    gender = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: false),
                    SSN = table.Column<string>(nullable: true),
                    nationality = table.Column<string>(nullable: false),
                    residence = table.Column<string>(nullable: true),
                    phones = table.Column<string>(nullable: true),
                    occupation = table.Column<string>(nullable: true),
                    source_of_wealth = table.Column<string>(nullable: true),
                    comments = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    address_type = table.Column<string>(nullable: false),
                    city = table.Column<string>(nullable: true),
                    country_code = table.Column<string>(nullable: false),
                    T_Contact_type = table.Column<string>(nullable: false),
                    T_Comm_type = table.Column<string>(nullable: false),
                    T_Number = table.Column<string>(nullable: false),
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
                    SIGN_TITLE = table.Column<string>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

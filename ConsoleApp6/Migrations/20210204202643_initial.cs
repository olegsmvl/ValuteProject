using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValuteValues",
                columns: table => new
                {
                    ValuteValueId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ID = table.Column<string>(type: "TEXT", nullable: true),
                    NumCode = table.Column<string>(type: "TEXT", nullable: true),
                    CharCode = table.Column<string>(type: "TEXT", nullable: true),
                    Nominal = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<double>(type: "REAL", nullable: false),
                    Previous = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValuteValues", x => x.ValuteValueId);
                });

            migrationBuilder.CreateTable(
                name: "Valutes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AUDValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AZNValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GBPValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AMDValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BYNValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BGNValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BRLValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    HUFValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    HKDValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DKKValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    USDValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    EURValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    INRValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    KZTValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CADValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    KGSValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CNYValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    MDLValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    NOKValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PLNValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RONValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    XDRValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SGDValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TJSValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TRYValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TMTValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UZSValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UAHValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CZKValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SEKValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CHFValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ZARValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    KRWValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true),
                    JPYValuteValueId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_AMDValuteValueId",
                        column: x => x.AMDValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_AUDValuteValueId",
                        column: x => x.AUDValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_AZNValuteValueId",
                        column: x => x.AZNValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_BGNValuteValueId",
                        column: x => x.BGNValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_BRLValuteValueId",
                        column: x => x.BRLValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_BYNValuteValueId",
                        column: x => x.BYNValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_CADValuteValueId",
                        column: x => x.CADValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_CHFValuteValueId",
                        column: x => x.CHFValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_CNYValuteValueId",
                        column: x => x.CNYValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_CZKValuteValueId",
                        column: x => x.CZKValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_DKKValuteValueId",
                        column: x => x.DKKValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_EURValuteValueId",
                        column: x => x.EURValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_GBPValuteValueId",
                        column: x => x.GBPValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_HKDValuteValueId",
                        column: x => x.HKDValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_HUFValuteValueId",
                        column: x => x.HUFValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_INRValuteValueId",
                        column: x => x.INRValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_JPYValuteValueId",
                        column: x => x.JPYValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_KGSValuteValueId",
                        column: x => x.KGSValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_KRWValuteValueId",
                        column: x => x.KRWValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_KZTValuteValueId",
                        column: x => x.KZTValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_MDLValuteValueId",
                        column: x => x.MDLValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_NOKValuteValueId",
                        column: x => x.NOKValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_PLNValuteValueId",
                        column: x => x.PLNValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_RONValuteValueId",
                        column: x => x.RONValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_SEKValuteValueId",
                        column: x => x.SEKValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_SGDValuteValueId",
                        column: x => x.SGDValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_TJSValuteValueId",
                        column: x => x.TJSValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_TMTValuteValueId",
                        column: x => x.TMTValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_TRYValuteValueId",
                        column: x => x.TRYValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_UAHValuteValueId",
                        column: x => x.UAHValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_USDValuteValueId",
                        column: x => x.USDValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_UZSValuteValueId",
                        column: x => x.UZSValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_XDRValuteValueId",
                        column: x => x.XDRValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valutes_ValuteValues_ZARValuteValueId",
                        column: x => x.ZARValuteValueId,
                        principalTable: "ValuteValues",
                        principalColumn: "ValuteValueId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<string>(type: "TEXT", nullable: true),
                    PreviousDate = table.Column<string>(type: "TEXT", nullable: true),
                    PreviousURL = table.Column<string>(type: "TEXT", nullable: true),
                    Timestamp = table.Column<string>(type: "TEXT", nullable: true),
                    ValuteId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Valutes_ValuteId",
                        column: x => x.ValuteId,
                        principalTable: "Valutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ValuteId",
                table: "Courses",
                column: "ValuteId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_AMDValuteValueId",
                table: "Valutes",
                column: "AMDValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_AUDValuteValueId",
                table: "Valutes",
                column: "AUDValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_AZNValuteValueId",
                table: "Valutes",
                column: "AZNValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_BGNValuteValueId",
                table: "Valutes",
                column: "BGNValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_BRLValuteValueId",
                table: "Valutes",
                column: "BRLValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_BYNValuteValueId",
                table: "Valutes",
                column: "BYNValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_CADValuteValueId",
                table: "Valutes",
                column: "CADValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_CHFValuteValueId",
                table: "Valutes",
                column: "CHFValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_CNYValuteValueId",
                table: "Valutes",
                column: "CNYValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_CZKValuteValueId",
                table: "Valutes",
                column: "CZKValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_DKKValuteValueId",
                table: "Valutes",
                column: "DKKValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_EURValuteValueId",
                table: "Valutes",
                column: "EURValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_GBPValuteValueId",
                table: "Valutes",
                column: "GBPValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_HKDValuteValueId",
                table: "Valutes",
                column: "HKDValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_HUFValuteValueId",
                table: "Valutes",
                column: "HUFValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_INRValuteValueId",
                table: "Valutes",
                column: "INRValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_JPYValuteValueId",
                table: "Valutes",
                column: "JPYValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_KGSValuteValueId",
                table: "Valutes",
                column: "KGSValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_KRWValuteValueId",
                table: "Valutes",
                column: "KRWValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_KZTValuteValueId",
                table: "Valutes",
                column: "KZTValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_MDLValuteValueId",
                table: "Valutes",
                column: "MDLValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_NOKValuteValueId",
                table: "Valutes",
                column: "NOKValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_PLNValuteValueId",
                table: "Valutes",
                column: "PLNValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_RONValuteValueId",
                table: "Valutes",
                column: "RONValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_SEKValuteValueId",
                table: "Valutes",
                column: "SEKValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_SGDValuteValueId",
                table: "Valutes",
                column: "SGDValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_TJSValuteValueId",
                table: "Valutes",
                column: "TJSValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_TMTValuteValueId",
                table: "Valutes",
                column: "TMTValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_TRYValuteValueId",
                table: "Valutes",
                column: "TRYValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_UAHValuteValueId",
                table: "Valutes",
                column: "UAHValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_USDValuteValueId",
                table: "Valutes",
                column: "USDValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_UZSValuteValueId",
                table: "Valutes",
                column: "UZSValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_XDRValuteValueId",
                table: "Valutes",
                column: "XDRValuteValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Valutes_ZARValuteValueId",
                table: "Valutes",
                column: "ZARValuteValueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Valutes");

            migrationBuilder.DropTable(
                name: "ValuteValues");
        }
    }
}

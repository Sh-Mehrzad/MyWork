using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWork.Migrations
{
    public partial class no2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ilce_Il_IlID",
                table: "Ilce");

            migrationBuilder.DropForeignKey(
                name: "FK_Kurumsal_Ilce_IlceID",
                table: "Kurumsal");

            migrationBuilder.DropForeignKey(
                name: "FK_PaketList_Paket_PaketID",
                table: "PaketList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paket",
                table: "Paket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ilce",
                table: "Ilce");

            migrationBuilder.DeleteData(
                table: "Ilce",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ilce",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paket",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paket",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paket",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reklam",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reklam",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reklam",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reklam",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reklam",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reklam",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "Paket",
                newName: "paket");

            migrationBuilder.RenameTable(
                name: "Ilce",
                newName: "ilce");

            migrationBuilder.RenameIndex(
                name: "IX_Ilce_IlID",
                table: "ilce",
                newName: "IX_ilce_IlID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_paket",
                table: "paket",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ilce",
                table: "ilce",
                column: "ID");

            migrationBuilder.InsertData(
                table: "Il",
                columns: new[] { "ID", "IlAdi" },
                values: new object[,]
                {
                    { 3, "Adıyaman" },
                    { 4, "Afyonkarahisar" },
                    { 5, "Aksaray" },
                    { 6, "Amasya" },
                    { 7, "Antalya" },
                    { 8, "Ardahan" },
                    { 9, "Artvin" },
                    { 10, "Aydın" },
                    { 11, "Ağrı" },
                    { 12, "Balıkesir" },
                    { 13, "Bartın" },
                    { 14, "Batman" },
                    { 15, "Bayburt" },
                    { 16, "Bilecik" },
                    { 17, "Bingöl İli" },
                    { 18, "Bitlis" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ilce_Il_IlID",
                table: "ilce",
                column: "IlID",
                principalTable: "Il",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kurumsal_ilce_IlceID",
                table: "Kurumsal",
                column: "IlceID",
                principalTable: "ilce",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaketList_paket_PaketID",
                table: "PaketList",
                column: "PaketID",
                principalTable: "paket",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ilce_Il_IlID",
                table: "ilce");

            migrationBuilder.DropForeignKey(
                name: "FK_Kurumsal_ilce_IlceID",
                table: "Kurumsal");

            migrationBuilder.DropForeignKey(
                name: "FK_PaketList_paket_PaketID",
                table: "PaketList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_paket",
                table: "paket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ilce",
                table: "ilce");

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Il",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.RenameTable(
                name: "paket",
                newName: "Paket");

            migrationBuilder.RenameTable(
                name: "ilce",
                newName: "Ilce");

            migrationBuilder.RenameIndex(
                name: "IX_ilce_IlID",
                table: "Ilce",
                newName: "IX_Ilce_IlID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paket",
                table: "Paket",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ilce",
                table: "Ilce",
                column: "ID");

            migrationBuilder.InsertData(
                table: "Ilce",
                columns: new[] { "ID", "IlID", "IlceAdi" },
                values: new object[,]
                {
                    { 1, null, "Seyhan" },
                    { 2, null, "Yüreğir" }
                });

            migrationBuilder.InsertData(
                table: "Paket",
                columns: new[] { "ID", "PaketName" },
                values: new object[,]
                {
                    { 1, "Standart" },
                    { 2, "Silver" },
                    { 3, "Gold" }
                });

            migrationBuilder.InsertData(
                table: "Reklam",
                columns: new[] { "ID", "ReklamName" },
                values: new object[,]
                {
                    { 1, "AnaSayfa 01" },
                    { 2, "AnaSayfa 02" },
                    { 3, "AnaSayfa Firma" },
                    { 4, "AnaSayfa Ürün" },
                    { 5, "Blog (Haber Tanıtım)" },
                    { 6, "Diğer ..." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ilce_Il_IlID",
                table: "Ilce",
                column: "IlID",
                principalTable: "Il",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kurumsal_Ilce_IlceID",
                table: "Kurumsal",
                column: "IlceID",
                principalTable: "Ilce",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaketList_Paket_PaketID",
                table: "PaketList",
                column: "PaketID",
                principalTable: "Paket",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

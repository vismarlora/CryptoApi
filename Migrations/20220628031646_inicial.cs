using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    MonedaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<double>(type: "REAL", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.MonedaId);
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 1, "Bitcoin", "https://cdn.icon-icons.com/icons2/674/PNG/512/bitcoin_icon-icons.com_60538.png", 20.609999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 2, "Ethereum", "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png", 1.1739999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 3, "Dogecoin", "https://cdn.icon-icons.com/icons2/3376/PNG/512/dogecoin_currency_icon_211986.png", 0.069361000000000006 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 4, "Pax Dollar", "https://cdn.icon-icons.com/icons2/2130/PNG/512/pax_cryptocurrency_logo_icon_131411.png", 1.0011000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 5, "EOS", "https://cdn.icon-icons.com/icons2/1386/PNG/512/eos-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95779.png", 0.95530000000000004 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 6, "BNB", "https://cdn.icon-icons.com/icons2/1386/PNG/512/bnb-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95846.png", 231.69999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 7, "XRP", "https://cdn.icon-icons.com/icons2/2130/PNG/512/xrp_cryptocurrency_logo_icon_131379.png", 0.34234999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 8, "Monero", "https://cdn.icon-icons.com/icons2/3053/PNG/512/monero_wallet_macos_bigsur_icon_189935.png", 117.566 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins");
        }
    }
}

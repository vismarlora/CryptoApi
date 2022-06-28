using Microsoft.EntityFrameworkCore;

public class Contexto:DbContext
{
    public DbSet<Coins> Coins { get; set; }

    public Contexto (DbContextOptions<Contexto> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Coins>().HasData(
            new Coins (){
                MonedaId = 1,
                Descripcion = "Bitcoin",
                Valor = 20000.610,
                ImageUrl = "https://cdn.icon-icons.com/icons2/674/PNG/512/bitcoin_icon-icons.com_60538.png"
            },

            new Coins (){
                MonedaId = 2,
                Descripcion = "Ethereum",
                Valor = 1.174,
                ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png"
            },

            new Coins (){
                MonedaId = 3,
                Descripcion = "Dogecoin",
                Valor = 0.069361,
                ImageUrl = "https://cdn.icon-icons.com/icons2/3376/PNG/512/dogecoin_currency_icon_211986.png"
            },

            new Coins (){
                MonedaId = 4,
                Descripcion = "Pax Dollar",
                Valor = 1.0011,
                ImageUrl = "https://cdn.icon-icons.com/icons2/2130/PNG/512/pax_cryptocurrency_logo_icon_131411.png"
            },

            new Coins (){
                MonedaId = 5,
                Descripcion = "EOS",
                Valor = 0.9553,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/eos-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95779.png"
            },

            new Coins (){
                MonedaId = 6,
                Descripcion = "BNB",
                Valor = 231.70,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/bnb-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95846.png"
            },

            new Coins (){
                MonedaId = 7,
                Descripcion = "XRP",
                Valor = 0.34235,
                ImageUrl = "https://cdn.icon-icons.com/icons2/2130/PNG/512/xrp_cryptocurrency_logo_icon_131379.png"
            },

            new Coins (){
                MonedaId = 8,
                Descripcion = "Monero",
                Valor = 117.566,
                ImageUrl = "https://cdn.icon-icons.com/icons2/3053/PNG/512/monero_wallet_macos_bigsur_icon_189935.png"
            }

        );
    }

}
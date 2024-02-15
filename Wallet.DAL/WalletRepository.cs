using IWallet.DAL.Contracts;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wallet.Common.Entities.Amount;

namespace Wallet.DAL
{
    public class WalletRepository : IWalletRepository
    {
        public void Add(AmountType type)
        {
            string connectionString = "Data Source=DESKTOP-M2QA1DM\\SQLEXPRESS;Initial Catalog=walbase;User ID=User;Password=;Encrypt=False;Trusted_Connection=True";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO Wallets (rub) VALUES({type})";
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.ExecuteNonQuery();
            }
        }
    }
}

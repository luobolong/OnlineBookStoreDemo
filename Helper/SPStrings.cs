using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class SPStrings
    {
        public static string Administrator_Insert = "dbo.Administrator_Insert @Username, @RealName, @PasswordHash, @EmailAddress";
        public static string Administrator_Login = "dbo.Administrator_Login @Username, @PasswordHash";
        public static string Carts_Add = "dbo.Carts_Add @CustomerId, @BookISBN, @Amount";
        public static string Customer_Insert = "dbo.Customer_Insert @Username, @RealName, @PasswordHash, @Address, @PhoneNumber, @EmailAddress";
        public static string Customer_Login = "dbo.Customer_Login @Username, @PasswordHash";
        public static string Supplier_Insert = "dbo.Supplier_Insert @Username, @RealName, @PasswordHash, @PhoneNumber, @EmailAddress";
        public static string Supplier_Login = "dbo.Supplier_Login @Username, @PasswordHash";
        public static string SupplierOrder_Insert_Existent_Book = "dbo.SupplierOrder_Insert_Existent_Book @SupplierId, @OrderDate, @Amount, @BookISBN";
        public static string SupplierOrder_Insert_New_Book = "dbo.SupplierOrder_Insert_New_Book @SupplierId, @OrderDate, @Amount, @BookISBN, @BookTitle, @BookPrice, @BookAuthor, @BookPublisher, @GenreClc, @PublicationDate, @Introduction";
    }
}

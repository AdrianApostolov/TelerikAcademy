namespace AddNewProduct
{
    using System;
    using System.Data.SqlClient;

    public class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=Northwind; Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                int newProjectId = InsertProduct(
                                    dbCon,
                                    "Starbucks Coffee",
                                    20,
                                    1,
                                    "150 ml",
                                    3.3m,
                                    500,
                                    400,
                                    20,
                                    false);
                Console.WriteLine("Inserted new product with ProductID = {0}", newProjectId);
            }
        }

        private static int InsertProduct(
                            SqlConnection dbCon,
                            string productName, 
                            int supplierId,
                            int categoryId, 
                            string quantityPerUnit,
                            decimal unitPrice,
                            int unitsInStock,
                            int unitsOnOrder,
                            int reorderLevel,
                            bool discontinued)
        {
            SqlCommand cmdInsertProject = new SqlCommand(
                "INSERT INTO Products([ProductName], [SupplierID], [CategoryID], [QuantityPerUnit]" +
                ",[UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued]) " +
                "VALUES (@productName, @supplierId, @categoryId, @quantityPerUnit, " +
                "@unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", dbCon);
            cmdInsertProject.Parameters.AddWithValue("@productName", productName);
            cmdInsertProject.Parameters.AddWithValue("@supplierId", supplierId);
            cmdInsertProject.Parameters.AddWithValue("@categoryId", categoryId);
            cmdInsertProject.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            cmdInsertProject.Parameters.AddWithValue("@unitPrice", unitPrice);
            cmdInsertProject.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            cmdInsertProject.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            cmdInsertProject.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            cmdInsertProject.Parameters.AddWithValue("@discontinued", discontinued ? 1 : 0);
            cmdInsertProject.ExecuteNonQuery();

            SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
            int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
            return insertedRecordId;
        }
    }
}

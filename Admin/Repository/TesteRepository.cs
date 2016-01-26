using Admin.Models;
using System.Collections.Generic;
using System.Configuration;
using System;
using Npgsql;
using NPoco;
using NPoco.FluentMappings;


namespace Admin.Repository
{
    public class TesteRepository
    {
        private DatabaseFactory databaseFactory;

        public IEnumerable<TesteDTO> GetAll()
        {
            

        DatabaseFactoryConfigOptions options = new DatabaseFactoryConfigOptions();

            options.Database = () => new Database("ApplicationConnectionString");
            //options.PocoDataFactory = FluentMappingConfiguration.Configure(new PersonMap(), new AddressMap());

            databaseFactory = new DatabaseFactory(options);


            using (var db = databaseFactory.GetDatabase())
            {
                using (var tran = db.GetTransaction())
                {
                    var t = db.Fetch<TesteDTO>("SELECT \"Id\", \"Name\" FROM \"Teste\"; ");
                    
                    return null;
                }
            }
                    



            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ///"Server=127.0.0.1;Port=5432;User Id=postgres;Password=pa$$w0rd;Database=Admin;"
            //NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=Admin;User Id=admin;Password=admin");

            //NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            //var query = "SELECT Id, Name FROM public.Teste";
            //NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            //IDatabase db = new Database(conn);
            //var t = db.Fetch<TesteDTO>();

            //return t;



            //using (var conn = new NpgsqlConnection("Host=.;Username=postgres;Password=pa$$w0rd;Database=postgres"))
            //{
            //    conn.Open();
            //    using (var cmd = new NpgsqlCommand())
            //    {
            //        cmd.Connection = conn;

            //        // Insert some data
            //        //cmd.CommandText = "INSERT INTO data (some_field) VALUES ('Hello world')";
            //        //cmd.ExecuteNonQuery();

            //        // Retrieve all rows
            //        cmd.CommandText ="SELECT Id, Name FROM public.Teste";
            //        using (var reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                Console.WriteLine(reader.GetString(0));
            //            }
            //        }
            //    }
            //}
            //return null;
        }
    }
}
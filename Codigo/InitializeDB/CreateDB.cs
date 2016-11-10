
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes
                UsuarioCAD usu = new UsuarioCAD ();
                UsuarioCEN usucen = new UsuarioCEN (usu);
                UsuarioEN usuen = new UsuarioEN ();
                AdminCAD adm = new AdminCAD ();
                AdminCEN admcen = new AdminCEN (adm);
                AdminEN admen = new AdminEN ();
                EventoCAD eve = new EventoCAD ();
                EventoCEN evecen = new EventoCEN (eve);
                EventoEN even = new EventoEN ();
                RetoCAD ret = new RetoCAD ();
                RetoCEN retcen = new RetoCEN (ret);
                RetoEN reten = new RetoEN ();
                ReporteCAD rep = new ReporteCAD ();
                ReporteCEN repcen = new ReporteCEN (rep);
                ReporteEN repen = new ReporteEN ();
                MapaCAD map = new MapaCAD ();
                MapaCEN mapcen = new MapaCEN (map);
                MapaEN mapen = new MapaEN ();
                PuntuacionCAD punt = new PuntuacionCAD ();
                PuntuacionCEN puntcen = new PuntuacionCEN (punt);
                PuntuacionEN punten = new PuntuacionEN ();
                PasoCAD pas = new PasoCAD ();
                PasoCEN pascen = new PasoCEN (pas);
                PasoEN pasen = new PasoEN ();
                ComentarioCAD com = new ComentarioCAD ();
                ComentarioCEN comcen = new ComentarioCEN (com);
                ComentarioEN comen = new ComentarioEN ();
                GymkanaCAD gym = new GymkanaCAD ();
                GymkanaCEN gymcen = new GymkanaCEN (gym);
                GymkanaEN gymen = new GymkanaEN ();


                usuen.Edad = 10;
                usuen.Nombre = "Pedro";
                usuen.ID = 1;
                usuen.Contrasena = "123";
                usuen.Email = "p@gmail.com";
                usuen.Facebook = "Hola";
                usuen.Foto = "si";
                usuen.Historial = "sdf";
                usuen.Instagram = "insta";
                usuen.Seguidores = 25;
                usuen.Sexo = "Hombre";


                usu.New_ (usuen);
                var r = usucen.GetAll (0, 10);
                usucen.CambiarCorreo (usuen.ID, "a@gmail.com");
                var q = usucen.GetAll (0, 0);
                usucen.CambiarContrasena (usuen.ID, "321");
                var a = usucen.GetAll (0, 0);
                usucen.CambiarFoto (usuen.ID, "no");
                var b = usucen.GetAll (0, 0);
                usucen.ConsultarUsuario (usuen.ID);
                var c = usucen.GetAll (0, 0);
                usucen.Modify (1, "Fernando", 8, 18, "hombre", "book", "Insta", "asdfg", "maramiau", "hey@gmail.com", "nope");
                var d = usucen.GetAll (0, 0);
                usucen.Destroy (1);
                var e = usucen.GetAll (0, 0);
                usu.New_ (usuen);


                admcen.New_ (2, "Pepe", 33, 20, "hombre", "popo", "gram", "sdnfjksdfk", "poporom", "asdf@gmail.com", "fotaca");
                var f = admcen.GetAll (0, 0);
                admcen.Modify (2, "Manolo", 47, 21, "hombre", "poporopopo", "grammmy", "cajsdhfk", "rompopoporom", "fdsa@gmail.com", "fotacon");
                var g = admcen.GetAll (0, 0);
                evecen.New_ ("Mi nacimiento", "Pa que me veais nacer y to eso", new DateTime (2008, 6, 1, 7, 47, 0), 1000000, 1, 2);
                admcen.BorrarEvento (1);
                var h = admcen.GetAll (0, 0);
                retcen.New_ ("Comer huevos", "A que no puedes comer 50 huevos", "Comida", 10, "imagen.png", 1, 1);
                admcen.BorrarRetos (1);
                var i = admcen.GetAll (0, 0);
                admcen.Destroy (2);
                var j = admcen.GetAll (0, 0);

                gymcen.New_ ("Caminito de belen", "Ole ole holanda y ole", new DateTime (2010, 6, 1, 7, 47, 0), 11, 2, 1, 10);
                pascen.New_ ("ajshdjkahfjksdhfkjsdki", 1, 2);
                pascen.Modify (1, "dhfkjadjf");
                pascen.VerPaso (pasen.ID);
                pascen.VerPasos (pasen.ID);

                evecen.New_ ("Mi nacimiento", "Pa que me veais nacer y to eso", new DateTime (2008, 6, 1, 7, 47, 0), 1000000, 1, 1);
                comcen.New_ ("tuturuu", "creationer", 1, 1, 1, -1);
                comcen.Destroy (1);
                retcen.New_ ("Comer huevos", "A que no puedes comer 50 huevos", "Comida", 10, "imagen.png", 1, 1);
                comcen.New_ ("tuturuu", "creationer", 1, 1, -1, 1);
                comcen.Destroy (1);



                var aa = evecen.GetAll (0, 0);
                evecen.Modify (1, "Mi muerte", "FUE CULPA DE MULTIMEDIA", new DateTime (2009, 6, 1, 7, 47, 0), 0);
                var bb = evecen.GetAll (0, 0);
                evecen.Destroy (1);
                var cc = evecen.GetAll (0, 0);
                var dd = evecen.GetID (1);
                var dedo = evecen.VerEvento (1);

                var ee = retcen.GetAll (0, 0);
                retcen.Modify (1, "Comer cabezas de cerillas", "No se, gente lo hacia de peque�os", "Comidas raras", 1, "cerilla.jpg");
                var ff = retcen.GetAll (0, 0);
                retcen.Destroy (1);
                var gg = retcen.GetAll (0, 0);
                var hh = retcen.GetID (1);
                var haha = evecen.VerEvento (1);

                var ii = retcen.GetAll (0, 0);
                gymcen.Modify (2, "Holanda ya se ve", "Ya se ve, ya se ve", new DateTime (2012, 6, 1, 7, 47, 0), 10, 11);
                var jj = gymcen.GetAll (0, 0);
                gymcen.Destroy (2);
                var kk = gymcen.GetAll (0, 0);
                gymcen.New_ ("Caminito de belen", "Ole ole holanda y ole", new DateTime (2010, 6, 1, 7, 47, 0), 11, 2, 1, 10);
                var ll = gymcen.GetID (2);
                //var mm = gymcen.VerPasos (2);
                gymcen.AnadirPaso (2, "Otro paso", 20, 20, 15);
                var oo = gymcen.GetAll (0, 0);

                evecen.New_ ("Mi nacimiento", "Pa que me veais nacer y to eso", new DateTime (2008, 6, 1, 7, 47, 0), 1000000, 1, 1);
                retcen.New_ ("Comer huevos", "A que no puedes comer 50 huevos", "Comida", 10, "imagen.png", 2, 1);

                mapcen.New_ (1, 1, -1, 0, 38, 16);
                mapcen.Modify (1, 1, 37, 12);
                mapcen.Destroy (1);
                //falta filtrar mapa


                puntcen.New_ (1, 2, -1, 1, 3);
                puntcen.New_ (1, -1, 1, 2, 5);
                puntcen.VerMedia (2, -1);
                puntcen.VerVoto (1, 2, -1);

                System.Collections.Generic.IList<int> aux = null;
                aux.Add (1);
                repcen.New_ ("heyestoestamal", 1, 5, aux, 1, -1);
                repcen.New_ ("heyestoestafatal", 1, 5, aux, -1, 1);
                repcen.Reportar (1, 2, -1, "Concha de tu madre");
                repcen.Reportar (1, -1, 1, "Concha 2");
                repcen.ConsultarReporte (1, 1, -1);
                repcen.ConsultarReporte (1, -1, 2);
                repcen.Destroy (1);


                int k = 0;

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}

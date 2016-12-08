/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CP.Whatever;


/*PROTECTED REGION END*/
namespace InitializeDB
{
    public class CreateDB
    {
        public static void Create(string databaseArg, string userArg, string passArg)
        {
            String database = databaseArg;
            String user = userArg;
            String pass = passArg;

            // Conex DB
            SqlConnection cnn = new SqlConnection(@"Server=(local)\sqlexpress; database=master; integrated security=yes");

            // Order T-SQL create user
            String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN [" + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END";

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
                cnn.Open();

                //Create user in SQLSERVER
                cmd = new SqlCommand(createUser, cnn);
                cmd.ExecuteNonQuery();

                //DELETE database if exist
                cmd = new SqlCommand(deleteDataBase, cnn);
                cmd.ExecuteNonQuery();

                //CREATE DB
                cmd = new SqlCommand(createBD, cnn);
                cmd.ExecuteNonQuery();

                //Associate user with db
                cmd = new SqlCommand(associatedUser, cnn);
                cmd.ExecuteNonQuery();

                System.Console.WriteLine("DataBase create sucessfully..");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public static void InitializeData()
        {
            /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
            try
            {
                // Insert the initilizations of entities using the CEN classes
                UsuarioCAD usu = new UsuarioCAD();
                UsuarioCEN usucen = new UsuarioCEN(usu);
                UsuarioEN usuen = new UsuarioEN();
                UsuarioCP usucp = new UsuarioCP();

                AdminCAD adm = new AdminCAD();
                AdminCEN admcen = new AdminCEN(adm);
                AdminEN admen = new AdminEN();
                AdminCP admcp = new AdminCP();

                EventoCAD eve = new EventoCAD();
                EventoCEN evecen = new EventoCEN(eve);
                EventoEN even = new EventoEN();
                EventoCP evecp = new EventoCP();

                RetoCAD ret = new RetoCAD();
                RetoCEN retcen = new RetoCEN(ret);
                RetoEN reten = new RetoEN();
                RetoCP retcp = new RetoCP();

                ReporteCAD rep = new ReporteCAD();
                ReporteCEN repcen = new ReporteCEN(rep);
                ReporteEN repen = new ReporteEN();
                ReporteCP repcp = new ReporteCP();

                MapaCAD map = new MapaCAD();
                MapaCEN mapcen = new MapaCEN(map);
                MapaEN mapen = new MapaEN();
                MapaCP mapcp = new MapaCP();
                MapaCAD map2 = new MapaCAD();
                MapaCEN mapcen2 = new MapaCEN(map);
                MapaEN mapen2 = new MapaEN();
                MapaCP mapcp2 = new MapaCP();

                PuntuacionCAD punt = new PuntuacionCAD();
                PuntuacionCEN puntcen = new PuntuacionCEN(punt);
                PuntuacionEN punten = new PuntuacionEN();
                PuntuacionCP puntcp = new PuntuacionCP();

                PasoCAD pas = new PasoCAD();
                PasoCEN pascen = new PasoCEN(pas);
                PasoEN pasen = new PasoEN();
                PasoCP pascp = new PasoCP();

                ComentarioCAD com = new ComentarioCAD();
                ComentarioCEN comcen = new ComentarioCEN(com);
                ComentarioEN comen = new ComentarioEN();
                ComentarioCP comcp = new ComentarioCP();

                ComentarioCAD com2 = new ComentarioCAD();
                ComentarioCEN comcen2 = new ComentarioCEN(com);
                ComentarioEN comen2 = new ComentarioEN();
                ComentarioCP comcp2 = new ComentarioCP();

                GymkanaCAD gym = new GymkanaCAD();
                GymkanaCEN gymcen = new GymkanaCEN(gym);
                GymkanaEN gymen = new GymkanaEN();
                GymkanaCP gymcp = new GymkanaCP();


                //insertamos valores en el usuarioEN
                usuen.Nombre = "Pedro";
                usuen.Edad = 10;
                usuen.Sexo = "Hombre";
                usuen.Facebook = "Hola";
                usuen.Instagram = "insta";
                usuen.Twitter = "sdf";
                usuen.Contrasena = "123";
                usuen.Email = "p@gmail.com";
                usuen.Foto = "si";

                //creamos el mapa de un evento
                mapen.Latitud = 38.38678385887277;
                mapen.Longitud = -0.5114087462425232;
                mapen.Zoom = 15;
                mapen.Id = 1;

                //creamos el mapa de un reto
                mapen2.Latitud = 38.5;
                mapen2.Longitud = -0.5;
                mapen2.Zoom = 20;
                mapen2.Id = 2;


                //creamos el evento
                even.Titulo = "quedada para ruta de la tapa";
                even.Descripcion = "la idea es ir un grupo grande de gente de bar en bar";
                even.Usuario_evento = usuen;
                even.Precio = 0;
                even.Fecha = new DateTime();
                mapen.Evento_mapa2 = even;

                //creamos un reto
                reten.Titulo = "no hay huevos a venir a clase desnudo";
                reten.Descripcion = "pues eso, venir a clase y demostrarme tu valentia";
                reten.Precio = 0;
                reten.Imagen = "";
                reten.Tipo = "";
                reten.Usuario_reto2 = usuen;



                //creamos los comentarios
                comen.Creador = usuen.Nombre;
                comen.Texto = "pos ta wapo el evento";
                comen.Comentario_evento2 = even;
                comen.Comentario_reto = reten;



                var debugPoint1 = usucen.GetAll(0, 0);

                //registramos el nuevo usuario y vamos probando metodos
                
                
                usucen.Registro(usuen);
                IList <UsuarioEN> listU= usu.FiltrarNombreCorreo("pedro", "p@gmail.com");
                debugPoint1 = usucen.GetAll(0, 0);
                usucen.CambiarCorreo(listU[0].ID, "a@gmail.com");
                debugPoint1 = usucen.GetAll(0, 0);
                var con= usucen.CambiarContrasena(usuen.ID, "321");
                debugPoint1 = usucen.GetAll(0, 0);
                var foto= usucen.CambiarFoto(usuen.ID, "no");
                debugPoint1 = usucen.GetAll(0, 0);
                var consul= usucen.ConsultarUsuario(usuen.ID);
                debugPoint1 = usucen.GetAll(0, 0);
                usucen.ModificarRedesSociales("sfs", "gdfg", "sdfds", usuen.ID);
                debugPoint1 = usucen.GetAll(0, 0);


                var debugPoint2= evecen.GetAll(0, 0);

                //ADMIN
                //usucp.HacerAdmin(1);
                //admen = adm.GetID(1);
                //var debugAdmin = admcen.GetAll(0, 0); 

                //EVENTO
                /*evecp.CrearEvento(even, mapen.Latitud, mapen.Longitud, mapen.Zoom);
                
                debugPoint2 = evecen.GetAll(0, 0);
                evecen.Modify(1, "Mi muerte", "FUE CULPA DE MULTIMEDIA", new DateTime(2009, 6, 1, 7, 47, 0), 0);
                debugPoint2 = evecen.GetAll(0, 0);
                var vereven= evecen.VerEvento(1);
                debugPoint2 = evecen.GetAll(0, 0);
                evecen.VerEvento(1);
                var d3 = evecen.GetID(1);
                var dedo = evecen.VerEvento(1);*/



                //NUEVO RETO
                RetoEN reten2 = new RetoEN();
                reten2.Titulo = "Cabeza de hierro";
                reten2.Descripcion = "romper 10 ladrillos con la cabeza ";
                reten2.Precio = 0;
                reten2.Imagen = "";
                reten2.Tipo = "";
                reten2.Usuario_reto2 = usuen;
                //reten2.Id_mapa.Add(mapen2.Id);

                

                var debugPoint3 = retcen.GetAll(0,0);
                //RETO
                retcen.CrearReto(reten);
                debugPoint3 = retcen.GetAll(0, 0); 
                //retcen.ModificarReto(reten2);
                debugPoint3 = retcen.GetAll(0, 0);
                //BORRAR RETO
                //retcp.BorrarReto(1);
                debugPoint3 = retcen.GetAll(0, 0);
                var h4 = retcen.GetID(1);
                debugPoint3 = retcen.GetAll(0, 0);


                //ADMIN BORRAR EVENTO Y RETO
                //admcp.BorrarEvento(1);
                var a5 = admcen.GetAll(0, 0);
                debugPoint3 = retcen.GetAll(0, 0);
                //admcp.BorrarRetos(1);
                var b5 = admcen.GetAll(0, 0);
                debugPoint3 = retcen.GetAll(0, 0);

                var debugPoint4 = gymcen.GetAll(0, 0);
                //GYMKANA0.
                //gymcp.CrearGymkana(gymen, mapen.Latitud, mapen.Longitud, mapen.Zoom);
                gymcen.Modify (2, "Holanda ya se ve", "Ya se ve, ya se ve", new DateTime (2012, 6, 1, 7, 47, 0), 10, 11);
                debugPoint4 = gymcen.GetAll(0, 0);
                gymcen.Destroy (2);
                debugPoint4 = gymcen.GetAll(0, 0);

                //CREAR GIMKANA
                var l6 = gymcen.GetID(2);
                var mm = gymcen.VerPasos (2);

                gymcp.AnadirPaso(pasen, mapen);
                var o6 = gymcen.GetAll(0, 0);


                //PASO
                pascen.VerPaso(pasen.ID);
                pascen.VerPasos(pasen.ID);
                pascen.FiltrarPasos(gymen.ID);


                //CREAR MAPA
                mapcen.Modify(1, 1, 37, 12);
                mapcen.Destroy(1);
                //falta filtrar mapa

                //CREAR PUNTUACIONES
                puntcen.VerMedia(2, -1);
                puntcen.VerVoto(1, 2, -1);

                System.Collections.Generic.IList<int> aux = null;
                aux.Add(1);

                //CREAR REPORTE
                repcp.Reportar(1, 2, -1, "Concha de tu madre");
                repcp.Reportar(1, -1, 1, "Concha 2");
                repcen.ConsultarReporte(1, 1, -1);
                repcen.ConsultarReporte(1, -1, 2);
                //repcen.Destroy (1);


                

                /*PROTECTED REGION END*/
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.InnerException);
                throw ex;
            }
        }
    }
}
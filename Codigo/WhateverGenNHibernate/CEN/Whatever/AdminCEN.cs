

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;

using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


namespace WhateverGenNHibernate.CEN.Whatever
{
/*
 *      Definition of the class AdminCEN
 *
 */
public partial class AdminCEN
{
private IAdminCAD _IAdminCAD;

public AdminCEN()
{
        this._IAdminCAD = new AdminCAD ();
}

public AdminCEN(IAdminCAD _IAdminCAD)
{
        this._IAdminCAD = _IAdminCAD;
}

public IAdminCAD get_IAdminCAD ()
{
        return this._IAdminCAD;
}

public int New_ (int p_ID, string p_nombre, int p_seguidores, int p_edad, string p_sexo, string p_Facebook, string p_Instagram, string p_Historial, String p_contrasena, string p_email, string p_foto)
{
        AdminEN adminEN = null;
        int oid;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.ID = p_ID;

        adminEN.Nombre = p_nombre;

        adminEN.Seguidores = p_seguidores;

        adminEN.Edad = p_edad;

        adminEN.Sexo = p_sexo;

        adminEN.Facebook = p_Facebook;

        adminEN.Instagram = p_Instagram;

        adminEN.Historial = p_Historial;

        adminEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);

        adminEN.Email = p_email;

        adminEN.Foto = p_foto;

        //Call to AdminCAD

        oid = _IAdminCAD.New_ (adminEN);
        return oid;
}

public void Modify (int p_Admin_OID, string p_nombre, int p_seguidores, int p_edad, string p_sexo, string p_Facebook, string p_Instagram, string p_Historial, String p_contrasena, string p_email, string p_foto)
{
        AdminEN adminEN = null;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.ID = p_Admin_OID;
        adminEN.Nombre = p_nombre;
        adminEN.Seguidores = p_seguidores;
        adminEN.Edad = p_edad;
        adminEN.Sexo = p_sexo;
        adminEN.Facebook = p_Facebook;
        adminEN.Instagram = p_Instagram;
        adminEN.Historial = p_Historial;
        adminEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);
        adminEN.Email = p_email;
        adminEN.Foto = p_foto;
        //Call to AdminCAD

        _IAdminCAD.Modify (adminEN);
}

public void Destroy (int ID
                     )
{
        _IAdminCAD.Destroy (ID);
}

public System.Collections.Generic.IList<AdminEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<AdminEN> list = null;

        list = _IAdminCAD.GetAll (first, size);
        return list;
}
public AdminEN GetID (int ID
                      )
{
        AdminEN adminEN = null;

        adminEN = _IAdminCAD.GetID (ID);
        return adminEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.AdminEN> ReadFilter ()
{
        return _IAdminCAD.ReadFilter ();
}
}
}



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
 *      Definition of the class PasoCEN
 *
 */
public partial class PasoCEN
{
private IPasoCAD _IPasoCAD;

public PasoCEN()
{
        this._IPasoCAD = new PasoCAD ();
}

public PasoCEN(IPasoCAD _IPasoCAD)
{
        this._IPasoCAD = _IPasoCAD;
}

public IPasoCAD get_IPasoCAD ()
{
        return this._IPasoCAD;
}

public int New_ (string p_descripcion, string p_localizacion, int p_ID, int p_gymkana_paso2)
{
        PasoEN pasoEN = null;
        int oid;

        //Initialized PasoEN
        pasoEN = new PasoEN ();
        pasoEN.Descripcion = p_descripcion;

        pasoEN.Localizacion = p_localizacion;

        pasoEN.ID = p_ID;


        if (p_gymkana_paso2 != -1) {
                // El argumento p_gymkana_paso2 -> Property gymkana_paso2 es oid = false
                // Lista de oids ID
                pasoEN.Gymkana_paso2 = new WhateverGenNHibernate.EN.Whatever.GymkanaEN ();
                pasoEN.Gymkana_paso2.ID = p_gymkana_paso2;
        }

        //Call to PasoCAD

        oid = _IPasoCAD.New_ (pasoEN);
        return oid;
}

public void Modify (int p_Paso_OID, string p_descripcion, string p_localizacion)
{
        PasoEN pasoEN = null;

        //Initialized PasoEN
        pasoEN = new PasoEN ();
        pasoEN.ID = p_Paso_OID;
        pasoEN.Descripcion = p_descripcion;
        pasoEN.Localizacion = p_localizacion;
        //Call to PasoCAD

        _IPasoCAD.Modify (pasoEN);
}

public void Destroy (int ID
                     )
{
        _IPasoCAD.Destroy (ID);
}
}
}

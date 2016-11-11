

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

public int New_ (string p_descripcion, int p_gymkana_paso2)
{
        PasoEN pasoEN = null;
        int oid;

        //Initialized PasoEN
        pasoEN = new PasoEN ();
        pasoEN.Descripcion = p_descripcion;


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

public void Modify (int p_Paso_OID, string p_descripcion)
{
        PasoEN pasoEN = null;

        //Initialized PasoEN
        pasoEN = new PasoEN ();
        pasoEN.ID = p_Paso_OID;
        pasoEN.Descripcion = p_descripcion;
        //Call to PasoCAD

        _IPasoCAD.Modify (pasoEN);
}

public void Destroy (int ID
                     )
{
        _IPasoCAD.Destroy (ID);
}

public System.Collections.Generic.IList<PasoEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<PasoEN> list = null;

        list = _IPasoCAD.GetAll (first, size);
        return list;
}
public PasoEN GetID (int ID
                     )
{
        PasoEN pasoEN = null;

        pasoEN = _IPasoCAD.GetID (ID);
        return pasoEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> FiltrarPasos (int ? id_gym)
{
        return _IPasoCAD.FiltrarPasos (id_gym);
}
}
}

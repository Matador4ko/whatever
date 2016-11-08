

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
 *      Definition of the class MapaCEN
 *
 */
public partial class MapaCEN
{
private IMapaCAD _IMapaCAD;

public MapaCEN()
{
        this._IMapaCAD = new MapaCAD ();
}

public MapaCEN(IMapaCAD _IMapaCAD)
{
        this._IMapaCAD = _IMapaCAD;
}

public IMapaCAD get_IMapaCAD ()
{
        return this._IMapaCAD;
}

public int New_ (int p_reto_mapa, int p_evento_mapa2, int p_id, int p_paso_0, int p_latitud, int p_longitud, int p_zoom)
{
        MapaEN mapaEN = null;
        int oid;

        //Initialized MapaEN
        mapaEN = new MapaEN ();

        if (p_reto_mapa != -1) {
                // El argumento p_reto_mapa -> Property reto_mapa es oid = false
                // Lista de oids id
                mapaEN.Reto_mapa = new WhateverGenNHibernate.EN.Whatever.RetoEN ();
                mapaEN.Reto_mapa.ID = p_reto_mapa;
        }


        if (p_evento_mapa2 != -1) {
                // El argumento p_evento_mapa2 -> Property evento_mapa2 es oid = false
                // Lista de oids id
                mapaEN.Evento_mapa2 = new WhateverGenNHibernate.EN.Whatever.EventoEN ();
                mapaEN.Evento_mapa2.ID = p_evento_mapa2;
        }

        mapaEN.Id = p_id;


        if (p_paso_0 != -1) {
                // El argumento p_paso_0 -> Property paso_0 es oid = false
                // Lista de oids id
                mapaEN.Paso_0 = new WhateverGenNHibernate.EN.Whatever.PasoEN ();
                mapaEN.Paso_0.ID = p_paso_0;
        }

        mapaEN.Latitud = p_latitud;

        mapaEN.Longitud = p_longitud;

        mapaEN.Zoom = p_zoom;

        //Call to MapaCAD

        oid = _IMapaCAD.New_ (mapaEN);
        return oid;
}

public System.Collections.Generic.IList<MapaEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<MapaEN> list = null;

        list = _IMapaCAD.GetAll (first, size);
        return list;
}
public MapaEN GetID (int id
                     )
{
        MapaEN mapaEN = null;

        mapaEN = _IMapaCAD.GetID (id);
        return mapaEN;
}

public void Modify (int p_Mapa_OID, int p_latitud, int p_longitud, int p_zoom)
{
        MapaEN mapaEN = null;

        //Initialized MapaEN
        mapaEN = new MapaEN ();
        mapaEN.Id = p_Mapa_OID;
        mapaEN.Latitud = p_latitud;
        mapaEN.Longitud = p_longitud;
        mapaEN.Zoom = p_zoom;
        //Call to MapaCAD

        _IMapaCAD.Modify (mapaEN);
}

public void Destroy (int id
                     )
{
        _IMapaCAD.Destroy (id);
}
}
}

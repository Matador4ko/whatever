
using System;
// Definición clase MapaEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class MapaEN
{
/**
 *	Atributo reto_mapa
 */
private WhateverGenNHibernate.EN.Whatever.RetoEN reto_mapa;



/**
 *	Atributo evento_mapa2
 */
private WhateverGenNHibernate.EN.Whatever.EventoEN evento_mapa2;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo paso_0
 */
private WhateverGenNHibernate.EN.Whatever.PasoEN paso_0;



/**
 *	Atributo latitud
 */
private int latitud;



/**
 *	Atributo longitud
 */
private int longitud;



/**
 *	Atributo zoom
 */
private int zoom;






public virtual WhateverGenNHibernate.EN.Whatever.RetoEN Reto_mapa {
        get { return reto_mapa; } set { reto_mapa = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.EventoEN Evento_mapa2 {
        get { return evento_mapa2; } set { evento_mapa2 = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.PasoEN Paso_0 {
        get { return paso_0; } set { paso_0 = value;  }
}



public virtual int Latitud {
        get { return latitud; } set { latitud = value;  }
}



public virtual int Longitud {
        get { return longitud; } set { longitud = value;  }
}



public virtual int Zoom {
        get { return zoom; } set { zoom = value;  }
}





public MapaEN()
{
}



public MapaEN(int id, WhateverGenNHibernate.EN.Whatever.RetoEN reto_mapa, WhateverGenNHibernate.EN.Whatever.EventoEN evento_mapa2, WhateverGenNHibernate.EN.Whatever.PasoEN paso_0, int latitud, int longitud, int zoom
              )
{
        this.init (Id, reto_mapa, evento_mapa2, paso_0, latitud, longitud, zoom);
}


public MapaEN(MapaEN mapa)
{
        this.init (Id, mapa.Reto_mapa, mapa.Evento_mapa2, mapa.Paso_0, mapa.Latitud, mapa.Longitud, mapa.Zoom);
}

private void init (int id
                   , WhateverGenNHibernate.EN.Whatever.RetoEN reto_mapa, WhateverGenNHibernate.EN.Whatever.EventoEN evento_mapa2, WhateverGenNHibernate.EN.Whatever.PasoEN paso_0, int latitud, int longitud, int zoom)
{
        this.Id = id;


        this.Reto_mapa = reto_mapa;

        this.Evento_mapa2 = evento_mapa2;

        this.Paso_0 = paso_0;

        this.Latitud = latitud;

        this.Longitud = longitud;

        this.Zoom = zoom;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MapaEN t = obj as MapaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}

using System;
// Definición clase PasoEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class PasoEN
{
/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo gymkana_paso2
 */
private WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana_paso2;



/**
 *	Atributo paso
 */
private WhateverGenNHibernate.EN.Whatever.MapaEN paso;






public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.GymkanaEN Gymkana_paso2 {
        get { return gymkana_paso2; } set { gymkana_paso2 = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.MapaEN Paso {
        get { return paso; } set { paso = value;  }
}





public PasoEN()
{
}



public PasoEN(int iD, string descripcion, WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana_paso2, WhateverGenNHibernate.EN.Whatever.MapaEN paso
              )
{
        this.init (ID, descripcion, gymkana_paso2, paso);
}


public PasoEN(PasoEN paso)
{
        this.init (ID, paso.Descripcion, paso.Gymkana_paso2, paso.Paso);
}

private void init (int ID
                   , string descripcion, WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana_paso2, WhateverGenNHibernate.EN.Whatever.MapaEN paso)
{
        this.ID = ID;


        this.Descripcion = descripcion;

        this.Gymkana_paso2 = gymkana_paso2;

        this.Paso = paso;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PasoEN t = obj as PasoEN;
        if (t == null)
                return false;
        if (ID.Equals (t.ID))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.ID.GetHashCode ();
        return hash;
}
}
}

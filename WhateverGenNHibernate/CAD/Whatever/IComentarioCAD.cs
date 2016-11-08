
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int ID
                             );

void ModifyDefault (ComentarioEN comentario);



int New_ (ComentarioEN comentario);

void Destroy (int ID
              );


System.Collections.Generic.IList<ComentarioEN> GetAll (int first, int size);


ComentarioEN GetID (int ID
                    );
}
}


using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Paso_getAllCP) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class PasoCP : BasicCP
{
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> GetAllCP (int id_gym)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Paso_getAllCP) ENABLED START*/

        IPasoCAD pasoCAD = null;
        PasoCEN pasoCEN = null;

        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN>  result = null;


        try
        {
                SessionInitializeTransaction ();
                pasoCAD = new PasoCAD (session);
                pasoCEN = new  PasoCEN (pasoCAD);


                

                System.Collections.Generic.IList<PasoEN> list = null;

                list = pasoCAD.GetAllCP (0, 0);
                foreach (PasoEN element in list)
                {
                    if (element.Gymkana_paso2.ID == id_gym)
                    {
                        result.Add(element);
                    }
                }
                return result;



        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}

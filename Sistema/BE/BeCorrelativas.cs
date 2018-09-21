using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;
using System.Data;

namespace Sistema.BE
{
    class BeCorrelativas
    {
        DalCorrelativas Dalc = new DalCorrelativas();

        public void GuardarCorrelativasBE(DataTable dtCor)
        {
            Dalc.GuardarCorrelativasDAL(dtCor);
        }


        public void EliminarCorrelativasBE(DataTable dtCor)
        {
            Dalc.EliminarCorrelativasDAL(dtCor);
        }

    }
}

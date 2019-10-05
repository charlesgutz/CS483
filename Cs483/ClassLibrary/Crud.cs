using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Crud<T> : ICrud<T>
    {
        public List<T> Lista()
        {
            throw new NotImplementedException();
        }

        public List<T> Listar()
        {
            T t = Activator.CreateInstance<T>();
            List<T> ps = new List<T>();
            ps.Add(t);
            return ps;
        }

        class A
        {
            public void CriaLista()
            {
                Crud<Pessoa> crudP = new Crud<Pessoa>();
                var lista = crudP.Listar();
            }
        }
    }
}

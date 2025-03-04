﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text.RegularExpressions;


namespace Controladora
{
    public class Facade
    {
        public static Facade instancia;
        public static Facade OBTENER_INSTANCIA()
         {
            if (instancia == null)
            {
                instancia = new Facade();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        public Facade()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        //USUARIOS -----------------------------
        public void AGREGAR_USUARIO(Modelo.Usuario oUsuario)
        {
            oFabrica.USUARIOS.Add(oUsuario);
            oFabrica.SaveChanges();
        }
        public void ELMINIAR_USUARIO(Modelo.Usuario oUsuario)
        {
            oFabrica.USUARIOS.Remove(oUsuario);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_USUARIO(Modelo.Usuario oUsuario)
        {
            oFabrica.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        //LISTAR 
        public System.Collections.IEnumerable LISTAR_USUARIOS(int cantidad = 10, string Usuario = "", string Email = "", string Nombre = "")
        {
            var usuarios = from usuario in oFabrica.USUARIOS.Include("Grupo").ToList()
                           where (usuario.USUARIO.ToLower().Contains(Usuario.ToLower()) && usuario.EMAIL.ToLower().Contains(Email.ToLower()) && usuario.NOMBRE.ToLower().Contains(Nombre.ToLower()))
                           select new
                           {
                               CODIGO = usuario.CODIGO_USUARIO,
                               NOMBRE = usuario.NOMBRE,
                               EMAIL = usuario.EMAIL,
                               USUARIO = usuario.USUARIO,
                           };
            return usuarios.Take(cantidad).ToList();
        }
        public Modelo.Usuario BUSCAR_USUARIO(Int32 CODIGO)
        {
            return oFabrica.USUARIOS.Find(CODIGO);
        }
        public Modelo.Usuario BUSCAR(string user, string password)
        {
            try
            {
                password = Encriptar(password);
                return oFabrica.USUARIOS.Include(a => a.GRUPO.Select(b => b.PERMISOS)).Where(c => c.USUARIO == user && c.CONTRASEÑA == password).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public string Encriptar(string passVista)
        {
            string passEncriptado = string.Empty;
            SHA512 sha512 = SHA512.Create();

            UTF8Encoding encoding = new UTF8Encoding();

            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha512.ComputeHash(encoding.GetBytes(passVista));

            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x1}", stream[i]);
            }

            return passEncriptado = sb.ToString();
        }
        //GRUPOS -----------------------------
        public void AGREGAR_GRUPO(Modelo.Grupo oGrupo)
        {
            foreach (var item in oFabrica.GRUPOS.ToList())
            {
                if (item.NOMBRE == oGrupo.NOMBRE)
                {
                    throw new Exception();
                }
            }
            oFabrica.GRUPOS.Add(oGrupo);
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_GRUPO(Modelo.Grupo oGrupo)
        {
            oFabrica.GRUPOS.Remove(oGrupo);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_GRUPO(Modelo.Grupo oGrupo)
        {
            oFabrica.Entry(oGrupo).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_GRUPOCMB()
        {
            return oFabrica.GRUPOS.Include("Permisos").ToList();
        }
        public System.Collections.IEnumerable LISTAR_GRUPOS()
        {
            var grupos = from grupo in oFabrica.GRUPOS.Include("Permisos").ToList()
                         select new
                         {
                             CODIGO = grupo.CODIGO_GRUPO,
                             NOMBRE = grupo.NOMBRE,
                         };
            return grupos.ToList();
        }
        public Modelo.Grupo BUSCAR_GRUPO(Int32 CODIGO)
        {
            return oFabrica.GRUPOS.Find(CODIGO);
        }
        public List<Modelo.Grupo> OBTENER_GRUPOS()
        {
            return oFabrica.GRUPOS.ToList();
        }
        //SEGURIDAD -----------------------------
        public void AGREGAR_PERMISO(Modelo.Permiso oPermiso)
        {
            oFabrica.PERMISO.Add(oPermiso);
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_PERMISO(Modelo.Permiso oPermiso)
        {
            oFabrica.PERMISO.Remove(oPermiso);
            oFabrica.SaveChanges();
        }
        public List<Modelo.Formulario> Obtener_Formularios(string accion)
        {
            List<Modelo.Formulario> Formularios = new List<Modelo.Formulario>();
            foreach (var formulario in oFabrica.FORMULARIO.Include(a => a.ACCIONES).ToList())
            {
                foreach (var acciones in formulario.ACCIONES)
                {
                    if (acciones.ACCION == accion)
                    {
                        Formularios.Add(formulario);
                    }
                }
            }
            return Formularios.ToList();
        }
        public bool ValidacionEMAIL(string Mail)//validacion formato de direccion de e-mail
        {

            Regex mRegxExpression;

            if (Mail.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Mail.Trim()))
                {
                    //no es correcta
                    return false;
                }
                else
                {
                    //es correcta
                    return true;
                }

            }
            else
            {
                //no es correcta, esta vacia
                return false;
            }
        }
    }
}

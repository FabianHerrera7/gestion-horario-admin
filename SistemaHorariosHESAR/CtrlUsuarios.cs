using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class CtrlUsuarios
    {
        public string ctrlregistro(Usuario usuario)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Alias) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.Conpassword) || string.IsNullOrEmpty(usuario.Email))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                if (usuario.Password == usuario.Conpassword)
                {
                    if (modelo.existeusuario(usuario.Alias))
                    {
                        respuesta = "El usuario ya existe";

                    }
                    else
                    {
                        usuario.Password = generarSHA1(usuario.Password);
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";

                }
            }
            return respuesta;



        }

        public string ctrllogin(string usuario, string password)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            string respuesta = "";
            Usuario datosusuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                datosusuario = modelo.porusuario(usuario);

                if (datosusuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosusuario.Password != generarSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no coincicen";

                    }
                }
            }
            return respuesta;
        }



        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);


            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}


using System;

namespace singleton
{
    public class login {

        private static login instancia;
        private String user;
        private String pass;

        private login() {

            this.user = "";
            this.pass = "";
        }

        public static login getInstancia() {

            if (instancia == null) {

                instancia = new login();
            }
            return instancia;
        }

        public static login Instace{

            get{
                if (instancia == null) {

                    instancia = new login();
                }
                
                return instancia;
            }
        }

        public void lg()  {

            Console.WriteLine("Bienvenido "+this.user);
        }

        //setter
        public void set_lg(String user, String pass) {

            this.user = user;
            this.pass = pass;
        }

    }
}

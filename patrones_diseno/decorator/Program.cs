using System;

namespace adapter
{
    public abstract class Component
    {
        public abstract string mensaje();
    }

    class ConcreteComponent : Component
    {
        public override string mensaje()
        {
            return "Hola, Como estas?";
        }
    }


    abstract class MensajeDecorator : Component
    {
        protected Component _component;

        public MensajeDecorator(Component component)
        {
            this._component = component;
        }

        public void SetComponent(Component component)
        {
            this._component = component;
        }

        public override string mensaje()
        {
            if (this._component != null)
            {
                return this._component.mensaje();
            }
            else
            {
                return string.Empty;
            }
        }
    }


    class mensaje_correo : MensajeDecorator
    {
        public mensaje_correo(Component comp) : base(comp)
        {
        }

        public override string mensaje()
        {
            return $"(Enviando mensaje desde el correo: {base.mensaje()})";
        }
    }


    class mensaje_whatsapp : MensajeDecorator
    {
        public mensaje_whatsapp(Component comp) : base(comp)
        {
        }

        public override string mensaje()
        {
            return $"(Mensaje enviado desde whatsapp: {base.mensaje()})";
        }
    }
    
    public class Client
    {
        public void ClientMS(Component component)
        {
            Console.WriteLine("Resultado: " + component.mensaje());
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            client.ClientMS(simple);

            mensaje_correo      MensajeDecorator1 = new mensaje_correo(simple);
            mensaje_whatsapp    MensajeDecorator2 = new mensaje_whatsapp(simple);

            client.ClientMS(MensajeDecorator1);
            client.ClientMS(MensajeDecorator2);
        }
    }
}

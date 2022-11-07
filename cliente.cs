public struct ClienteStruc{

public ClienteStruc(string nombre, string telefono, string direccion, string email)
{

this.Nombre = nombre;
this.Telefono= telefono;
this.Direccion=direccion;
this.Email = email;

}

public string Nombre { get; set; }

public string Telefono { get; set; }

public string Direccion { get; set; }

public string Email { get; set; }


    public override string ToString()
    {
        return $"Mi Nombre es {Nombre} , Mi numero de contacto es {Telefono}, y vivo en {Direccion}, puedes enviarme cualquier direccion al {Email}";
    }


}
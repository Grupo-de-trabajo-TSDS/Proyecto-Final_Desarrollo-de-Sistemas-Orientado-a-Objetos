using System;

public class Persona
{
	public Class1()
	{
		private string dni;
		private string apellido;
    private string nombre;
    private string fechanac;
    private string fechainscrip;
    private string direccion;
    private string email;
    private string telefono;
    private string conturgencia;
    private string fichamed;

    //constructor
    public Persona(string dni, string apellido, string nombre, string fechanac, string fechainscrip, string direccion, string email, string telefono, string conturgencia, string fichamed)
    {
        this.dni = dni;
        this.apellido = apellido;
        this.nombre = nombre;
        this.fechanac = fechanac;
        this.fechainscrip = fechainscrip;
        this.direccion = direccion;
        this.email = email;
        this.telefono = telefono;
        this.conturgencia = conturgencia;
        this.fichamed = fichamed;
    }

    //getter y setter
    public string Dni{ get { return dni; } set { dni = value; }}
    public string Apellido { get { return apellido; } set { apellido = value; } }
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string Fechanac { get { return fechanac; } set { fechanac = value; } }
    public string Fechainscrip { get { return fechainscrip; } set { fechainscrip = value; } }
    public string Direccion { get { return direccion; } set { direccion = value; } }
    public string Email { get { return email; } set { email = value; } }
    public string Telefono { get { return telefono; } set { telefono = value; } }
    public string Conturgencia { get { return conturgencia; } set { conturgencia = value; } }
    public string Fichamed { get { return fichamed; } set { fichamed = value; } }
}
}

public class Socio : Persona
{
    private bool estado;
    
    //constructor

    :base(dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed)
    
    {
        this.estado = estado;
    }

//getter y setter
    public bool Estado { get { return estado; } set { estado = value; } }
 
   

//methods    

public void suspender()
    {
        //code to inscribe a member
    }
    public void inscripcionSocio()
    {
        //code to suspend a member
    }
    public void generarCarnet()
    {
        //code to inscribe a non-member
    }
}

public class NoSocio : Persona
{
    
    //constructor
    :base(string dni, string apellido, string nombre, string fechanac, string fechainscrip, string direccion, string email, string telefono, string conturgencia, string fichamed, string motivo) : base(dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed)
        
    //methods
    public void inscripcionNoSocio()
    {
        //code to inscribe a non-member
    }

    public void registrarActividad()
    {
        //code to register Non-member activity
    }

    public void abonarActividad()
    {
        //code to pay for a non-member activity
    }
}
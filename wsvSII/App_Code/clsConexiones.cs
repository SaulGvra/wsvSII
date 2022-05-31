using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

public class clsConexiones
{

    private string cadConexion = ConfigurationManager.ConnectionStrings["mySqlCadConn"].ConnectionString;

    public clsConexiones()
    {

    }

    public DataSet qryAcceso(string control, string contra, string tipo)
    {

        string cadsql = "";
        cadsql += "call sp_Acceso('" + control + "', " + contra + ", " + tipo + ");";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "acceso");
        return ds;

    }

    public DataSet insCarrera(string carrera)
    {

        string cadsql = "";
        cadsql += "call sii_insCarrera('" + carrera +"');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insCarrera");
        return ds;

    }

    public DataSet insAlumno(string nocontrol,
                             string nombre,
                             string paterno,
                             string materno,
                             string contra,
                             string tel,
                             string fecha,
                             string sem,
                             string dir,
                             string esp,
                             string estatus,
                             string carrera)
    {

        string cadsql = "";
        cadsql += "call sii_insAlumno('" + nocontrol + "', '" + nombre + "', '" + paterno + "', '" + materno + "', '" + contra + "', " + tel + ", '" + fecha + "', " + sem + ", '" + dir + "', '" + esp + "', '" + estatus + "', " + carrera + ");";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insAlumno");
        return ds;

    }

    public DataSet insAspirante (string aspiranteid,
                                 string nip,
                                 string nombre,
                                 string paterno,
                                 string materno,
                                 string tel,
                                 string fecha,
                                 string dir,
                                 string carrera)
    {

        string cadsql = "";
        cadsql += "call sii_insAspirante('" + aspiranteid + "', " + nip + ", '" + nombre + "', '" + paterno + "', '" + materno + "', " + tel + ", '" + fecha + "', '" + dir + "', " + carrera + ");";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insAspirante");
        return ds;

    }

    public DataSet insPersonal (string personalid,
                                string nombre,
                                string paterno,
                                string materno,
                                string contra,
                                string tel,
                                string fecha,
                                string dir,
                                string salario,
                                string tipo)
    {

        string cadsql = "";
        cadsql += "call sii_insPersonal('" + personalid + "', '" + nombre + "', '" + paterno + "', '" + materno + "', '" + contra + "', " + tel + ", '" + fecha + "', '" + dir + "', " + salario + ", '" + tipo + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insPersonal");
        return ds;

    }

    public DataSet insClase (string claseid,
                             string salon,
                             string horario,
                             string capacidad,
                             string periodo,
                             string personalid,
                             string materiaid)
    {

        string cadsql = "";
        cadsql += "call sii_insClase('" + claseid + "', '" + salon + "', '" + horario + "', " + capacidad + ", '" + periodo + "', '" + personalid + "', '" + materiaid + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insClase");
        return ds;

    }

    public DataSet insClaseXAlumno (string claseid,
                                    string nocontrol,
                                    string estado)
    {

        string cadsql = "";
        cadsql += "call sii_insClaseXAlumno('" + claseid + "', '" + nocontrol + "', '" + estado + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insClaseXAlumno");
        return ds;

    }

    public DataSet insCalificacion (string calificacionid,
                                    string un1,
                                    string un2,
                                    string un3,
                                    string un4,
                                    string un5,
                                    string un6,
                                    string nocontrol,
                                    string claseid)
    {

        string cadsql = "";
        cadsql += "call sii_insCalificacion('" + calificacionid + "', " + un1 + ", " + un2 + "', " + un3 + ", " + un4 + "', " + un5 + ", " + un6 + ", '" + nocontrol + "', '" + claseid + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insCalificacion");
        return ds;

    }

    public DataSet insReinscripcion (string rnsid,
                                     string monto,
                                     string fecha,
                                     string nocontrol)
    {

        string cadsql = "";
        cadsql += "call sii_insReinscripcion('" + rnsid + "', " + monto + ", '" + fecha + "', '" + nocontrol + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insReinscripcion");
        return ds;

    }

    public DataSet insMateria (string materiaid,
                               string nombre,
                               string horasp,
                               string horast,
                               string sem,
                               string creditos,
                               string seriada)
    {

        string cadsql = "";
        cadsql += "call sii_insMateria('" + materiaid + "', '" + nombre + "', " + horasp + ", " + horast + ", " + sem + ", " + creditos + ", '" + seriada + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insMateria");
        return ds;

    }

    public DataSet insMateriaxCarrera (string materia,
                                       string carrera)
    {

        string cadsql = "";
        cadsql += "call sii_insMateriaxCarrera('" + materia + "', " + carrera + ");";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insMateriaxCarrera");
        return ds;

    }

    public DataSet insAdeudo (string biblioteca,
                              string escolares,
                              string financieros,
                              string otros,
                              string nocontrol)
    {

        string cadsql = "";
        cadsql += "call sii_insAdeudo(" + biblioteca + ", " + escolares + ", " + financieros + "', " + otros + ", '" + nocontrol + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "insAdeudo");
        return ds;

    }

    public DataSet delBajaAlumno (string nocontrol)
    {

        string cadsql = "";
        cadsql += "call sp_DelBajaAlumno('" + nocontrol + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "delBajaAlumno");
        return ds;

    }

    public DataSet delBajaAspirante (string clave)
    {

        string cadsql = "";
        cadsql += "call sp_DelBajaAspirante('" + clave + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "delBajaAspirante");
        return ds;

    }

    public DataSet delBajaMateria (string nocontrol,
                                   string materiaid)
    {

        string cadsql = "";
        cadsql += "call sp_DelBajaMateria('" + nocontrol + "', '" + materiaid + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "delBajaMateria");
        return ds;

    }

    public DataSet delBajaPersonal (string id)
    {

        string cadsql = "";
        cadsql += "call sp_DelBajaPersonal('" + id + "');";

        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);

        DataSet ds = new DataSet();

        da.Fill(ds, "delBajaPersonal");
        return ds;

    }

    public DataSet updAlumno(string nocontrol,
                               string nombre,
                               string paterno,
                               string materno,
                               string telefono,
                               string fecha,
                               string direccion)
    {
        string cadsql = "";
        cadsql += "call sp_UpdAlumno('" + nocontrol + "','" + nombre + "', '" + paterno + "','" + materno + "', " + telefono + ",'" + fecha + "','" + direccion + "');";
        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Alumno");
        return ds;
    }

    public DataSet updAdeudos(string biblioteca,
                               string escolares,
                               string financieros,
                               string otros,
                               string nocontrol)
    {
        string cadsql = "";
        cadsql += "call sp_UpdAdeudos('" + biblioteca + "','" + escolares + "', '" + financieros + "','" + otros + "', '" + nocontrol + "');";
        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Adeudos");
        return ds;
    }

    public DataSet updAspirante(string noaspirante,
                               string nombre,
                               string paterno,
                               string materno,
                               string telefono,
                               string fecha,
                               string direccion)
    {
        string cadsql = "";
        cadsql += "call sp_UpdAspirante('" + noaspirante + "','" + nombre + "', '" + paterno + "','" + materno + "', " + telefono + ",'" + fecha + "','" + direccion + "');";
        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Aspirante");
        return ds;
    }

    public DataSet updCalificacion(int unidad1,
                                    int unidad2,
                                    int unidad3,
                                    int unidad4,
                                    int unidad5,
                                    int unidad6,
                                    string nocontrol,
                                    string clase)
    {
        string cadsql = "";
        cadsql += "call sp_UpdCalificacion(" + unidad1 + "," + unidad2 + ", " + unidad3 + "," + unidad4 + ", " + unidad5 + ", " + unidad6 + ", '" + nocontrol + "', '" + clase + "');";
        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Calificacion");
        return ds;
    }

    public DataSet updClase(string salon,
                               string horario,
                               int capacidad,
                               string periodo,
                               string personall,
                               string tipo,
                               string clasee)
    {
        string cadsql = "";
        cadsql += "call sp_UpdClase('" + salon + "','" + horario + "', " + capacidad + ",'" + periodo + "', " + personall + ",'" + tipo + "','" + clasee + "');";
        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Clase");
        return ds;
    }

    public DataSet updPersonal(string tipo,
                               string nombre,
                               string paterno,
                               string materno,
                               string contraseña,
                               string telefono,
                               string fecha,
                               string direccion,
                               int salario,
                               string personall)
    {
        string cadsql = "";
        cadsql += "call sp_UpdPersonalMaster('" + tipo + "','" + nombre + "', '" + paterno + "','" + materno + "', " + contraseña + ",'" + telefono + "','" + fecha + "','" + direccion + "'," + salario + ",'" + personall + "');";
        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Personal");
        return ds;
    }

    public DataSet updPersonalMaestro(string nombre,
                                         string paterno,
                                         string materno,
                                         string telefono,
                                         string fecha,
                                         string direccion,
                                         string personall,
                                         string tipo)
    {
        string cadsql = "";
        cadsql += "call sp_UpdPersonal('" + nombre + "', '" + paterno + "','" + materno + "', " + ",'" + telefono + "','" + fecha + "','" + direccion + "'," + ",'" + personall + "','" + tipo + "');";
        MySqlConnection cnn = new MySqlConnection(cadConexion);
        MySqlDataAdapter da = new MySqlDataAdapter(cadsql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Personal");
        return ds;
    }

}
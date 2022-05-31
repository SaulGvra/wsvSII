using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Conexiones : System.Web.Services.WebService
{

    public Conexiones()
    {

    }

    [WebMethod]
    public DataSet qryAcceso(string control, string contra, string tipo)
    {

        clsConexiones obj = new clsConexiones();
        return obj.qryAcceso(control, contra, tipo);

    }

    [WebMethod]
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

        clsConexiones obj = new clsConexiones();
        return obj.insAlumno(nocontrol, nombre, paterno, materno, contra, tel, fecha, sem, dir, esp, estatus, carrera);

    }

    [WebMethod]
    public DataSet insCarrera(string carrera)
    {

        clsConexiones obj = new clsConexiones();
        return obj.insCarrera(carrera);

    }

    [WebMethod]
    public DataSet insAspirante(
                                string nombre,
                                string paterno,
                                string materno,
                                string tel,
                                string fecha,
                                string dir,
                                string carrera)
    {

        clsConexiones obj = new clsConexiones();
        return obj.insAspirante(nombre, paterno, materno, tel, fecha, dir, carrera);

    }

    [WebMethod]
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

        clsConexiones obj = new clsConexiones();
        return obj.insPersonal(personalid, nombre, paterno, materno, contra, tel, fecha, dir, salario, tipo);

    }

    [WebMethod]
    public DataSet insClase (string claseid,
                             string salon,
                             string horario,
                             string capacidad,
                             string periodo,
                             string personalid,
                             string materiaid)
    {

        clsConexiones obj = new clsConexiones();
        return obj.insClase(claseid, salon, horario, capacidad, periodo, personalid, materiaid);

    }

    [WebMethod]
    public DataSet insClaseXAlumno (string claseid,
                                    string nocontrol,
                                    string estado)
    {

        clsConexiones obj = new clsConexiones();
        return obj.insClaseXAlumno(claseid, nocontrol, estado);

    }

    [WebMethod]
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

        clsConexiones obj = new clsConexiones();
        return obj.insCalificacion(calificacionid, un1, un2, un3, un4, un5, un6, nocontrol, claseid);

    }

    [WebMethod]
    public DataSet insReinscripcion (string rnsid,
                                     string monto,
                                     string fecha,
                                     string nocontrol)
    {

        clsConexiones obj = new clsConexiones();
        return obj.insReinscripcion(rnsid, monto, fecha, nocontrol);

    }

    [WebMethod]
    public DataSet insMateria (string materiaid,
                               string nombre,
                               string horasp,
                               string horast,
                               string sem,
                               string creditos,
                               string seriada)
    {

        clsConexiones obj = new clsConexiones();
        return obj.insMateria(materiaid, nombre, horasp, horast, sem, creditos, seriada);

    }

    [WebMethod]
    public DataSet insMateriaxCarrera (string materia,
                                       string carrera)
    {

        clsConexiones obj = new clsConexiones();
        return obj.insMateriaxCarrera(materia, carrera);

    }

    [WebMethod]
    public DataSet insAdeudo (string biblioteca,
                              string escolares,
                              string financieros,
                              string otros,
                              string nocontrol)
    {

        clsConexiones obj = new clsConexiones();
        return obj.insAdeudo(biblioteca, escolares, financieros, otros, nocontrol);

    }

    [WebMethod]
    public DataSet delBajaAlumno(string nocontrol)
    {
        clsConexiones obj = new clsConexiones();
        return obj.delBajaAlumno(nocontrol);
    }

    [WebMethod]
    public DataSet delBajaAspirante(string clave)
    {
        clsConexiones obj = new clsConexiones();
        return obj.delBajaAspirante(clave);
    }

    [WebMethod]
    public DataSet delBajaMateria(string nocontrol, string materiaid)
    {
        clsConexiones obj = new clsConexiones();
        return obj.delBajaMateria(nocontrol, materiaid);
    }

    [WebMethod]
    public DataSet delBajaPersonal(string id)
    {
        clsConexiones obj = new clsConexiones();
        return obj.delBajaPersonal(id);
    }

    [WebMethod]
    public DataSet updAlumno(string nocontrol,
                               string nombre,
                               string paterno,
                               string materno,
                               string telefono,
                               string fecha,
                               string direccion)
    {
        clsConexiones obj = new clsConexiones();
        return obj.updAlumno(nocontrol, nombre, paterno, materno, telefono, fecha, direccion);
    }

    [WebMethod]
    public DataSet updAdeudos(string biblioteca,
                               string escolares,
                               string financieros,
                               string otros,
                               string nocontrol)
    {
        clsConexiones obj = new clsConexiones();
        return obj.updAdeudos(biblioteca, escolares, financieros, otros, nocontrol);
    }

    [WebMethod]
    public DataSet updAspirante(string noaspirante,
                               string nombre,
                               string paterno,
                               string materno,
                               string telefono,
                               string fecha,
                               string direccion)
    {
        clsConexiones obj = new clsConexiones();
        return obj.updAspirante(noaspirante, nombre, paterno, materno, telefono, fecha, direccion);
    }

    [WebMethod]
    public DataSet updCalificacion(int unidad1,
                                    int unidad2,
                                    int unidad3,
                                    int unidad4,
                                    int unidad5,
                                    int unidad6,
                                    string nocontrol,
                                    string clase)
    {
        clsConexiones obj = new clsConexiones();
        return obj.updCalificacion(unidad1, unidad2, unidad3, unidad4, unidad5, unidad6, nocontrol, clase);
    }

    [WebMethod]
    public DataSet updClase(string salon,
                               string horario,
                               int capacidad,
                               string periodo,
                               string personall,
                               string tipo,
                               string clasee)
    {
        clsConexiones obj = new clsConexiones();
        return obj.updClase(salon, horario, capacidad, periodo, personall, tipo, clasee);
    }

    [WebMethod]
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
        clsConexiones obj = new clsConexiones();
        return obj.updPersonal(tipo, nombre, paterno, materno, contraseña, telefono, fecha, direccion, salario, personall);
    }

    [WebMethod]
    public DataSet updPersonalMaestro(string nombre,
                                         string paterno,
                                         string materno,
                                         string telefono,
                                         string fecha,
                                         string direccion,
                                         string personall,
                                         string tipo)
    {
        clsConexiones obj = new clsConexiones();
        return obj.updPersonalMaestro(nombre, paterno, materno, telefono, fecha, direccion, personall, tipo);
    }

}
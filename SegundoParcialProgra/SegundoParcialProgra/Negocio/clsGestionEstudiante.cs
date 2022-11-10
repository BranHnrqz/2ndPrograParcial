using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoParcialProgra.Data;
using System.Data;

namespace SegundoParcialProgra.Negocio
{
    class clsGestionEstudiante
    {
        clsEstudiante student = new clsEstudiante();

        //METODO PARA CARGAR LOS DATOS DE LA TABLA DE USUARIO EN UN DATAGRIDVIEW
        public DataTable ViewStudents()
        {
            DataTable Table = new DataTable();
            Table = student.Estudiantes();
            return Table;
        }
        //RegistrarEstudiantes
        public void StudentReg(string nombre, string Apellido, string Carrera, string Asignatura, double Promedio1, double Promedio2, double Promedio3, double PromedioFinal)
        {
            int idStudent = student.idStudent();
            student.StudentReg(idStudent, nombre, Apellido, Carrera, Asignatura, Promedio1, Promedio2, Promedio3, PromedioFinal);
        }

        //Función para Calcular Promedio
        public double CalcPromFnl(double Promedio1, double Promedio2, double Promedio3)
        {
            double PromedioFinal = (Promedio1 + Promedio2 + Promedio3) / 3;
            return PromedioFinal;
        }
    }
}

using Application.ABSTRACTIONS;
using System;

namespace Application.BE
{
    public class Turno : IEntity, IDigitoVerificador
    {
        public int client { get; set; }
        public char estado { get; set; }
        public int sucursal { get; set; }
        public int profesional { get; set; }
        public int estudio { get; set; }
        public int agenda { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaTurno { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int Id { get; set; }
        public string DVH { get ; set ; }
        public string DVV { get ; set ; }

        public override string ToString()
        {
            return $"Cliente: {client}, Estado: {estado}, Sucursal: {sucursal}, Profesional: {profesional}, Estudio: {estudio}, Agenda: {agenda}, " +
                $"Fecha Creacion: {fechaCreacion}, Fecha Turno: {fechaTurno}, Fecha Entrega: {fechaEntrega}";
        }
    }

}

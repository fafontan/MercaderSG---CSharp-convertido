﻿using System;
using System.Collections.Generic;

namespace Entidades
{
    public class NotaPedidoEN
    {
        private int _codnot;

        public int CodNot
        {
            get
            {
                return _codnot;
            }

            set
            {
                _codnot = value;
            }
        }

        private string _nronota;

        public string NroNota
        {
            get
            {
                return _nronota;
            }

            set
            {
                _nronota = value;
            }
        }

        private int _codprov;

        public int CodProv
        {
            get
            {
                return _codprov;
            }

            set
            {
                _codprov = value;
            }
        }

        private DateTime _fecha;

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        private bool _activo;

        public bool Activo
        {
            get
            {
                return _activo;
            }

            set
            {
                _activo = value;
            }
        }

        private List<DetalleEN> _detalle;

        public List<DetalleEN> Detalle
        {
            get
            {
                return _detalle;
            }

            set
            {
                _detalle = value;
            }
        }
    }
}
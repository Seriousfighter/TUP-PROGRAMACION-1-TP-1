namespace estaciones.Models
{
    class Fecha
    {
        private int _dia;
        private int _mes;
        private int _anio;
        
        public int Dia {
            get
            {
                return _dia;
            }
            set
            {
                _dia = value;
            }
        }
        public int Mes
        {
            get
            {
                return _mes;
            }
            set
            {
                _mes = value;
            }
        }
        public int Anio
        {
            get
            {
                return _anio;
            }
            set
            {
                _anio = value;
            }
        }

        //constructors
        public Fecha()
        {
            _dia = 0;
            _mes = 0;
            _anio = 0;
        }
        public Fecha(int dia, int mes, int anio)
        {
            Dia = dia;
            Mes = mes;
            Anio = anio;
        }

        public bool ValidarFecha()
        {
            // Validar la combinación de día y mes según los días del mes
            int dia = this.Dia;
            int mes = this.Mes;
            int anio = this.Anio;
            if(dia <1 || mes < 1 || anio < 1)
            {
                return false;
            }
            if (mes == 2)
            {
                // Febrero
                if (dia > 29 || (dia == 29 && !EsAnioBisiesto()))
                {
                    return false;
                }
            }
            else if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30)
            {
                return false;
            }
            else if(dia > 31 || mes > 12)
            {
                return false;
            }
                return true;
        }
        private bool EsAnioBisiesto()
        {
            int anio= this.Anio;
            // Un año es bisiesto si es divisible por 4 y no divisible por 100, o si es divisible por 400
            return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
        }
    }
}

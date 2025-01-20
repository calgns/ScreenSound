using System;
using System.Collections.Generic;

namespace PrimeiroProjeto.Contollers.Componentes;
public class DB {
    private static Dictionary<string, List<double>> listaDasBandas = new Dictionary<string, List<double>> {
        { "U2",                 new List<double> { 4.0, 8.6 }       },
        { "The Beatles",        new List<double> { 8.32, 10, 2 }    },
        { "Calypso",            new List<double> { 5.99 }           },
        { "Ink Spots",          new List<double> { 7.45, 8.63, 5 }  },
        { "Lawfey",             new List<double> { 2 }              },
        { "The Andrew Sisters", new List<double> { 6.8, 5.2 }       },
        { "Erik Satie",         new List<double>()                  }
    }; public static Dictionary<string, List<double>> ListaDasBandas { get => listaDasBandas; set => listaDasBandas = value; }

}
